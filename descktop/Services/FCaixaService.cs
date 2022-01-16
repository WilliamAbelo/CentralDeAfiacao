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
    class FCaixaService
    {
        DBService DBService;
        public FCaixaService()
        {
            DBService = new DBService();
        }

        public RecebimentosModel recebSemanais(int idEmp, DateTime inicio, DateTime final)
        {
            string comandoSql = "select " +
                             "con_Condicao_int_PK, " +
                             "con_Empresa_int_FK, " +
                             "con_Pedido_int_FK, " +
                             "con_Parcela_chr, " +
                             "con_ValorParcela_mon, " +
                             "con_DataParcela_dtm, " +
                             "con_Pago_int " +
                             "from TB_CA_Condicao_con " +
                             "where con_Empresa_int_FK = " + idEmp.ToString() + " and " +
                             "con_DataParcela_dtm > #" + inicio.Date.ToString("MM/dd/yyyy") + "# and " +
                             "con_DataParcela_dtm <= #" + final.Date.ToString("MM/dd/yyyy") + "# order by con_DataParcela_dtm";
                             

            OleDbCommand commando = new OleDbCommand(comandoSql, DBService.conexao);

            try
            {
                //Abertura da conexão
                DBService.conexao.Open();

                //Executar o comando e ler os dados retornados
                OleDbDataReader dados = commando.ExecuteReader();
                RecebimentosModel semana = new RecebimentosModel();
                semana.parcelas = new List<Parcelas>();

                while (dados.Read())
                {
                    if ((int)dados["con_Condicao_int_PK"] != -1)
                    {
                        Parcelas parcela = new Parcelas();

                        DateTime dataParcela;
                        DateTime.TryParse(dados["con_DataParcela_dtm"].ToString(), out dataParcela);

                        semana.idEmpresa = idEmp;
                        semana.inicio = inicio;
                        semana.final = final;
                        parcela.idPedido = (int)dados["con_Pedido_int_FK"];
                        parcela.cliente = seCliente(idEmp, parcela.idPedido);
                        parcela.valor = (decimal)dados["con_ValorParcela_mon"];
                        parcela.parcela = (string)dados["con_Parcela_chr"];
                        parcela.dataParcela = dataParcela;
                        parcela.pago = (int)dados["con_Pago_int"];

                        semana.parcelas.Add(parcela);
                    }
                    else
                    {
                        return null;
                    }
                }
                return semana;
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

        public string seCliente(int idEmp, int idPed)
        {
            string comandoSql1 = "select " +
                                    "ped_Pedido_int_PK," +
                                    "ped_Empresa_int_FK," +
                                    "ped_idCliente_int_FK " +
                                    "from TB_CA_Pedidos_ped " +
                                 "where ped_Empresa_int_FK = " + idEmp.ToString() + " and " +
                                        "ped_Pedido_int_PK = " + idPed.ToString();

            OleDbCommand commando = new OleDbCommand(comandoSql1, DBService.conexao);
            int idCliente = 0;

            try
            {
                //Executar o comando e ler os dados retornados
                OleDbDataReader dados = commando.ExecuteReader();

                while (dados.Read())
                {
                    if ((int)dados["ped_Pedido_int_PK"] != -1)
                    {
                        idCliente = (int)dados["ped_idCliente_int_FK"];
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception exc)
            {

                throw new Exception(exc.Message);
            }



            string comandoSql2 = "select " +
                "cli_Cliente_int_PK," +
                "cli_Nome_chr " +
                "from TB_CA_Clientes_cli " +
                "where cli_Cliente_int_PK = " + idCliente.ToString() + " and " +
                "cli_Empresa_int_FK = " + idEmp.ToString() + " and " +
                "cli_Ativo_int = 1";

            commando = new OleDbCommand(comandoSql2, DBService.conexao);
            string cliente = "";

            try
            {
                //Executar o comando e ler os dados retornados
                OleDbDataReader dados = commando.ExecuteReader();

                while (dados.Read())
                {
                    if ((int)dados["cli_Cliente_int_PK"] != -1)
                    {

                        cliente = dados["cli_Nome_chr"].ToString();
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
        }

        public bool inDividas(int idEmp)
        {
            DBService.conexao.Open();
            string comandoSql = "insert into TB_CA_Frete_frt (" +
                        "frt_Empresa_int_FK, " +
                        "frt_Cliente_int_FK, " +
                        "frt_Pedido_int_FK, " +
                        "frt_CEP_chr, " +
                        "frt_ValorFrete_mon, " +
                        "frt_DataFrete_dtm," +
                        "frt_Enviado_int )" +
                        "VALUES (" + idEmp.ToString() + "," +
                                    "');";

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
            return true;
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
