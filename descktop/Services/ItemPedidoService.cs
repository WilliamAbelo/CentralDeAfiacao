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
    class ItemPedidoService
    {
        DBService DBService;
        public ItemPedidoService()
        {
            DBService = new DBService();
        }


        public ProdutosCarrinho seItensPedido(int idEmp, int idPed)
        {
            //TB_CA_ItensPedido_itp
            //itp_ItemPedido_int_PK itp_Empresa_int_FK itp_Pedido_int_FK   itp_Produto_int_FK itp_Quantidade_int itp_ValorUnitario_mon itp_ValorDesconto_mon itp_ValorTotal_mon 

            string comandoSql = "select " +
                                    "itp_ItemPedido_int_PK," +
                                    "itp_Empresa_int_FK," +
                                    "itp_Pedido_int_FK," +
                                    "itp_Produto_int_FK," +
                                    "itp_Quantidade_int," +
                                    "itp_ValorUnitario_mon," +
                                    "itp_ValorDesconto_mon," +
                                    "itp_ValorTotal_mon " +
                                    "from TB_CA_ItensPedido_itp " +
                                 "where itp_Empresa_int_FK = " + idEmp.ToString() + " and " +
                                        "itp_Pedido_int_FK = " + idPed.ToString();

            OleDbCommand commando = new OleDbCommand(comandoSql, DBService.conexao);

            try
            {
                //Abertura da conexão
                DBService.conexao.Open();

                //Executar o comando e ler os dados retornados
                OleDbDataReader dados = commando.ExecuteReader();
                ProdutosCarrinho itensPedido = new ProdutosCarrinho();
                ProdutoService produtoService = new ProdutoService();
                itensPedido.produtos = new List<ProdutosCesta>();

                while (dados.Read())
                {
                    if ((int)dados["itp_ItemPedido_int_PK"] != -1)
                    {
                        ProdutosCesta produtos = new ProdutosCesta();
                        int idProduto = (int)dados["itp_Produto_int_FK"];
                        produtos.produto = produtoService.seProdutos(idEmp, idProduto);

                        //produtos.produto.idProduto = (int)dados["itp_Produto_int_FK"];
                        //produtos.produto.valor = (decimal)dados["itp_ValorUnitario_mon"];

                        produtos.idItemPedido = (int)dados["itp_ItemPedido_int_PK"];
                        itensPedido.idEmpresa = (int)dados["itp_Empresa_int_FK"];
                        itensPedido.idPedido = (int)dados["itp_Pedido_int_FK"];
                        produtos.quantidade = decimal.Parse(dados["itp_Quantidade_int"].ToString());
                        produtos.desconto = (decimal)dados["itp_ValorDesconto_mon"];
                        produtos.valorTotal = (decimal)dados["itp_ValorTotal_mon"];

                        itensPedido.produtos.Add(produtos);
                    }
                    else
                    {
                        return null;
                    }
                }
                return itensPedido;
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

        public bool inItensPedido(int idEmp, int idPed, ProdutosCarrinho produtos)
        {
            string insertId = "";
            string id = "";
            //Abertura da conexão
            DBService.conexao.Open();
            foreach (ProdutosCesta item in produtos.produtos)
            {
                if (item.idItemPedido != 0)
                {
                    insertId = "itp_ItemPedido_int_PK,";
                    id = item.idItemPedido + ",";
                }

                string comandoSql = "insert into TB_CA_ItensPedido_itp (" +
                        insertId +
                        "itp_Empresa_int_FK, " +
                        "itp_Pedido_int_FK, " +
                        "itp_Produto_int_FK, " +
                        "itp_Quantidade_int, " +
                        "itp_ValorUnitario_mon, " +
                        "itp_ValorTotal_mon, " +
                        "itp_ValorDesconto_mon ) " +
                        "VALUES (" +
                            id + 
                            idEmp.ToString() + ",'" +
                            idPed.ToString() + "','" +
                            item.produto.idProduto.ToString() + "','" +
                            item.quantidade.ToString() + "','" +
                            item.produto.valor.ToString() + "','" +
                            item.valorTotal.ToString() + "','" +
                            item.desconto.ToString() + "');";

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

        public bool deItensPedido(int idEmp, int idPed)
        {
            //TB_CA_ItensPedido_itp
            //itp_ItemPedido_int_PK itp_Empresa_int_FK itp_Pedido_int_FK   itp_Produto_int_FK itp_Quantidade_int itp_ValorUnitario_mon itp_ValorDesconto_mon itp_ValorTotal_mon 

            string comandoSql = "delete from TB_CA_ItensPedido_itp " +
                                 "where itp_Empresa_int_FK = " + idEmp + " and " +
                                        "itp_Pedido_int_FK = " + idPed;

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
            dBService.truncateTable(nomeTabela, "itp_ItemPedido_int_PK");
            ParseUtils encodeString = new ParseUtils();
            foreach (var linha in tabela)
            {
                ProdutosCarrinho produtos = new ProdutosCarrinho();
                produtos.produtos = new List<ProdutosCesta>();
                ProdutosCesta produtosCesta = new ProdutosCesta();
                produtosCesta.produto = new ProdutosModel();
                for (int i = 0; i < linha.Count(); i++)
                {
                    var itens = linha[i];
                    if (itens.Value<int>("itp_ItemPedido_int_PK") != 0) { produtosCesta.idItemPedido = itens.Value<int>("itp_ItemPedido_int_PK"); }
                    if (itens.Value<int>("itp_Empresa_int_FK") != 0) { produtos.idEmpresa = itens.Value<int>("itp_Empresa_int_FK"); }
                    if (itens.Value<int>("itp_Pedido_int_FK") != 0) { produtos.idPedido = itens.Value<int>("itp_Pedido_int_FK"); }
                    if (itens.Value<int>("itp_Produto_int_FK") != 0) { produtosCesta.produto.idProduto = itens.Value<int>("itp_Produto_int_FK"); }
                    if (itens.Value<decimal>("itp_Quantidade_int") != 0) { produtosCesta.quantidade = itens.Value<decimal>("itp_Quantidade_int"); }
                    if (itens.Value<decimal>("itp_ValorUnitario_mon") != 0) { produtosCesta.produto.valor = itens.Value<decimal>("itp_ValorUnitario_mon"); }
                    if (itens.Value<decimal>("itp_ValorTotal_mon") != 0) { produtosCesta.valorTotal = itens.Value<decimal>("itp_ValorTotal_mon"); }
                    if (itens.Value<decimal>("itp_ValorDesconto_mon") != 0) { produtosCesta.desconto = itens.Value<decimal>("itp_ValorDesconto_mon"); }

                }
                produtos.produtos.Add(produtosCesta);
                inItensPedido(produtos.idEmpresa, produtos.idPedido, produtos);
                DBService.conexao.Close();
            }
        }
    }
}
