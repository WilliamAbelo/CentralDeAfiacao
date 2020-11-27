using descktop.Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace descktop.Services
{
    //OleDbConnection conexao;

    class DBService
    {
        public OleDbConnection conexao = new OleDbConnection();

        string localPath;
        string DBFile;
        public DBService()
        {
            //configuração do caminho ao banco de dados
            //ConfigurationSettings.AppSettings.Get("MySetting")
            localPath = System.Environment.CurrentDirectory;
            DBFile = ConfigurationManager.AppSettings["DBFile"];
            conexao.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + localPath + DBFile;
            //C:\\Desenvolvimento\\Pessoal\\Projeto Central de Afiacao\\descktop\\DB
            //C:\Desenvolvimento\Pessoal\Projeto Central de Afiacao\descktop\DB
        }

        public bool backUp()
        {
            string[] path = DBFile.Split('\\');
            // The relative or full path of the database that you want to copy
            string fileToBackup = localPath + DBFile;

            // The directory the save file dialog opens by default
            // --- Optional ---
            string initialFilePath = localPath + "\\" + path[1] + "\\bck\\" + path[2];          
            

            try
            {
                // sfd.FileName is the full path that the user selected.
                // 3rd parameter (true) specifies overwrite
                File.Copy(fileToBackup, initialFilePath, true);
                return true;
            }
            catch (Exception exc)
            {

                throw new Exception(exc.Message);
            }
        }

        public string[] listTables()
        {
            string tabelas = ConfigurationManager.AppSettings["Tables"];
            //tabelas.Replace("\r", string.Empty).Replace("\n", string.Empty).Replace(" ", string.Empty);


            string[] listaTabelas;
            listaTabelas = tabelas.Split(';');
            
            //string comandoSql = "select MSysObjects.name " +
            //                        "from MSysObjects " +
            //                        "where " +
            //                        "MSysObjects.type In(1,4,6) " +
            //                        "and MSysObjects.name not like '~*' " +
            //                        "and MSysObjects.name not like 'MSys*' " +
            //                        "order by MSysObjects.name ";

            //OleDbCommand commando = new OleDbCommand(comandoSql, conexao);

            //try
            //{
            //    //Abertura da conexão
            //    conexao.Open();
            //    OleDbDataReader dados = commando.ExecuteReader();
            //    int index = 0;
            //    while (dados.Read())
            //    {
            //        var teste = dados[index];
            //        index++;
            //    }
            //}
            //catch (Exception exc)
            //{

            //    throw new Exception(exc.Message);
            //}
            //finally
            //{
            //    conexao.Close();
            //}

            return listaTabelas;
        }

        public void createTable()
        {

        }

        public string[] listColluns(string table)
        {

            return null;
        }

        public void propriedadesDB()
        {
            try
            {
                //Abertura da conexão
                conexao.Open();

                string banco = conexao.DataSource;

                conexao.Dispose();
                MessageBox.Show(banco);
            }
            catch (Exception exc)
            {

                throw new Exception(exc.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        public void resetDB()
        {
            List<string> tabelas = new List<string>
            {
                "TB_CA_Categorias_ctg",
                "TB_CA_Clientes_cli",
                "TB_CA_Condicao_con",
                "TB_CA_Frete_frt",
                "TB_CA_ItensPedido_itp",
                "TB_CA_Pedidos_ped",
                "TB_CA_Produtos_prd"
            };

            foreach (var tabela in tabelas)
            {
                string[] nomeTabela = tabela.Split('_');
                string prefixo = nomeTabela[3];
                string PK = nomeTabela[2];
                string teste = PK.Substring((PK.Length - 1), 1);
                if (PK.Substring((PK.Length - 1), 1) is "s")
                {
                    PK = PK.Substring(0, (PK.Length - 1));
                }
                if (PK is "ItensPedido")
                {
                    PK = "ItemPedido";
                }


                string comandoSql1 = "DELETE FROM " + tabela;
                string comandoSql2 = "ALTER TABLE " + tabela + " ALTER COLUMN " + prefixo + "_" + PK + "_int_PK COUNTER (1, 1);";


                try
                {
                    //Abertura da conexão
                    conexao.Open();

                    OleDbCommand commando1 = new OleDbCommand(comandoSql1, conexao);
                    commando1.ExecuteReader();

                    OleDbCommand commando2 = new OleDbCommand(comandoSql2, conexao);
                    commando2.ExecuteReader();

                }
                catch (Exception exc)
                {

                    throw new Exception(exc.Message);
                }
                finally
                {
                    conexao.Close();
                }
            }
        }

        
        public DBModel executarQuery(string query)
        {

            OleDbCommand commando = new OleDbCommand(query, conexao);
            DBModel retorno = new DBModel();
            Colunas colunas = new Colunas();
            colunas.nome = new List<string>();
            Linhas linhas = new Linhas();
            linhas.linhas = new List<Linha>();
            
            try
            {
                //Abertura da conexão
                conexao.Open();

                //Executar o comando e ler os dados retornados
                OleDbDataReader dados = commando.ExecuteReader();

                bool temRetorno = false;
                int primeiroLaço = 0;
                while (dados.Read())
                {
                    Linha linha = new Linha();
                    linha.item = new List<string>();

                    if (primeiroLaço == 0)
                    {

                        var table = dados.GetSchemaTable();
                        var nameCol = table.Columns["ColumnName"];
                        foreach (DataRow row in table.Rows)
                        {
                            colunas.nome.Add(row[nameCol].ToString());
                            temRetorno = true;

                        }
                        retorno.colunas = colunas;
                    }

                    primeiroLaço++;
                    for (int i = 0; i < dados.FieldCount; i++)
                    {
                        linha.item.Add(dados[i].ToString());
                    }
                    linhas.linhas.Add(linha);
                }
                retorno.linhas = linhas;
                if (!temRetorno)
                {
                    MessageBox.Show("Comando Executado Com Sucesso");
                    return null;
                    //retorno = "Comando Executado Com Sucesso";
                }
                return retorno;
                //return retorno;
                //    if (succ == 0)
                //{
                //    MessageBox.Show("Query Executado com sucesso");
                //} else
                //{
                //    MessageBox.Show("Erro ao Executar Query");
                //}
                ////commando.ExecuteReader();
                //return succ.ToString();

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Erro ao Executar Query");
                //throw new Exception(exc.Message);
                //return exc.Message;
                return null;
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
