using descktop.Data;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using descktop.Utils;

namespace descktop.Services
{
    class UsuarioService
    {
        DBService DBService;
        public UsuarioService()
        {
            DBService = new DBService();
        }

        public bool inEmpresa(EmpresasModel empresasModel)
        {

            string comandoSql = "insert into TB_CA_Empresas_emp (" +
                "emp_Empresa_int_PK," +
                "emp_Empresa_chr," +
                "emp_Prefixo_chr," +
                "emp_DataCriacao_dtm," +
                "emp_Ativo_int) " +
                "VALUES ('" + empresasModel.idEmpresa.ToString() + "','" +
                            empresasModel.empresa + "','" +
                            empresasModel.prefixo + "','" +
                            empresasModel.dataCriacao.ToString() + "','" +
                            empresasModel.ativo.ToString() + "')";

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
        public bool inUsuario(UsuarioExemplo usuarioExemplo)
        {

            string comandoSql = "insert into TB_CA_Usuarios_usu (" +
                "usu_Usuario_int_PK," +
                "usu_Usuario_chr," +
                "usu_Senha_chr," +
                "usu_Email_chr," +
                "usu_Ativo_int," +
                "usu_Login_chr," +
                "usu_Empresa_int_FK) " +
                "VALUES ('" + 
                    usuarioExemplo.idUsuario.ToString() + "','" +
                    usuarioExemplo.usuario + "','" +
                    usuarioExemplo.password + "','" +
                    usuarioExemplo.email + "','" +
                    usuarioExemplo.ativo.ToString() + "','" +
                    usuarioExemplo.login + "','" +
                    usuarioExemplo.idEmpresa.ToString() + "')";

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
        public void restoreBackUpUsuario(string nomeTabela, JToken tabela)
        {
            DBService dBService = new DBService();
            dBService.truncateTable(nomeTabela, "usu_Usuario_int_PK");
            ParseUtils encodeString = new ParseUtils();
            foreach (var linha in tabela)
            {
                UsuarioExemplo usuarioExemplo = new UsuarioExemplo();
                for (int i = 0; i < linha.Count(); i++)
                {
                    var itens = linha[i];
                    if (itens.Value<int>("usu_Usuario_int_PK") != 0) { usuarioExemplo.idUsuario = itens.Value<int>("usu_Usuario_int_PK"); }
                    if (itens.Value<string>("usu_Usuario_chr") != null) { usuarioExemplo.usuario = encodeString.encodeString(itens.Value<string>("usu_Usuario_chr")); }
                    if (itens.Value<string>("usu_Senha_chr") != null) {usuarioExemplo.password = encodeString.encodeString(itens.Value<string>("usu_Senha_chr")); }
                    if (itens.Value<string>("usu_Email_chr") != null) { usuarioExemplo.email = encodeString.encodeString(itens.Value<string>("usu_Email_chr")); }
                    if (itens.Value<int>("usu_Ativo_int") != 0) { usuarioExemplo.ativo = itens.Value<int>("usu_Ativo_int"); }
                    if (itens.Value<string>("usu_Login_chr") != null) { usuarioExemplo.login = encodeString.encodeString(itens.Value<string>("usu_Login_chr")); }
                    if (itens.Value<int>("usu_Empresa_int_FK") != 0) { usuarioExemplo.idEmpresa = itens.Value<int>("usu_Empresa_int_FK"); }

                }
                inUsuario(usuarioExemplo);
            }
        }

        public void restoreBackEmpresa(string nomeTabela, JToken tabela)
        {
            DBService dBService = new DBService();
            dBService.truncateTable(nomeTabela, "emp_Empresa_int_PK");
            ParseUtils encodeString = new ParseUtils();
            foreach (var linha in tabela)
            {
                EmpresasModel empresasModel = new EmpresasModel();
                for (int i = 0; i < linha.Count(); i++)
                {
                    var itens = linha[i];
                    if (itens.Value<int>("emp_Empresa_int_PK") != 0) { empresasModel.idEmpresa = itens.Value<int>("emp_Empresa_int_PK"); }
                    if (itens.Value<string>("emp_Empresa_chr") != null) { empresasModel.empresa = encodeString.encodeString(itens.Value<string>("emp_Empresa_chr")); }
                    if (itens.Value<string>("emp_Prefixo_chr") != null) { empresasModel.prefixo = encodeString.encodeString(itens.Value<string>("emp_Prefixo_chr")); }
                    if (itens.Value<int>("emp_Ativo_int") != 0) { empresasModel.ativo = itens.Value<int>("emp_Ativo_int"); }
                    if (itens.Value<string>("emp_DataCriacao_dtm") != null)
                    {
                        string iDate = itens.Value<string>("emp_DataCriacao_dtm");
                        empresasModel.dataCriacao = Convert.ToDateTime(iDate);
                    }
                }
                inEmpresa(empresasModel);
            }
        }
    }
}
