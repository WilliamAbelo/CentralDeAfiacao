using descktop.Data;
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
    class CondicaoService
    {
        DBService DBService;
        public CondicaoService()
        {
            DBService = new DBService();
        }

        public List<int> lsCondicaoPedido(int idEmp, int finalizado)
        {
            string comandoSql = "select " +
                             "con_Pedido_int_FK " +
                             "from TB_CA_Condicao_con " +
                             "where con_Empresa_int_FK = " + idEmp.ToString() + " and " +
                             "con_Pago_int = " + finalizado.ToString() +
                             " group by con_Pedido_int_FK";

            OleDbCommand commando = new OleDbCommand(comandoSql, DBService.conexao);

            try
            {
                //Abertura da conexão
                DBService.conexao.Open();

                //Executar o comando e ler os dados retornados
                OleDbDataReader dados = commando.ExecuteReader();
                List<int> idsPedidos = new List<int>();

                while (dados.Read())
                {
                    if ((int)dados["con_Pedido_int_FK"] != -1)
                    {
                        idsPedidos.Add((int)dados["con_Pedido_int_FK"]);
                    }
                    else
                    {
                        return null;
                    }
                }
                return idsPedidos;
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

        public CondicoesModel seCondicaoPedido(int idEmp, int idPed)
        {
            string comandoSql = "select " +
                             "con_Condicao_int_PK, " +
                             "con_Empresa_int_FK, " +
                             "con_Pedido_int_FK, " +
                             "con_Parcela_chr, " +
                             "con_ValorParcela_mon, " +
                             "con_FormaPagamento_chr, " +
                             "con_DataParcela_dtm, " +
                             "con_Pago_int," +
                             "con_DataPagamento_dtm " +
                             "from TB_CA_Condicao_con " +
                             "where con_Empresa_int_FK = " + idEmp.ToString() + " and " +
                             "con_Pedido_int_FK = " + idPed.ToString();

            OleDbCommand commando = new OleDbCommand(comandoSql, DBService.conexao);

            try
            {
                //Abertura da conexão
                DBService.conexao.Open();

                //Executar o comando e ler os dados retornados
                OleDbDataReader dados = commando.ExecuteReader();
                CondicoesModel condicoes = new CondicoesModel();
                condicoes.parcelas = new List<CondicaoParcelas>();

                while (dados.Read())
                {
                    if ((int)dados["con_Condicao_int_PK"] != -1)
                    {
                        CondicaoParcelas parcela = new CondicaoParcelas();

                        DateTime dataParcela;
                        DateTime.TryParse(dados["con_DataParcela_dtm"].ToString(), out dataParcela);

                        DateTime dataPagamento;
                        DateTime.TryParse(dados["con_DataPagamento_dtm"].ToString(), out dataPagamento);

                        condicoes.idEmpresa = idEmp;
                        condicoes.idPedido = (int)dados["con_Pedido_int_FK"];
                        parcela.idParcela = (int)dados["con_Condicao_int_PK"];
                        parcela.numeroParcela = (string)dados["con_Parcela_chr"];
                        parcela.valorParcela = (decimal)dados["con_ValorParcela_mon"];
                        parcela.formaPagamento = (string)dados["con_FormaPagamento_chr"];
                        parcela.dataParcela = dataParcela;
                        parcela.pago = (int)dados["con_Pago_int"];
                        parcela.dataPagamento = dataPagamento;

                        condicoes.parcelas.Add(parcela);
                    }
                    else
                    {
                        return null;
                    }
                }
                return condicoes;
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

        public bool inCondicaoPedido(int idEmp, int idPed, CondicoesModel condicoes)
        {
            string insertId = "";
            string id = "";
            //Abertura da conexão
            DBService.conexao.Open();
            foreach (CondicaoParcelas item in condicoes.parcelas)
            {
                if (item.idParcela != 0)
                {
                    insertId = "con_Condicao_int_PK,";
                    id = item.idParcela + ",";
                }

                string comandoSql = "insert into TB_CA_Condicao_con (" +
                     insertId +
                        "con_Empresa_int_FK, " +
                        "con_Pedido_int_FK, " +
                        "con_Parcela_chr, " +
                        "con_ValorParcela_mon, " +
                        "con_FormaPagamento_chr, " +
                        "con_DataParcela_dtm," +
                        "con_Pago_int," +
                        "con_DataPagamento_dtm ) " +
                        "VALUES (" +
                            id +
                            idEmp.ToString() + ",'" +
                            idPed.ToString() + "','" +
                            item.numeroParcela + "','" +
                            item.valorParcela.ToString() + "','" +
                            item.formaPagamento + "','" +
                            item.dataParcela + "'," +
                            item.pago + ",'" +
                            item.dataPagamento + "');";

                OleDbCommand cmd = new OleDbCommand(comandoSql, DBService.conexao);
                try
                {
                    //A conexão ja esta aberta                    
                    //Executar o comando e ler os dados retornados
                    int succ = cmd.ExecuteNonQuery();
                    if (succ == 0)
                    {
                        return false;
                    }

                }
                catch (Exception exc)
                {

                    throw new Exception(exc.Message);
                }
                finally
                {
                    
                }
            }
            return true;
        }

        public bool upCondicaoPedido(int idEmp, int idPed, CondicaoParcelas parcela)
        {

            string comandoSql = "update TB_CA_Condicao_con set " +
                    "con_Pago_int = '" + parcela.pago + "', " +
                    "con_DataPagamento_dtm = '" + parcela.dataPagamento + "', " +
                    "con_DataParcela_dtm = '" + parcela.dataParcela + "' " +
                    "where con_Empresa_int_FK = " + idEmp + " and " +
                    "con_Pedido_int_FK = " + idPed + " and " +
                    "con_Condicao_int_PK = " + parcela.idParcela;


            OleDbCommand cmd = new OleDbCommand(comandoSql, DBService.conexao);
            try
            {
                //Abertura da conexão
                DBService.conexao.Open();

                //Executar o comando e ler os dados retornados
                int succ = cmd.ExecuteNonQuery();
                if (succ == 0)
                {
                    return false;
                }

            }
            catch (Exception exc)
            {

                throw new Exception(exc.Message);
            }
            finally
            {
            }
            return true;
        }
        public bool deCondicaoPedido(int idEmp, int idPed)
        {
            //TB_CA_ItensPedido_itp
            //itp_ItemPedido_int_PK itp_Empresa_int_FK itp_Pedido_int_FK   itp_Produto_int_FK itp_Quantidade_int itp_ValorUnitario_mon itp_ValorDesconto_mon itp_ValorTotal_mon 

            string comandoSql = "delete from TB_CA_Condicao_con " +
                                 "where con_Empresa_int_FK = " + idEmp + " and " +
                                        "con_Pedido_int_FK = " + idPed;

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

        public void restoreBackUp(string nomeTabela, JToken tabela)
        {
            DBService dBService = new DBService();
            dBService.truncateTable(nomeTabela, "con_Condicao_int_PK");
            ParseUtils encodeString = new ParseUtils();
            foreach (var linha in tabela)
            {
                CondicoesModel condicoesModel = new CondicoesModel();
                condicoesModel.parcelas = new List<CondicaoParcelas>();
                CondicaoParcelas parcelas = new CondicaoParcelas();
                for (int i = 0; i < linha.Count(); i++)
                {
                    var itens = linha[i];
                    if (itens.Value<int>("con_Empresa_int_FK") != 0) { condicoesModel.idEmpresa = itens.Value<int>("con_Empresa_int_FK"); }
                    if (itens.Value<int>("con_Pedido_int_FK") != 0) { condicoesModel.idPedido = itens.Value<int>("con_Pedido_int_FK"); }
                    if (itens.Value<int>("con_Condicao_int_PK") != 0) { parcelas.idParcela = itens.Value<int>("con_Condicao_int_PK"); }
                    if (itens.Value<string>("con_Parcela_chr") != null) { parcelas.numeroParcela = encodeString.encodeString(itens.Value<string>("con_Parcela_chr")); }
                    if (itens.Value<decimal>("con_ValorParcela_mon") != 0) { parcelas.valorParcela = itens.Value<decimal>("con_ValorParcela_mon"); }
                    if (itens.Value<string>("con_FormaPagamento_chr") != null) { parcelas.formaPagamento = encodeString.encodeString(itens.Value<string>("con_FormaPagamento_chr")); }
                    if (itens.Value<int>("con_Pago_int") != 0) { parcelas.pago = itens.Value<int>("con_Pago_int"); }
                    if (itens.Value<string>("con_DataParcela_dtm") != null)
                    {
                        string iDate = itens.Value<string>("con_DataParcela_dtm");
                        parcelas.dataParcela = Convert.ToDateTime(iDate);
                    }
                    if (itens.Value<string>("con_DataPagamento_dtm") != null)
                    {
                        string iDate = itens.Value<string>("con_DataPagamento_dtm");
                        parcelas.dataPagamento = Convert.ToDateTime(iDate);
                    }
                }
                condicoesModel.parcelas.Add(parcelas);
                inCondicaoPedido(condicoesModel.idEmpresa, condicoesModel.idPedido, condicoesModel);
                DBService.conexao.Close();
            }
        }
    }
}
