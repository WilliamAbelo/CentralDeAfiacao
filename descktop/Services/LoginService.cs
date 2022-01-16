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
    class LoginService
    {

        DBService DBService;

        public LoginService()
        {
            DBService = new DBService();
        }

        public UsuarioExemplo login(string usuario, string senha)
        {
            //Configuração do comando a ser executado no banco
            string comandoSQL = "SELECT usu_Senha_chr, " +
                                        "usu_Usuario_int_PK, " +
                                        "usu_Empresa_int_FK, " +
                                        "usu_Usuario_chr, " +
                                        "usu_Email_chr " +
                                "FROM TB_CA_Usuarios_usu " +
                                "WHERE usu_Login_chr = '" + usuario + "'";// and usu_Senha_chr = '" + senha + "'";
            OleDbCommand commando = new OleDbCommand(comandoSQL, DBService.conexao);

            try
            {
                //Abertura da conexão
                DBService.conexao.Open();

                //Executar o comando e ler os dados retornados
                OleDbDataReader dados = commando.ExecuteReader();

                while (dados.Read())
                {
                    if (dados[0].ToString() == senha)
                    {
                        UsuarioExemplo usuarioExemplo = new UsuarioExemplo();
                        string id = dados[1].ToString();
                        usuarioExemplo.idUsuario = int.Parse(id);
                        usuarioExemplo.idEmpresa = (int)dados["usu_Empresa_int_FK"];
                        usuarioExemplo.usuario = dados[3].ToString();
                        usuarioExemplo.email = dados[4].ToString();

                        return usuarioExemplo;
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

        public List<EmpresasModel> lsEmpresas()
        {
            //Configuração do comando a ser executado no banco
            //TB_CA_Empresas_emp emp_Empresa_int_PK emp_Empresa_chr emp_Prefixo_chr emp_DataCriacao_dtm
            string comandoSQL = "SELECT emp_Empresa_int_PK, " +
                                        "emp_Empresa_chr, " +
                                        "emp_Prefixo_chr, " +
                                        "emp_DataCriacao_dtm, " +
                                        "emp_Ativo_int " +
                                        "FROM TB_CA_Empresas_emp " +
                                        "WHERE emp_Ativo_int = 1";
            OleDbCommand commando = new OleDbCommand(comandoSQL, DBService.conexao);

            try
            {
                //Abertura da conexão
                DBService.conexao.Open();

                //Executar o comando e ler os dados retornados
                OleDbDataReader dados = commando.ExecuteReader();
                List<EmpresasModel> lsEmpresas = new List<EmpresasModel>();
                while (dados.Read())
                {
                    if ((int)dados["emp_Empresa_int_PK"] != -1)
                    {
                        DateTime dataCriacao;
                        DateTime.TryParse(dados["emp_DataCriacao_dtm"].ToString(), out dataCriacao);

                        EmpresasModel empresa = new EmpresasModel();
                        empresa.idEmpresa = (int)dados["emp_Empresa_int_PK"];
                        empresa.empresa = (string)dados["emp_Empresa_chr"];
                        empresa.prefixo = (string)dados["emp_Prefixo_chr"];
                        empresa.dataCriacao = dataCriacao;
                        empresa.ativo = (int)dados["emp_Ativo_int"];

                        lsEmpresas.Add(empresa);
                    }
                    else
                    {
                        return null;
                    }
                }
                return lsEmpresas;
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
