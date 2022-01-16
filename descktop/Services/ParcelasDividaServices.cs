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
    class ParcelasDividaServices
    {
        DBService DBService;
        public ParcelasDividaServices()
        {
            DBService = new DBService();
        }

        public List<ParcelaDividasModel> lsParcelasDividas(int idEmp, int idDiv)
        {
            string comandoSql = "select " +
                "par_ParcelaDivida_int_PK, " +
                "par_Empresa_int_FK, " +
                "par_Divida_int_FK, " +
                "par_ParcelaDivida_chr, " +
                "par_ValorParcela_mon, " +
                "par_FormaPagamento_chr, " +
                "par_Pago_int, " +
                "par_DataParcela_dtm, " +
                "par_DataPagamento_dtm " +
                "from TB_CA_ParcelaDividas_par " +
                "where par_Empresa_int_FK = " + idEmp + " and " +
                "par_Divida_int_FK = " + idDiv;


            OleDbCommand commando = new OleDbCommand(comandoSql, DBService.conexao);

            try
            {
                //Abertura da conexão
                DBService.conexao.Open();

                //Executar o comando e ler os dados retornados
                OleDbDataReader dados = commando.ExecuteReader();

                List<ParcelaDividasModel> lstParcelaDividas = new List<ParcelaDividasModel>();

                while (dados.Read())
                {
                    if ((int)dados["par_ParcelaDivida_int_PK"] != -1)
                    {
                        DateTime dataParcela;
                        DateTime.TryParse(dados["par_DataParcela_dtm"].ToString(), out dataParcela);

                        DateTime dataPagamento;
                        DateTime.TryParse(dados["par_DataPagamento_dtm"].ToString(), out dataPagamento);

                        ParcelaDividasModel parcelas = new ParcelaDividasModel();
                        parcelas.idParcelaDivida = (int)dados["par_ParcelaDivida_int_PK"];
                        parcelas.idEmpresa = (int)dados["par_Empresa_int_FK"];
                        parcelas.idDivida = (int)dados["par_Divida_int_FK"];
                        parcelas.parcela = dados["par_ParcelaDivida_chr"].ToString();
                        parcelas.formaPagamento = dados["par_FormaPagamento_chr"].ToString();
                        parcelas.valorParcela = (decimal)dados["par_ValorParcela_mon"];
                        parcelas.pago = (int)dados["par_Pago_int"];
                        parcelas.dataParcela = dataParcela;
                        parcelas.dataPagamento = dataPagamento;

                        lstParcelaDividas.Add(parcelas);
                    }
                    else
                    {
                        return null;
                    }
                }
                return lstParcelaDividas;
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

        public ParcelaDividasModel seParcelaDividas(int idEmp, int idDiv, int idParc)
        {
            string comandoSql = "select " +
                "par_ParcelaDivida_int_PK, " +
                "par_Empresa_int_FK, " +
                "par_Divida_int_FK, " +
                "par_ParcelaDivida_chr, " +
                "par_ValorParcela_mon, " +
                "par_FormaPagamento_chr, " +
                "par_Pago_int, " +
                "par_DataParcela_dtm, " +
                "par_DataPagamento_dtm " +
                "from TB_CA_ParcelaDividas_par " +
                "where par_ParcelaDivida_int_PK = " + idParc + " and " +
                "par_Empresa_int_FK = " + idEmp + " and " +
                "par_Divida_int_FK = " + idDiv ;


            OleDbCommand commando = new OleDbCommand(comandoSql, DBService.conexao);

            try
            {
                //Abertura da conexão
                DBService.conexao.Open();

                //Executar o comando e ler os dados retornados
                OleDbDataReader dados = commando.ExecuteReader();
                ParcelaDividasModel parcelas = new ParcelaDividasModel();

                while (dados.Read())
                {
                    if ((int)dados["par_ParcelaDivida_int_PK"] != -1)
                    {
                        DateTime dataParcela;
                        DateTime.TryParse(dados["par_DataParcela_dtm"].ToString(), out dataParcela);

                        DateTime dataPagamento;
                        DateTime.TryParse(dados["par_DataPagamento_dtm"].ToString(), out dataPagamento);

                        parcelas.idParcelaDivida = (int)dados["par_ParcelaDivida_int_PK"];
                        parcelas.idEmpresa = (int)dados["par_Empresa_int_FK"];
                        parcelas.idDivida = (int)dados["par_Divida_int_FK"];
                        parcelas.parcela = dados["par_ParcelaDivida_chr"].ToString();
                        parcelas.formaPagamento = dados["par_FormaPagamento_chr"].ToString();
                        parcelas.valorParcela = (decimal)dados["par_ValorParcela_mon"];
                        parcelas.pago = (int)dados["par_Pago_int"];
                        parcelas.dataParcela = dataParcela;
                        parcelas.dataPagamento = dataPagamento;

                    }
                    else
                    {
                        return null;
                    }
                }
                return parcelas;
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

        public bool inParcelaDivida(int idEmp, int idDiv, ParcelaDividasModel parcelaDivida)
        {
            string comandoSql = "insert into TB_CA_ParcelaDividas_par (" +
                "par_Empresa_int_FK, " +
                "par_Divida_int_FK, " +
                "par_ParcelaDivida_chr, " +
                "par_ValorParcela_mon, " +
                "par_FormaPagamento_chr, " +
                "par_Pago_int, " +
                "par_DataParcela_dtm, " +
                "par_DataPagamento_dtm ) " +
                "VALUES (" +
                idEmp.ToString() + ",'" +
                idDiv + "','" +
                parcelaDivida.parcela + "','" +
                parcelaDivida.valorParcela + "','" +
                parcelaDivida.formaPagamento + "','" +
                parcelaDivida.pago + "','" +
                parcelaDivida.dataParcela + "','" +
                parcelaDivida.dataPagamento + "') ";

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

        public bool upParcelaDivida(int idEmp, int idPar, ParcelaDividasModel parcela)
        {
            string comandoSql = "update TB_CA_ParcelaDividas_par " +
                "set " +
                //"par_ParcelaDivida_chr = " +
                //"par_ValorParcela_mon = " +
                //"par_FormaPagamento_chr = " +
                "par_Pago_int = " + parcela.pago + ", " +
                //"par_DataParcela_dtm = " +
                "par_DataPagamento_dtm = '" + parcela.dataPagamento + "' " +
                "where par_Empresa_int_FK = " + idEmp + " and " +
                "par_Divida_int_FK = " + parcela.idDivida + " and " +
                "par_ParcelaDivida_chr = '" + idPar + "'";


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
