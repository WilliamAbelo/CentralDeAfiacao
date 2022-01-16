using descktop.Data;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace descktop.Services
{
    class DividaService
    {
        DBService DBService;
        public DividaService()
        {
            DBService = new DBService();
        }
        public List<DividasModel> lsDividas(int idEmp, int pago)
        {
            string comandoSql = "select " +
                "div_Divida_int_PK, " +
                "div_Empresa_int_FK, " +
                "div_Divida_chr, " +
                "div_Pago_int, " +
                "div_Observacao_chr, " +
                "div_Tipo_int, " +
                "div_Total_mon, " +
                "div_DataCriacao_dtm " +
                "from TB_CA_Dividas_div " +
                "where div_Empresa_int_FK = " + idEmp.ToString() + " and " +
                "div_Pago_int = " + pago.ToString();


            OleDbCommand commando = new OleDbCommand(comandoSql, DBService.conexao);

            try
            {
                //Abertura da conexão
                DBService.conexao.Open();

                //Executar o comando e ler os dados retornados
                OleDbDataReader dados = commando.ExecuteReader();

                List<DividasModel> lstDividas = new List<DividasModel>();

                while (dados.Read())
                {
                    if ((int)dados["div_Divida_int_PK"] != -1)
                    {
                        DateTime dataCriacao;
                        DateTime.TryParse(dados["div_DataCriacao_dtm"].ToString(), out dataCriacao);

                        DividasModel divida = new DividasModel();
                        divida.idDivida = (int)dados["div_Divida_int_PK"];
                        divida.idEmpresa = (int)dados["div_Empresa_int_FK"];
                        divida.divida = dados["div_Divida_chr"].ToString();
                        divida.pago = (int)dados["div_Pago_int"];
                        divida.observacao = dados["div_Observacao_chr"].ToString();
                        divida.tipoDivida = (int)dados["div_Tipo_int"];
                        divida.valorTotal = (decimal)dados["div_Total_mon"];
                        divida.dataCriacao = dataCriacao;

                        lstDividas.Add(divida);
                    }
                    else
                    {
                        return null;
                    }
                }
                foreach (var item in lstDividas)
                {
                    //buscar as parcelas aqui
                }
                return lstDividas;
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

        public DividasModel seDivida(int idEmp, int idDiv)
        {
            string comandoSql = "select " +
                    "div_Divida_int_PK, " +
                    "div_Empresa_int_FK, " +
                    "div_Divida_chr, " +
                    "div_Pago_int, " +
                    "div_Observacao_chr, " +
                    "div_Tipo_int, " +
                    "div_Total_mon, " +
                    "div_DataCriacao_dtm " +
                    "from TB_CA_Dividas_div " +
                    "where div_Empresa_int_FK = " + idEmp + " and " +
                    "div_Divida_int_PK = " + idDiv;


            OleDbCommand commando = new OleDbCommand(comandoSql, DBService.conexao);

            try
            {
                //Abertura da conexão
                DBService.conexao.Open();

                //Executar o comando e ler os dados retornados
                OleDbDataReader dados = commando.ExecuteReader();

                DividasModel divida = new DividasModel();
                while (dados.Read())
                {
                    if ((int)dados["div_Divida_int_PK"] != -1)
                    {
                        DateTime dataCriacao;
                        DateTime.TryParse(dados["div_DataCriacao_dtm"].ToString(), out dataCriacao);

                        divida.idDivida = (int)dados["div_Divida_int_PK"];
                        divida.idEmpresa = (int)dados["div_Empresa_int_FK"];
                        divida.divida = dados["div_Divida_chr"].ToString();
                        divida.pago = (int)dados["div_Pago_int"];
                        divida.observacao = dados["div_Observacao_chr"].ToString();
                        divida.tipoDivida = (int)dados["div_Tipo_int"];
                        divida.valorTotal = (decimal)dados["div_Total_mon"];
                        divida.dataCriacao = dataCriacao;
                    }
                    else
                    {
                        return null;
                    }
                }

                //buscar as parcelas aqui

                return divida;
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

        public bool inDivida(int idEmp, DividasModel divida)
        {
            ParcelasDividaServices parcelasDividaServices = new ParcelasDividaServices();
            string comandoSql1 = "insert into TB_CA_Dividas_div (" +
                "div_Empresa_int_FK, " +
                "div_Divida_chr, " +
                "div_Pago_int, " +
                "div_Observacao_chr, " +
                "div_Tipo_int, " +
                "div_Total_mon, " +
                "div_DataCriacao_dtm ) " +
                "VALUES (" +
                idEmp.ToString() + ",'" +
                divida.divida + "'," +
                divida.pago + ",'" +
                divida.observacao + "'," +
                divida.tipoDivida + ",'" +
                divida.valorTotal + "','" +
                divida.dataCriacao + "') ";
            string comandoSql2 = "SELECT @@IDENTITY;";

            OleDbCommand cmd = new OleDbCommand(comandoSql1, DBService.conexao);
            OleDbCommand cmd2 = new OleDbCommand(comandoSql2, DBService.conexao);

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
                else
                {
                    int id = (int)cmd2.ExecuteScalar();
                    foreach (var item in divida.parcelaDividas)
                    {
                        bool succItem = parcelasDividaServices.inParcelaDivida(idEmp, id, item);
                        if (!succItem)
                        {
                            //fazer o rotina de excluir o pedido, pois se caiu aqui, deu erro
                            return false;
                        }
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

        public bool upDivida(int idEmp, int idCli, ClientesModel cliente)
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

        public bool upFinalizaDivida(int idEmp, int idDiv, int pago)
        {
            string comandoSql = "update TB_CA_Dividas_div " +
                "set " +
                "div_Pago_int = " + pago  + " " +
                "where div_Empresa_int_FK = " + idEmp + " and " +
                "div_Divida_int_PK = " + idDiv;


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

        public bool deDivida(int idEmp, int idCli)
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

        public List<int> seIdDivida(int idEmp, string nome)
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
            foreach (var linha in tabela)
            {
                for (int i = 0; i < linha.Count(); i++)
                {
                    var itens = linha[i];
                    var valor = itens.Value<string>("cli_Nome_chr") ?? "";

                }

            }
        }
    }
}
