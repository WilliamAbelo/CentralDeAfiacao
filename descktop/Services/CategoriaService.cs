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
            string insertId = "";
            string id = "";
            if (categoria.idCategoria != 0)
            {
                insertId = "ctg_Categoria_int_PK,";
                id = categoria.idCategoria + ",";
            }

            string comandoSql = "insert into TB_CA_Categorias_ctg (" +
                insertId +
                "ctg_Empresa_int_FK," +
                "ctg_Categoria_chr," +
                "ctg_Observacao_chr," +
                "ctg_Unidade_chr," +
                "ctg_DataCriacao_dtm )" +
                "VALUES (" +
                id +
                idEmp.ToString() + ",'" +
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
        public void restoreBackUp(string nomeTabela, JToken tabela)
        {
            DBService dBService = new DBService();
            dBService.truncateTable(nomeTabela, "ctg_Categoria_int_PK");
            ParseUtils encodeString = new ParseUtils();
            foreach (var linha in tabela)
            {
                CategoriasModel categoriasModel = new CategoriasModel();
                for (int i = 0; i < linha.Count(); i++)
                {
                    var itens = linha[i];
                    if (itens.Value<int>("ctg_Categoria_int_PK") != 0) { categoriasModel.idCategoria = itens.Value<int>("ctg_Categoria_int_PK"); }
                    if (itens.Value<int>("ctg_Empresa_int_FK") != 0) { categoriasModel.idEmpresa = itens.Value<int>("ctg_Empresa_int_FK"); }
                    if (itens.Value<string>("ctg_Categoria_chr") != null) { categoriasModel.categoria = encodeString.encodeString(itens.Value<string>("ctg_Categoria_chr")); }
                    if (itens.Value<string>("ctg_Observacao_chr") != null) { categoriasModel.observacao = encodeString.encodeString(itens.Value<string>("ctg_Observacao_chr")); }
                    if (itens.Value<string>("ctg_Unidade_chr") != null) { categoriasModel.unidade = encodeString.encodeString(itens.Value<string>("ctg_Unidade_chr")); }
                    if (itens.Value<string>("ctg_DataCriacao_dtm") != null)
                    {
                        string iDate = itens.Value<string>("ctg_DataCriacao_dtm");
                        categoriasModel.dataCriacao = Convert.ToDateTime(iDate);
                    }
                }
                inCategoria(categoriasModel.idEmpresa, categoriasModel);
            }
        }
    }
}
