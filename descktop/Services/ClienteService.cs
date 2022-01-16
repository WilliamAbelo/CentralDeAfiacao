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
    class ClienteService
    {
        DBService DBService;
        public ClienteService()
        {
            DBService = new DBService();
        }

        public List<ClientesModel> lsClientes(int idEmp, string estado = "")
        {
            string buscaComEstado = "";
            if (estado != "")
            {
                buscaComEstado = " and cli_Estado_chr" + estado;
            }

            //cli_Cliente_int_PK cli_Empresa_int_FK  cli_Nome_chr cli_Responsavel_chr cli_Endereco_chr cli_Numero_chr  cli_Complemento_chr cli_Bairro_chr  cli_Cidade_chr cli_Estado_chr  cli_Telefone_chr cli_Celular1_chr    cli_Celular2_chr cli_Email_chr   cli_Ativo_int cli_Observacao_chr
            string comandoSql = "select " +
                "cli_Cliente_int_PK," +
                "cli_Empresa_int_FK," +
                "cli_Nome_chr," +
                "cli_Responsavel_chr," +
                "cli_Endereco_chr," +
                "cli_Numero_chr," +
                "cli_Complemento_chr," +
                "cli_Bairro_chr," +
                "cli_Cidade_chr," +
                "cli_Estado_chr," +
                "cli_CEP_chr," +
                "cli_Telefone_chr," +
                "cli_Celular1_chr," +
                "cli_CpfCnpj_chr," +
                "cli_Email_chr," +
                "cli_Observacao_chr," +
                "cli_DataCriacao_dtm," +
                "cli_DataSync_dtm," +
                "cli_Ativo_int " +
                "from TB_CA_Clientes_cli " +
                "where cli_Empresa_int_FK = " + idEmp.ToString() + " and " +
                "cli_Ativo_int = 1 " + buscaComEstado +
                "order by cli_Nome_chr";


            OleDbCommand commando = new OleDbCommand(comandoSql, DBService.conexao);

            try
            {
                //Abertura da conexão
                DBService.conexao.Open();

                //Executar o comando e ler os dados retornados
                OleDbDataReader dados = commando.ExecuteReader();

                List<ClientesModel> lstClientes = new List<ClientesModel>();

                while (dados.Read())
                {
                    if ((int)dados["cli_Cliente_int_PK"] != -1)
                    {
                        DateTime dataCriacao;
                        DateTime.TryParse(dados["cli_DataCriacao_dtm"].ToString(), out dataCriacao);

                        DateTime dataSync;
                        DateTime.TryParse(dados["cli_DataSync_dtm"].ToString(), out dataSync);

                        ClientesModel cliente = new ClientesModel();
                        cliente.idCliente = (int)dados["cli_Cliente_int_PK"];
                        cliente.idEmpresa = (int)dados["cli_Empresa_int_FK"];
                        cliente.nome = dados["cli_Nome_chr"].ToString();
                        cliente.responsavel = dados["cli_Responsavel_chr"].ToString();
                        cliente.endereco = dados["cli_Endereco_chr"].ToString();
                        cliente.numero = dados["cli_Numero_chr"].ToString();
                        cliente.complemento = dados["cli_Complemento_chr"].ToString();
                        cliente.bairro = dados["cli_Bairro_chr"].ToString();
                        cliente.cidade = dados["cli_Cidade_chr"].ToString();
                        cliente.estado = dados["cli_Estado_chr"].ToString();
                        cliente.CEP = dados["cli_CEP_chr"].ToString();
                        cliente.telefone = dados["cli_Telefone_chr"].ToString();
                        cliente.celular1 = dados["cli_Celular1_chr"].ToString();
                        cliente.cpfCnpj = dados["cli_CpfCnpj_chr"].ToString();
                        cliente.email = dados["cli_Email_chr"].ToString();
                        cliente.observacao = dados["cli_Observacao_chr"].ToString();
                        cliente.dataCriacao = dataCriacao;
                        cliente.dataSync = dataSync;
                        cliente.ativo = (int)dados["cli_Ativo_int"];

                        lstClientes.Add(cliente);
                    }
                    else
                    {
                        return null;
                    }
                }
                return lstClientes;
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

        public ClientesModel seCliente(int idEmp, int idCli)
        {
            string comandoSql = "select " +
                "cli_Cliente_int_PK," +
                "cli_Empresa_int_FK," +
                "cli_Nome_chr," +
                "cli_Responsavel_chr," +
                "cli_Endereco_chr," +
                "cli_Numero_chr," +
                "cli_Complemento_chr," +
                "cli_Bairro_chr," +
                "cli_Cidade_chr," +
                "cli_Estado_chr," +
                "cli_CEP_chr," +
                "cli_Telefone_chr," +
                "cli_Celular1_chr," +
                "cli_CpfCnpj_chr," +
                "cli_Email_chr," +
                "cli_Observacao_chr," +
                "cli_DataCriacao_dtm," +
                "cli_DataSync_dtm," +
                "cli_Ativo_int " +
                "from TB_CA_Clientes_cli " +
                "where cli_Cliente_int_PK = " + idCli.ToString() + " and " +
                "cli_Empresa_int_FK = " + idEmp.ToString() + " and " +
                "cli_Ativo_int = 1 ";

            OleDbCommand commando = new OleDbCommand(comandoSql, DBService.conexao);

            try
            {
                //Abertura da conexão
                DBService.conexao.Open();

                //Executar o comando e ler os dados retornados
                OleDbDataReader dados = commando.ExecuteReader();
                ClientesModel cliente = new ClientesModel();

                while (dados.Read())
                {
                    if ((int)dados["cli_Cliente_int_PK"] != -1)
                    {
                        DateTime dataCriacao;
                        DateTime.TryParse(dados["cli_DataCriacao_dtm"].ToString(), out dataCriacao);

                        DateTime dataSync;
                        DateTime.TryParse(dados["cli_DataSync_dtm"].ToString(), out dataSync);

                        cliente.idCliente = (int)dados["cli_Cliente_int_PK"];
                        cliente.idEmpresa = (int)dados["cli_Empresa_int_FK"];
                        cliente.nome = dados["cli_Nome_chr"].ToString();
                        cliente.responsavel = dados["cli_Responsavel_chr"].ToString();
                        cliente.endereco = dados["cli_Endereco_chr"].ToString();
                        cliente.numero = dados["cli_Numero_chr"].ToString();
                        cliente.complemento = dados["cli_Complemento_chr"].ToString();
                        cliente.bairro = dados["cli_Bairro_chr"].ToString();
                        cliente.cidade = dados["cli_Cidade_chr"].ToString();
                        cliente.estado = dados["cli_Estado_chr"].ToString();
                        cliente.CEP = dados["cli_CEP_chr"].ToString();
                        cliente.telefone = dados["cli_Telefone_chr"].ToString();
                        cliente.celular1 = dados["cli_Celular1_chr"].ToString();
                        cliente.cpfCnpj = dados["cli_CpfCnpj_chr"].ToString();
                        cliente.email = dados["cli_Email_chr"].ToString();
                        cliente.observacao = dados["cli_Observacao_chr"].ToString();
                        cliente.dataCriacao = dataCriacao;
                        cliente.dataSync = dataSync;
                        cliente.ativo = (int)dados["cli_Ativo_int"];
                    }
                    else
                    {
                        return null;
                    }
                }
                return cliente;
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

        public bool inCliente(int idEmp, ClientesModel cliente)
        {
            string insertId = "";
            string id = "";
            if(cliente.idCliente != 0)
            {
                insertId = "cli_Cliente_int_PK,";
                id = cliente.idCliente + ",";
            }
            string comandoSql = "insert into TB_CA_Clientes_cli (" +
                insertId +
                "cli_Empresa_int_FK," +
                "cli_Nome_chr," +
                "cli_Responsavel_chr," +
                "cli_Endereco_chr," +
                "cli_Numero_chr," +
                "cli_Complemento_chr," +
                "cli_Bairro_chr," +
                "cli_Cidade_chr," +
                "cli_Estado_chr," +
                "cli_CEP_chr," +
                "cli_Telefone_chr," +
                "cli_Celular1_chr," +
                "cli_CpfCnpj_chr," +
                "cli_Email_chr," +
                "cli_Observacao_chr," +
                "cli_DataCriacao_dtm," +
                "cli_DataSync_dtm," +
                "cli_Ativo_int ) " +
                "VALUES (" +
                id +
                idEmp.ToString() + ",'" +
                cliente.nome + "','" +
                cliente.responsavel + "','" +
                cliente.endereco + "','" +
                cliente.numero + "','" +
                cliente.complemento + "','" +
                cliente.bairro + "','" +
                cliente.cidade + "','" +
                cliente.estado + "','" +
                cliente.CEP + "','" +
                cliente.telefone + "','" +
                cliente.celular1 + "','" +
                cliente.cpfCnpj + "','" +
                cliente.email + "','" +
                cliente.observacao + "','" +
                cliente.dataCriacao + "','" +
                cliente.dataSync + "'," +
                cliente.ativo + ")";

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

        public bool upCliente(int idEmp, int idCli, ClientesModel cliente)
        {
            string comandoSql = "update TB_CA_Clientes_cli " +
                "set " +
                "cli_Nome_chr = '" + cliente.nome + "'," +
                "cli_Responsavel_chr = '" + cliente.responsavel + "'," +
                "cli_Endereco_chr = '" + cliente.endereco + "'," +
                "cli_Numero_chr = '" + cliente.numero + "'," +
                "cli_Complemento_chr = '" + cliente.complemento + "'," +
                "cli_Bairro_chr = '" + cliente.bairro + "'," +
                "cli_Cidade_chr = '" + cliente.cidade + "'," +
                "cli_Estado_chr = '" + cliente.estado + "'," +
                "cli_CEP_chr = '" + cliente.CEP + "'," +
                "cli_Telefone_chr = '" + cliente.telefone + "'," +
                "cli_Celular1_chr = '" + cliente.celular1 + "'," +
                 "cli_CpfCnpj_chr = '" + cliente.cpfCnpj + "'," +
                "cli_Email_chr = '" + cliente.email + "'," +
                "cli_Observacao_chr = '" + cliente.observacao + "'," +
                "cli_DataSync_dtm = '" + cliente.dataSync + "' " +
                "where cli_Empresa_int_FK = " + idEmp + " and " +
                "cli_Cliente_int_PK = " + idCli;


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

        public bool deCliente(int idEmp, int idCli)
        {
            string comandoSql = "update TB_CA_Clientes_cli " +
                "set cli_Ativo_int = 0 " +
                "where cli_Empresa_int_FK = " + idEmp + " and " +
                "cli_Cliente_int_PK = " + idCli;


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

        public List<int> seIdClientes(int idEmp, string nome)
        {
            string comandoSql = "select " +
                "cli_Cliente_int_PK " +
                "from TB_CA_Clientes_cli " +
                "where cli_Empresa_int_FK = " + idEmp.ToString() + " and " +
                "cli_Ativo_int = 1 and " +
                "cli_Nome_chr like '%" + nome + "%'";

            //“*" + nome + "*“";
            //'%" + nome + "%'";

            OleDbCommand commando = new OleDbCommand(comandoSql, DBService.conexao);

            try
            {
                //Abertura da conexão
                DBService.conexao.Open();

                //Executar o comando e ler os dados retornados
                OleDbDataReader dados = commando.ExecuteReader();
                List<int> lsIds = new List<int>();

                while (dados.Read())
                {
                    if ((int)dados["cli_Cliente_int_PK"] != -1)
                    {

                        lsIds.Add((int)dados["cli_Cliente_int_PK"]);

                    }
                    else
                    {
                        return null;
                    }
                }
                return lsIds;
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
            dBService.truncateTable(nomeTabela, "cli_Cliente_int_PK");
            ParseUtils encodeString = new ParseUtils();
            foreach (var linha in tabela)
            {
                ClientesModel cliente = new ClientesModel();
                for (int i = 0; i < linha.Count(); i++)
                {
                    var itens = linha[i];
                    if (itens.Value<int>("cli_Cliente_int_PK") != 0) { cliente.idCliente = itens.Value<int>("cli_Cliente_int_PK"); }
                    if (itens.Value<int>("cli_Empresa_int_FK") != 0) { cliente.idEmpresa = itens.Value<int>("cli_Empresa_int_FK"); }
                    if (itens.Value<string>("cli_Nome_chr") != null) { cliente.nome = encodeString.encodeString(itens.Value<string>("cli_Nome_chr")); }
                    if (itens.Value<string>("cli_Responsavel_chr") != null) { cliente.responsavel = encodeString.encodeString(itens.Value<string>("cli_Responsavel_chr")); }
                    if (itens.Value<string>("cli_Endereco_chr") != null) { cliente.endereco = encodeString.encodeString(itens.Value<string>("cli_Endereco_chr")); }
                    if (itens.Value<string>("cli_Numero_chr") != null) { cliente.numero = encodeString.encodeString(itens.Value<string>("cli_Numero_chr")); }
                    if (itens.Value<string>("cli_Complemento_chr") != null) { cliente.complemento = encodeString.encodeString(itens.Value<string>("cli_Complemento_chr")); }
                    if (itens.Value<string>("cli_Bairro_chr") != null) { cliente.bairro = encodeString.encodeString(itens.Value<string>("cli_Bairro_chr")); }
                    if (itens.Value<string>("cli_Cidade_chr") != null) { cliente.cidade = encodeString.encodeString(itens.Value<string>("cli_Cidade_chr")); }
                    if (itens.Value<string>("cli_Estado_chr") != null) { cliente.estado = encodeString.encodeString(itens.Value<string>("cli_Estado_chr")); }
                    if (itens.Value<string>("cli_CEP_chr") != null) { cliente.CEP = encodeString.encodeString(itens.Value<string>("cli_CEP_chr")); }
                    if (itens.Value<string>("cli_Telefone_chr") != null) { cliente.telefone = encodeString.encodeString(itens.Value<string>("cli_Telefone_chr")); }
                    if (itens.Value<string>("cli_Celular1_chr") != null) { cliente.celular1 = encodeString.encodeString(itens.Value<string>("cli_Celular1_chr")); }
                    if (itens.Value<string>("cli_CpfCnpj_chr") != null) { cliente.cpfCnpj = encodeString.encodeString(itens.Value<string>("cli_CpfCnpj_chr")); }
                    if (itens.Value<string>("cli_Email_chr") != null) { cliente.email = encodeString.encodeString(itens.Value<string>("cli_Email_chr")); }
                    if (itens.Value<string>("cli_Observacao_chr") != null) { cliente.observacao = encodeString.encodeString(itens.Value<string>("cli_Observacao_chr")); }
                    if (itens.Value<string>("cli_DataCriacao_dtm") != null) {
                        string iDate = itens.Value<string>("cli_DataCriacao_dtm");
                        cliente.dataCriacao = Convert.ToDateTime(iDate);
                    }
                    if (itens.Value<string>("cli_DataSync_dtm") != null) { 
                        cliente.dataSync = DateTime.Now; 
                    }
                    if (itens.Value<int>("cli_Ativo_int") != 0) { cliente.ativo = itens.Value<int>("cli_Ativo_int"); }

                }
                inCliente(cliente.idEmpresa, cliente);
            }
        }
    }
}