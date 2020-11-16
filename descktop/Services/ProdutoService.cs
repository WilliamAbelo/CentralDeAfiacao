using descktop.Data;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace descktop.Services
{
    class ProdutoService
    {
        DBService DBService;

        public ProdutoService()
        {
            DBService = new DBService();
        }

        public List<ProdutosModel> lsProdutos(int idEmp, List<int> idCat)
        {
            string idCats = "";
            foreach (var item in idCat)
            {
                idCats += item.ToString() + ", ";
            }
            string comandoSql = "select " +
                "prd_Produto_int_PK," +
                "prd_Empresa_int_FK," +
                "prd_Produto_chr," +
                "prd_Categoria_int_FK," +
                "prd_ValorUnitario_mon," +
                "prd_Ativo_int," +
                "prd_Observacao_chr," +
                "prd_DataCriacao_dtm," +
                "prd_DataSync_dtm " +
                "from TB_CA_Produtos_prd " +
                "where prd_Empresa_int_FK = " + idEmp.ToString() + " and " +
                "prd_Ativo_int = 1 and prd_Categoria_int_FK in (" + idCats + ")";

            OleDbCommand commando = new OleDbCommand(comandoSql, DBService.conexao);

            try
            {
                //Abertura da conexão
                DBService.conexao.Open();

                //Executar o comando e ler os dados retornados
                OleDbDataReader dados = commando.ExecuteReader();

                List<ProdutosModel> lstProdutos = new List<ProdutosModel>();

                while (dados.Read())
                {
                    if ((int)dados["prd_Produto_int_PK"] != -1)
                    {
                        DateTime dataCriacao;
                        DateTime.TryParse(dados["prd_DataCriacao_dtm"].ToString(), out dataCriacao);

                        DateTime dataSync;
                        DateTime.TryParse(dados["prd_DataSync_dtm"].ToString(), out dataSync);
                        ProdutosModel produto = new ProdutosModel();
                        produto.idProduto = (int)dados["prd_Produto_int_PK"];
                        produto.idEmpresa = (int)dados["prd_Empresa_int_FK"];
                        produto.produto = (string)dados["prd_Produto_chr"];
                        produto.idCategoria = (int)dados["prd_Categoria_int_FK"];
                        produto.valor = (decimal)dados["prd_ValorUnitario_mon"];
                        produto.ativo = (int)dados["prd_Ativo_int"];
                        produto.observacao = dados["prd_Observacao_chr"].ToString();
                        produto.dataCriacao = dataCriacao;
                        produto.dataSync = dataSync;

                        lstProdutos.Add(produto);
                    }
                    else
                    {
                        return null;
                    }
                }
                return lstProdutos;
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

        public ProdutosModel seProdutos(int idEmp, int idProd)
        {
            string comandoSql = "select " +
                "prd_Produto_int_PK," +
                "prd_Empresa_int_FK," +
                "prd_Produto_chr," +
                "prd_Categoria_int_FK," +
                "prd_ValorUnitario_mon," +
                "prd_Ativo_int," +
                "prd_Observacao_chr," +
                "prd_DataCriacao_dtm," +
                "prd_DataSync_dtm " +
                "from TB_CA_Produtos_prd " +
                "where prd_Empresa_int_FK = " + idEmp.ToString() + " and " +
                "prd_Produto_int_PK = " + idProd.ToString() + " and " +
                "prd_Ativo_int = 1";

            OleDbCommand commando = new OleDbCommand(comandoSql, DBService.conexao);

            try
            {
                //Abertura da conexão
                DBService.conexao.Open();

                //Executar o comando e ler os dados retornados
                OleDbDataReader dados = commando.ExecuteReader();
                ProdutosModel produto = new ProdutosModel();

                while (dados.Read())
                {
                    if ((int)dados["prd_Produto_int_PK"] != -1)
                    {
                        DateTime dataCriacao;
                        DateTime.TryParse(dados["prd_DataCriacao_dtm"].ToString(), out dataCriacao);

                        DateTime dataSync;
                        DateTime.TryParse(dados["prd_DataSync_dtm"].ToString(), out dataSync);

                        produto.idProduto = (int)dados["prd_Produto_int_PK"];
                        produto.idEmpresa = (int)dados["prd_Empresa_int_FK"];
                        produto.produto = (string)dados["prd_Produto_chr"];
                        produto.idCategoria = (int)dados["prd_Categoria_int_FK"];
                        produto.valor = (decimal)dados["prd_ValorUnitario_mon"];
                        produto.ativo = (int)dados["prd_Ativo_int"];
                        produto.observacao = dados["prd_Observacao_chr"].ToString();
                        produto.dataCriacao = dataCriacao;
                        produto.dataSync = dataSync;
                    }
                    else
                    {
                        return null;
                    }
                }
                return produto;
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

        public Boolean inProduto(int idEmp, ProdutosModel produto)
        {
            string comandoSql = "insert into TB_CA_Produtos_prd (" +               
                "prd_Empresa_int_FK," +
                "prd_Produto_chr," +
                "prd_Categoria_int_FK," +
                "prd_ValorUnitario_mon," +
                "prd_Ativo_int," +
                "prd_Observacao_chr," +
                "prd_DataCriacao_dtm," +
                "prd_DataSync_dtm) " +
                "VALUES (" + idEmp.ToString() + ",'" +
                            produto.produto + "'," + 
                            produto.idCategoria.ToString() + ",'" +
                            produto.valor.ToString() + "'," +
                            produto.ativo.ToString() + ",'" +
                            produto.observacao + "','" +
                            produto.dataCriacao.ToString() + "','" +
                            produto.dataSync.ToString() + "')";

            OleDbCommand commando = new OleDbCommand(comandoSql, DBService.conexao);

            try
            {
                //Abertura da conexão
                DBService.conexao.Open();

                //Executar o comando e ler os dados retornados
                int succ = commando.ExecuteNonQuery();
                if(succ == 0)
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

        public Boolean upProduto(int idEmp, int idProd, ProdutosModel produto)
        {
            string comandoSql = "update TB_CA_Produtos_prd set " +
                "prd_Produto_chr = '" + produto.produto + "', " +
                "prd_Categoria_int_FK = " + produto.idCategoria.ToString() + ", " +
                "prd_ValorUnitario_mon = '" + produto.valor.ToString() + "', " +
                "prd_Observacao_chr = '" + produto.observacao + "', " +
                "prd_DataSync_dtm = '" + produto.dataSync.ToString() + "' " +
                "WHERE prd_Empresa_int_FK = " + idEmp.ToString() + " AND" +
                        " prd_Produto_int_PK = " + idProd.ToString();

            OleDbCommand commando = new OleDbCommand(comandoSql, DBService.conexao);

            try
            {
                //Abertura da conexão
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

        public bool deProduto(int idEmp, int idProd)
        {
            string comandoSql = "update TB_CA_Produtos_prd " +
                "set prd_Ativo_int = 0 " +
                "WHERE prd_Empresa_int_FK = " + idEmp + " AND" +
                        " prd_Produto_int_PK = " + idProd;

            OleDbCommand commando = new OleDbCommand(comandoSql, DBService.conexao);

            try
            {
                //Abertura da conexão
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
    }
}
