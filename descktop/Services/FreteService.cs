using descktop.Data;
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
            //TB_CA_Frete_frt
            //frt_Frete_int_PK frt_Cliente_int_FK  frt_Empresa_int_FK frt_Pedido_int_FK   frt_CEP_chr frt_ValorFrete_mon  frt_DataFrete_dtm frt_Enviado_int

            //Abertura da conexão
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
                                    frete.idCliente.ToString() + "," +
                                    idPed.ToString() + ",'" +
                                    frete.CEP + "','" +
                                    frete.valorFrete.ToString() + "','" +
                                    frete.dataEnvio.ToString() + "','" +
                                    frete.enviado + "');";

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
    }
}
