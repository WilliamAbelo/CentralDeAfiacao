using descktop.Data;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace descktop.Services
{
    class CategoriaService
    {
        DBService DBService;
        public CategoriaService()
        {
            DBService = new DBService();
        }
        //ctg_Categoria_int_PK ctg_Empresa_int_FK  ctg_Categoria_chr
        public List<CategoriasModel> lsCategorias(int idEmp)
        {
            string comandoSql = "select " +
                "ctg_Categoria_int_PK," +
                "ctg_Empresa_int_FK," +
                "ctg_Categoria_chr," +
                "ctg_Observacao_chr," +
                "ctg_Unidade_chr," +
                "ctg_DataCriacao_dtm," +
                "ctg_Posicao_int " +
                "from TB_CA_Categorias_ctg " +
                "where ctg_Empresa_int_FK = " + idEmp.ToString() +
                " order by ctg_Posicao_int";

            OleDbCommand commando = new OleDbCommand(comandoSql, DBService.conexao);

            try
            {
                //Abertura da conexão
                DBService.conexao.Open();

                //Executar o comando e ler os dados retornados
                OleDbDataReader dados = commando.ExecuteReader();

                List<CategoriasModel> lstCategorias = new List<CategoriasModel>();

                while (dados.Read())
                {
                    if ((int)dados["ctg_Categoria_int_PK"] != -1)
                    {
                        DateTime dateValue;
                        DateTime.TryParse(dados["ctg_DataCriacao_dtm"].ToString(), out dateValue);

                        CategoriasModel categoria = new CategoriasModel();
                        categoria.idCategoria = (int)dados["ctg_Categoria_int_PK"];
                        categoria.idEmpresa = (int)dados["ctg_Empresa_int_FK"];
                        categoria.categoria = (string)dados["ctg_Categoria_chr"];
                        categoria.unidade = dados["ctg_Unidade_chr"].ToString();
                        categoria.observacao = dados["ctg_Observacao_chr"].ToString();
                        categoria.dataCriacao = dateValue;

                        lstCategorias.Add(categoria);
                    }
                    else
                    {
                        return null;
                    }
                }
                return lstCategorias;
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

        public CategoriasModel seCategorias(int idEmp, int idCat)
        {
            string comandoSql = "select " +
                "ctg_Categoria_int_PK," +
                "ctg_Empresa_int_FK," +
                "ctg_Categoria_chr," +
                "ctg_Observacao_chr," +
                "ctg_Unidade_chr," +
                "ctg_DataCriacao_dtm " +
                "from TB_CA_Categorias_ctg " +
                "where ctg_Empresa_int_FK = " + idEmp.ToString() + " and " +
                "ctg_Categoria_int_PK = " + idCat;

            OleDbCommand commando = new OleDbCommand(comandoSql, DBService.conexao);

            try
            {
                //Abertura da conexão
                DBService.conexao.Open();

                //Executar o comando e ler os dados retornados
                OleDbDataReader dados = commando.ExecuteReader();

                while (dados.Read())
                {
                    if ((int)dados["ctg_Categoria_int_PK"] != -1)
                    {
                        DateTime dateValue;
                        DateTime.TryParse(dados["ctg_DataCriacao_dtm"].ToString(), out dateValue);

                        CategoriasModel categoria = new CategoriasModel();
                        categoria.idCategoria = (int)dados["ctg_Categoria_int_PK"];
                        categoria.idEmpresa = (int)dados["ctg_Empresa_int_FK"];
                        categoria.categoria = (string)dados["ctg_Categoria_chr"];
                        categoria.unidade = dados["ctg_Unidade_chr"].ToString();
                        categoria.observacao = dados["ctg_Observacao_chr"].ToString();
                        categoria.dataCriacao = dateValue;

                        return categoria;
                    }
                    else
                    {
                        return null;
                    }
                }
                return null;
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

            public void inCategoria(int idEmp, CategoriasModel categoria)
        {
            string comandoSql = "insert into TB_CA_Categorias_ctg (" +
                "ctg_Empresa_int_FK," +
                "ctg_Categoria_chr," +
                "ctg_Observacao_chr," +
                "ctg_Unidade_chr," +
                "ctg_DataCriacao_dtm )" +
                "VALUES (" + idEmp.ToString() + ",'" +
                            categoria.categoria + "','" +
                            categoria.observacao + "','" +
                            categoria.unidade + "','" +
                            categoria.dataCriacao.ToString() + "')";

            OleDbCommand commando = new OleDbCommand(comandoSql, DBService.conexao);

            try
            {
                //Abertura da conexão
                DBService.conexao.Open();

                //Executar o comando e ler os dados retornados
                commando.ExecuteNonQuery();

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
