using descktop.Services;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace descktop.Services
{
    class PedidoService
    {
        DBService DBService;

        public PedidoService()
        {
            DBService = new DBService();
        }


        public bool lsPedidos(int idEmp, int idPed) {


        OleDbCommand cmd = new OleDbCommand(comandoSql1, DBService.conexao);
        OleDbCommand cmd2 = new OleDbCommand(comandoSql2, DBService.conexao);
            try
            {
                //Abertura da conexÃ£o
                DBService.conexao.Open();

                //Executar o comando e ler os dados retornados
                //cmd.ExecuteNonQuery();

                int succ = cmd.ExecuteNonQuery();

                if (succ == 0)
                {
                    return false;
                }
                else
                {
                    int id = (int)cmd2.ExecuteScalar();
        bool succItem = itemPedidoService.inItensPedido(idEmp, id, pedido.Produtos);
                    if (!succItem)
                    {
                        //fazer o rotina de excluir o pedido, pois se caiu aqui, deu erro
                        return false;
                    }
                    bool succCond = condicaoService.inCondicaoPedido(idEmp, id, pedido.condicao);
                    if (!succCond)
                    {
                        //fazer o rotina de excluir o pedido e os itensPedido, pois se caiu aqui, deu erro
                        return false;
                    }
                    bool succFret = freteService.inFretePedido(idEmp, id, pedido.frete);
                    if (!succFret)
                    {
                        //fazer o rotina de excluir o pedido, itensPedido e as CondicaoPedido, pois se caiu aqui, deu erro
                        return false;
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

        public bool dePedido(int idEmp, int idPed)
{
    ItemPedidoService itemPedidoService = new ItemPedidoService();
    CondicaoService condicaoService = new CondicaoService();
    FreteService freteService = new FreteService();
    //TB_CA_Pedidos_ped
    //ped_Pedido_int_PK ped_Empresa_int_FK ped_idCliente_int_FK ped_ValorTotal_mon  ped_DataVenda_dtm

    string comandoSql = "delete from TB_CA_Pedidos_ped " +
        "where ped_Empresa_int_FK = " + idEmp + " AND " +
        "ped_Pedido_int_PK = " + idPed;


    //OleDbCommand commando = new OleDbCommand(comandoSql, DBService.conexao);

    OleDbCommand cmd = new OleDbCommand(comandoSql, DBService.conexao);
    try
    {
        //Abertura da conexÃ£o
        DBService.conexao.Open();

        //Executar o comando e ler os dados retornados
        //cmd.ExecuteNonQuery();

        int succ = cmd.ExecuteNonQuery();

        if (succ == 0)
        {
            return false;
        }
        else
        {
            bool succItem = itemPedidoService.deItensPedido(idEmp, idPed);
            if (!succItem)
            {
                //fazer o rotina de excluir o pedido, pois se caiu aqui, deu erro
                return false;
            }
            bool succCond = condicaoService.deCondicaoPedido(idEmp, idPed);
            if (!succCond)
            {
                //fazer o rotina de excluir o pedido e os itensPedido, pois se caiu aqui, deu erro
                return false;
            }
            bool succFret = freteService.deFretePedido(idEmp, idPed);
            if (!succFret)
            {
                //fazer o rotina de excluir o pedido, itensPedido e as CondicaoPedido, pois se caiu aqui, deu erro
                return false;
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

public List<int> lsIdPedido(int idEmp, int idCli)
{
    string comandoSql = "select " +
            "ped_Pedido_int_PK " +
            "from TB_CA_Pedidos_ped " +
            "where ped_Empresa_int_FK = " + idEmp + " and " +
            "ped_idCliente_int_FK = " + idCli +
            " order by ped_DataVenda_dtm desc";

    OleDbCommand commando = new OleDbCommand(comandoSql, DBService.conexao);

    try
    {
        //Abertura da conexÃ£o
        DBService.conexao.Open();

        //Executar o comando e ler os dados retornados
        OleDbDataReader dados = commando.ExecuteReader();

        List<int> lsIdPed = new List<int>();


        while (dados.Read())
        {
            if ((int)dados["ped_Pedido_int_PK"] != -1)
            {

                int idPedido = (int)dados["ped_Pedido_int_PK"];

                lsIdPed.Add(idPedido);
            }
            else
            {
                return null;
            }
        }
        return lsIdPed;
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

public bool upPedidos(int idEmp, int idPed, string observacao)
{
    string comandoSql = "update TB_CA_Pedidos_ped set " +
            "ped_Observacao_chr = '" + observacao + "' " +
            "where ped_Empresa_int_FK = " + idEmp + " and " +
            "ped_Pedido_int_PK = " + idPed;

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


    }
}
