using descktop.Data;
using descktop.Services;
using descktop.Utils;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace descktop.Services
{
    class PedidoService
    {
        DBService DBService;

        public PedidoService()
        {
            DBService = new DBService();
        }


        public List<PedidosModel> lsPedidos(int idEmp, List<int> idPed, bool buscarPedAbertos = true, string paginacao = "", int pagina = 0)
        {
            string idPedidos = "";
            string top = "";
            if (buscarPedAbertos)
            {
                idPedidos = "in (";
            }
            else
            {
                top = " top 10 ";
                idPedidos = "not in (";
            }
            foreach (var item in idPed)
            {
                idPedidos += item.ToString() + ",";
            }

            string comandoSql = "select " + top +
                "ped_Pedido_int_PK," +
                "ped_Empresa_int_FK," +
                "ped_idCliente_int_FK," +
                "ped_ValorTotal_mon," +
                "ped_DataVenda_dtm," +
                "ped_Observacao_chr," +
                "ped_Desconto_mon " +
                "from TB_CA_Pedidos_ped " +
                "where ped_Empresa_int_FK = " + idEmp.ToString() +
                " and ped_Pedido_int_PK " + idPedidos + ") " +
                paginacao +
                " order by ped_DataVenda_dtm desc";

            OleDbCommand commando = new OleDbCommand(comandoSql, DBService.conexao);
            ClienteService clienteService = new ClienteService();
            ItemPedidoService itemPedidoService = new ItemPedidoService();

            try
            {
                //Abertura da conexão
                DBService.conexao.Open();

                //Executar o comando e ler os dados retornados
                OleDbDataReader dados = commando.ExecuteReader();

                List<PedidosModel> lstPedidos = new List<PedidosModel>();

                while (dados.Read())
                {
                    if ((int)dados["ped_Pedido_int_PK"] != -1)
                    {
                        DateTime dataVenda;
                        DateTime.TryParse(dados["ped_DataVenda_dtm"].ToString(), out dataVenda);

                        PedidosModel pedido = new PedidosModel();
                        pedido.cliente = new ClientesModel();

                        pedido.idPedido = (int)dados["ped_Pedido_int_PK"];
                        pedido.idEmpresa = (int)dados["ped_Empresa_int_FK"];
                        pedido.valorTotal = (decimal)dados["ped_ValorTotal_mon"];
                        pedido.dataVenda = dataVenda;

                        pedido.cliente = clienteService.seCliente(idEmp, (int)dados["ped_idCliente_int_FK"]);
                        pedido.Produtos = itemPedidoService.seItensPedido(idEmp, (int)dados["ped_Pedido_int_PK"]);
                        pedido.observacao = dados["ped_Observacao_chr"].ToString();
                        pedido.desconto = (decimal)dados["ped_Desconto_mon"];

                        lstPedidos.Add(pedido);
                    }
                    else
                    {
                        return null;
                    }
                }
                return lstPedidos;
            }
            catch (Exception exc)
            {

                throw new Exception(exc.Message);
            }
            finally
            {
                DBService.conexao.Close();
            }
        }

        public bool inPedido(int idEmp, PedidosModel pedido)
        {
            ItemPedidoService itemPedidoService = new ItemPedidoService();
            CondicaoService condicaoService = new CondicaoService();
            FreteService freteService = new FreteService();
            int idNovo = 0;

            string comandoSql1 = "insert into TB_CA_Pedidos_ped " +
                "(ped_Empresa_int_FK," +
                "ped_idCliente_int_FK," +
                "ped_ValorTotal_mon," +
                "ped_DataVenda_dtm," +
                "ped_Observacao_chr," +
                "ped_Desconto_mon ) values ( " +
                idEmp.ToString() + ", " +
                pedido.cliente.idCliente.ToString() + ", '" +
                pedido.valorTotal + "', '" +
                pedido.dataVenda + "', '" +
                pedido.observacao + "', '" +
                pedido.desconto + "' )";
            string comandoSql2 = "SELECT @@IDENTITY;";

            OleDbCommand cmd = new OleDbCommand(comandoSql1, DBService.conexao);
            OleDbCommand cmd2 = new OleDbCommand(comandoSql2, DBService.conexao);
            try
            {
                //Abertura da conexÃ£o
                DBService.conexao.Open();

                //Executar o comando e ler os dados retornados
                //cmd.ExecuteNonQuery();

                int succ = cmd.ExecuteNonQuery();

                if (succ == 0)
                {
                    return false;
                }
                else
                {
                    idNovo = (int)cmd2.ExecuteScalar();
                    bool succItem = itemPedidoService.inItensPedido(idEmp, idNovo, pedido.Produtos);
                    if (!succItem)
                    {
                        dePedido(idEmp, idNovo);
                        itemPedidoService.deItensPedido(idEmp, idNovo);
                        //fazer o rotina de excluir o pedido, pois se caiu aqui, deu erro
                        return false;
                    }
                    bool succCond = condicaoService.inCondicaoPedido(idEmp, idNovo, pedido.condicao);
                    if (!succCond)
                    {
                        dePedido(idEmp, idNovo);
                        itemPedidoService.deItensPedido(idEmp, idNovo);
                        condicaoService.deCondicaoPedido(idEmp, idNovo);
                        //fazer o rotina de excluir o pedido e os itensPedido, pois se caiu aqui, deu erro
                        return false;
                    }
                    bool succFret = freteService.inFretePedido(idEmp, idNovo, pedido.frete);
                    if (!succFret)
                    {
                        dePedido(idEmp, idNovo);
                        itemPedidoService.deItensPedido(idEmp, idNovo);
                        condicaoService.deCondicaoPedido(idEmp, idNovo);
                        freteService.deFretePedido(idEmp, idNovo);
                        //fazer o rotina de excluir o pedido, itensPedido e as CondicaoPedido, pois se caiu aqui, deu erro
                        return false;
                    }
                    return true;
                }
            }
            catch (Exception exc)
            {
                dePedido(idEmp, idNovo);
                itemPedidoService.deItensPedido(idEmp, idNovo);
                condicaoService.deCondicaoPedido(idEmp, idNovo);
                freteService.deFretePedido(idEmp, idNovo);

                throw new Exception(exc.Message);
            }
            finally
            {
                DBService.conexao.Close();
            }
        }

        public PedidosModel sePedido(int idEmp, int idPed)
        {
            string comandoSql = "select " +
                "ped_Pedido_int_PK," +
                "ped_Empresa_int_FK," +
                "ped_idCliente_int_FK," +
                "ped_ValorTotal_mon," +
                "ped_DataVenda_dtm," +
                "ped_Observacao_chr," +
                "ped_Desconto_mon " +
                "from TB_CA_Pedidos_ped " +
                "where ped_Empresa_int_FK = " + idEmp.ToString() +
                " and ped_Pedido_int_PK = " + idPed.ToString();

            OleDbCommand commando = new OleDbCommand(comandoSql, DBService.conexao);
            ClienteService clienteService = new ClienteService();
            ItemPedidoService itemPedidoService = new ItemPedidoService();

            try
            {
                //Abertura da conexão
                DBService.conexao.Open();

                //Executar o comando e ler os dados retornados
                OleDbDataReader dados = commando.ExecuteReader();
                PedidosModel pedido = new PedidosModel();

                while (dados.Read())
                {
                    if ((int)dados["ped_Pedido_int_PK"] != -1)
                    {
                        DateTime dataVenda;
                        DateTime.TryParse(dados["ped_DataVenda_dtm"].ToString(), out dataVenda);

                        pedido.cliente = new ClientesModel();

                        pedido.idPedido = (int)dados["ped_Pedido_int_PK"];
                        pedido.idEmpresa = (int)dados["ped_Empresa_int_FK"];
                        pedido.valorTotal = (decimal)dados["ped_ValorTotal_mon"];
                        pedido.dataVenda = dataVenda;

                        pedido.cliente = clienteService.seCliente(idEmp, (int)dados["ped_idCliente_int_FK"]);
                        pedido.Produtos = itemPedidoService.seItensPedido(idEmp, (int)dados["ped_Pedido_int_PK"]);
                        pedido.observacao = dados["ped_Observacao_chr"].ToString();
                        pedido.desconto = (decimal)dados["ped_Desconto_mon"];

                    }
                    else
                    {
                        return null;
                    }
                }
                return pedido;
            }
            catch (Exception exc)
            {

                throw new Exception(exc.Message);
            }
            finally
            {
                DBService.conexao.Close();
            }
        }

        public bool dePedido(int idEmp, int idPed)
        {
            ItemPedidoService itemPedidoService = new ItemPedidoService();
            CondicaoService condicaoService = new CondicaoService();
            FreteService freteService = new FreteService();
            //TB_CA_Pedidos_ped
            //ped_Pedido_int_PK ped_Empresa_int_FK ped_idCliente_int_FK ped_ValorTotal_mon  ped_DataVenda_dtm

            string comandoSql = "delete from TB_CA_Pedidos_ped " +
                "where ped_Empresa_int_FK = " + idEmp + " AND " +
                "ped_Pedido_int_PK = " + idPed;


            //OleDbCommand commando = new OleDbCommand(comandoSql, DBService.conexao);

            OleDbCommand cmd = new OleDbCommand(comandoSql, DBService.conexao);
            try
            {
                //Abertura da conexÃ£o
                DBService.conexao.Open();

                //Executar o comando e ler os dados retornados
                //cmd.ExecuteNonQuery();

                int succ = cmd.ExecuteNonQuery();

                if (succ == 0)
                {
                    return false;
                }
                else
                {
                    bool succItem = itemPedidoService.deItensPedido(idEmp, idPed);
                    if (!succItem)
                    {
                        //fazer o rotina de excluir o pedido, pois se caiu aqui, deu erro
                        return false;
                    }
                    bool succCond = condicaoService.deCondicaoPedido(idEmp, idPed);
                    if (!succCond)
                    {
                        //fazer o rotina de excluir o pedido e os itensPedido, pois se caiu aqui, deu erro
                        return false;
                    }
                    bool succFret = freteService.deFretePedido(idEmp, idPed);
                    if (!succFret)
                    {
                        //fazer o rotina de excluir o pedido, itensPedido e as CondicaoPedido, pois se caiu aqui, deu erro
                        return false;
                    }
                    return true;
                }
            }
            catch (Exception exc)
            {

                throw new Exception(exc.Message);
            }
            finally
            {
                DBService.conexao.Close();
            }
        }

        public List<int> lsIdPedido(int idEmp, int idCli)
        {
            string comandoSql = "select " +
                    "ped_Pedido_int_PK " +
                    "from TB_CA_Pedidos_ped " +
                    "where ped_Empresa_int_FK = " + idEmp + " and " +
                    "ped_idCliente_int_FK = " + idCli +
                    " order by ped_DataVenda_dtm desc";

            OleDbCommand commando = new OleDbCommand(comandoSql, DBService.conexao);

            try
            {
                //Abertura da conexÃ£o
                DBService.conexao.Open();

                //Executar o comando e ler os dados retornados
                OleDbDataReader dados = commando.ExecuteReader();

                List<int> lsIdPed = new List<int>();


                while (dados.Read())
                {
                    if ((int)dados["ped_Pedido_int_PK"] != -1)
                    {

                        int idPedido = (int)dados["ped_Pedido_int_PK"];

                        lsIdPed.Add(idPedido);
                    }
                    else
                    {
                        return null;
                    }
                }
                return lsIdPed;
            }
            catch (Exception exc)
            {

                throw new Exception(exc.Message);
            }
            finally
            {
                DBService.conexao.Close();
            }
        }

        public bool upPedidos(int idEmp, int idPed, string observacao)
        {
            string comandoSql = "update TB_CA_Pedidos_ped set " +
                    "ped_Observacao_chr = '" + observacao + "' " +
                    "where ped_Empresa_int_FK = " + idEmp + " and " +
                    "ped_Pedido_int_PK = " + idPed;

            OleDbCommand commando = new OleDbCommand(comandoSql, DBService.conexao);

            try
            {
                DBService.conexao.Open();

                //Executar o comando e ler os dados retornados
                int succ = commando.ExecuteNonQuery();
                if (succ == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception exc)
            {

                throw new Exception(exc.Message);
            }
            finally
            {
                DBService.conexao.Close();
            }
        }

        public bool inPedidoRestore(int idEmp, PedidosModel pedido)
        {
            string comandoSql = "insert into TB_CA_Pedidos_ped (" + 
                "ped_Pedido_int_PK," +
                "ped_Empresa_int_FK," +
                "ped_idCliente_int_FK," +
                "ped_ValorTotal_mon," +
                "ped_DataVenda_dtm," +
                "ped_Observacao_chr," +
                "ped_Desconto_mon ) values ( " +
                pedido.idPedido + ", " +
                idEmp.ToString() + ", " +
                pedido.cliente.idCliente.ToString() + ", '" +
                pedido.valorTotal + "', '" +
                pedido.dataVenda + "', '" +
                pedido.observacao + "', '" +
                pedido.desconto + "' )";

            OleDbCommand cmd = new OleDbCommand(comandoSql, DBService.conexao);

            try
            {
                //Abertura da conexÃ£o
                DBService.conexao.Open();

                int succ = cmd.ExecuteNonQuery();

                if (succ == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception exc)
            {

                throw new Exception(exc.Message);
            }
            finally
            {
                DBService.conexao.Close();
            }
        }
        public void restoreBackUp(string nomeTabela, JToken tabela)
        {
            DBService dBService = new DBService();
            dBService.truncateTable(nomeTabela, "ped_Pedido_int_PK");
            ParseUtils encodeString = new ParseUtils();
            foreach (var linha in tabela)
            {
                PedidosModel pedidosModel = new PedidosModel();
                pedidosModel.cliente = new ClientesModel();

                for (int i = 0; i < linha.Count(); i++)
                {
                    var itens = linha[i];
                    if (itens.Value<int>("ped_Pedido_int_PK") != 0) { pedidosModel.idPedido = itens.Value<int>("ped_Pedido_int_PK"); }
                    if (itens.Value<int>("ped_Empresa_int_FK") != 0) { pedidosModel.idEmpresa = itens.Value<int>("ped_Empresa_int_FK"); }
                    if (itens.Value<int>("ped_idCliente_int_FK") != 0) { pedidosModel.cliente.idCliente = itens.Value<int>("ped_idCliente_int_FK"); }
                    if (itens.Value<decimal>("ped_ValorTotal_mon") != 0) { pedidosModel.valorTotal = itens.Value<decimal>("ped_ValorTotal_mon"); }
                    if (itens.Value<string>("ped_Observacao_chr") != null) { pedidosModel.observacao = encodeString.encodeString(itens.Value<string>("ped_Observacao_chr")); }
                    if (itens.Value<decimal>("ped_Desconto_mon") != 0) { pedidosModel.desconto = itens.Value<decimal>("ped_Desconto_mon"); }
                    if (itens.Value<string>("ped_DataVenda_dtm") != null)
                    {
                        string iDate = itens.Value<string>("ped_DataVenda_dtm");
                        pedidosModel.dataVenda = Convert.ToDateTime(iDate);
                    }
                }
                inPedidoRestore(pedidosModel.idEmpresa, pedidosModel);
            }
        }
    }
}

