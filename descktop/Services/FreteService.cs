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
    class FreteService
    {
        DBService DBService;
        public FreteService()
        {
            DBService = new DBService();
        }


        public FreteModel seFretePedido(int idEmp, int idPed)
        {
            //TB_CA_Frete_frt
            //frt_Frete_int_PK frt_Cliente_int_FK  frt_Empresa_int_FK frt_Pedido_int_FK   frt_CEP_chr frt_ValorFrete_mon  frt_DataFrete_dtm frt_Enviado_int
            string comandoSql = "select frt_Frete_int_PK," +
                                "frt_Cliente_int_FK," +
                                "frt_Empresa_int_FK," +
                                "frt_Pedido_int_FK," +
                                "frt_CEP_chr," +
                                "frt_ValorFrete_mon," +
                                "frt_DataFrete_dtm," +
                                "frt_Enviado_int " +
                                "FROM TB_CA_Frete_frt " +
                                "WHERE frt_Empresa_int_FK = " + idEmp + " and " +
                                "frt_Pedido_int_FK = " + idPed;

            OleDbCommand commando = new OleDbCommand(comandoSql, DBService.conexao);

            try
            {
                //Abertura da conexão
                DBService.conexao.Open();

                //Executar o comando e ler os dados retornados
                OleDbDataReader dados = commando.ExecuteReader();
                FreteModel frete = new FreteModel();
                while (dados.Read())
                {
                    if ((int)dados["frt_Frete_int_PK"] != -1)
                    {
                        DateTime dataEnvio;
                        DateTime.TryParse(dados["frt_DataFrete_dtm"].ToString(), out dataEnvio);


                        frete.idFrete = (int)dados["frt_Frete_int_PK"];
                        frete.idEmpresa = (int)dados["frt_Empresa_int_FK"];
                        frete.idCliente = (int)dados["frt_Cliente_int_FK"];
                        frete.idPedido = (int)dados["frt_Pedido_int_FK"];
                        frete.CEP = dados["frt_CEP_chr"].ToString();
                        frete.valorFrete = (decimal)dados["frt_ValorFrete_mon"];
                        frete.enviado = (int)dados["frt_Enviado_int"];
                        frete.dataEnvio = dataEnvio;
                    }
                    else
                    {
                        return null;
                    }
                }
                return frete;
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
        public bool inFretePedido(int idEmp, int idPed, FreteModel frete)
        {
            string insertId = "";
            string id = "";
            if (frete.idFrete != 0)
            {
                insertId = "frt_Frete_int_PK,";
                id = frete.idFrete + ",";
            }

            string comandoSql = "insert into TB_CA_Frete_frt (" +
                insertId +
                "frt_Empresa_int_FK, " +
                "frt_Cliente_int_FK, " +
                "frt_Pedido_int_FK, " +
                "frt_CEP_chr, " +
                "frt_ValorFrete_mon, " +
                "frt_DataFrete_dtm," +
                "frt_Enviado_int )" +
                "VALUES (" +
                id +
                idEmp.ToString() + "," +
                frete.idCliente.ToString() + "," +
                idPed.ToString() + ",'" +
                frete.CEP + "','" +
                frete.valorFrete.ToString() + "','" +
                frete.dataEnvio.ToString() + "','" +
                frete.enviado + "');";

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

        public bool deFretePedido(int idEmp, int idPed)
        {
            //TB_CA_ItensPedido_itp
            //itp_ItemPedido_int_PK itp_Empresa_int_FK itp_Pedido_int_FK   itp_Produto_int_FK itp_Quantidade_int itp_ValorUnitario_mon itp_ValorDesconto_mon itp_ValorTotal_mon 

            string comandoSql = "delete from TB_CA_Frete_frt " +
                                 "where frt_Empresa_int_FK = " + idEmp + " and " +
                                        "frt_Pedido_int_FK = " + idPed;

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
            dBService.truncateTable(nomeTabela, "frt_Frete_int_PK");
            ParseUtils encodeString = new ParseUtils();
            foreach (var linha in tabela)
            {
                FreteModel freteModel = new FreteModel();
                for (int i = 0; i < linha.Count(); i++)
                {
                    var itens = linha[i];
                    if (itens.Value<int>("frt_Frete_int_PK") != 0) { freteModel.idFrete = itens.Value<int>("frt_Frete_int_PK"); }
                    if (itens.Value<int>("frt_Empresa_int_FK") != 0) { freteModel.idEmpresa = itens.Value<int>("frt_Empresa_int_FK"); }
                    if (itens.Value<int>("frt_Cliente_int_FK") != 0) { freteModel.idCliente = itens.Value<int>("frt_Cliente_int_FK"); }
                    if (itens.Value<int>("frt_Pedido_int_FK") != 0) { freteModel.idPedido = itens.Value<int>("frt_Pedido_int_FK"); }
                    if (itens.Value<string>("frt_CEP_chr") != null) { freteModel.CEP = encodeString.encodeString(itens.Value<string>("frt_CEP_chr")); }
                    if (itens.Value<decimal>("frt_ValorFrete_mon") != 0) { freteModel.valorFrete = itens.Value<decimal>("frt_Pedido_int_FK"); }
                    if (itens.Value<string>("frt_DataFrete_dtm") != null)
                    {
                        string iDate = itens.Value<string>("frt_DataFrete_dtm");
                        freteModel.dataEnvio = Convert.ToDateTime(iDate);
                    }
                    if (itens.Value<int>("frt_Enviado_int") != 0) { freteModel.enviado = itens.Value<int>("frt_Enviado_int"); }
                }
                inFretePedido(freteModel.idEmpresa, freteModel.idPedido, freteModel);
                DBService.conexao.Close();
            }
        }
    }
}
