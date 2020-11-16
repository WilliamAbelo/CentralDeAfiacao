using descktop.Data;
using descktop.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace descktop
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }        

        private void frmLogin_Close(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            var diretorio = AppContext.BaseDirectory.Split('\\');
            // // desabilita o login
            if (diretorio[diretorio.Length - 2] == "Debug")
            {
                UsuarioExemplo usuarioExemplo = new UsuarioExemplo();
                usuarioExemplo.idEmpresa = 1;
                usuarioExemplo.idUsuario = 1;
                usuarioExemplo.usuario = "Debug";
                this.Hide();
                frmInicio fm = new frmInicio(usuarioExemplo);
                fm.Show();

            }
            else
            {

                if (txtUsuario.Text == "" || txtSenha.Text == "")
                {
                    MessageBox.Show("Por Favor, Insira um Usuario e Senha");
                    return;
                }
                try
                {
                    LoginService loginService = new LoginService();
                    UsuarioExemplo usuarioExemplo = new UsuarioExemplo();
                    usuarioExemplo = loginService.login(txtUsuario.Text, txtSenha.Text);
                    if (usuarioExemplo == null)
                    {
                        MessageBox.Show("Dados incorretos");
                    }
                    else
                    {
                        this.Hide();
                        frmInicio fm = new frmInicio(usuarioExemplo);
                        fm.Show();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
    }
}
