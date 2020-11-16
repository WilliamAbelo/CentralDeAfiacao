using descktop.Data;
using descktop.Services;
using descktop.Views.Configuracao;
using descktop.Views.FluxoCaixa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace descktop
{
    public partial class frmInicio : Form
    {
        UsuarioExemplo usuarioLogado = new UsuarioExemplo();
        int idempresa;
        string localPath;
        string Resources;
        int buttonTelas;

        public frmInicio(UsuarioExemplo usuario) //(int idEmpresa)
        {
            InitializeComponent();
            
            usuarioLogado = usuario;
            idempresa = usuarioLogado.idEmpresa;
            localPath = Environment.CurrentDirectory;
            Resources = ConfigurationManager.AppSettings["Resources"];
            buttonTelas = 0;
        }
        private void frmInicio_Load(object sender, EventArgs e)            
        {
            //this.imgLoading.Visible = false;
            pictureBox1.Image = Image.FromFile(localPath + Resources + "Logo.jpg");
            this.Text = "Central de Afiação - " + usuarioLogado.usuario;
        }        

        public string LabelTitle
        {
            get
            {
                return this.lblTitulo.Text;
            }
            set
            {
                this.lblTitulo.Text = value;
            }
        }

        public void MudarTela()
        {
            switch (buttonTelas)
            {
                case 1:
                    TelaPedidos();
                    break;
                case 2:
                    TelaClientes();
                    break;
                case 3:
                    TelaFornecedores();
                    break;
                case 4:
                    TelaProdutos();
                    break;
                case 5:
                    TelaUsuarios();
                    break;
                case 6:
                    TelaFluxo();
                    break;
                case 7:
                    TelaDB();
                    break;
                default:
                    break;
            }

            buttonTelas = 0;
        }

        private void BtnVendas_Click(object sender, EventArgs e)
        {            
            buttonTelas = 1;
            MudarTela();  
        }
        public void TelaPedidos()
        {
            this.pContainer.Controls.Clear();
            frmPedidos frmVen = new frmPedidos(idempresa, this);
            frmVen.TopLevel = false;
            this.pContainer.Controls.Add(frmVen);
            frmVen.WindowState = this.WindowState;
            frmVen.Show();
            LabelTitle = "Tela de Pedidos Abertos";
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            buttonTelas = 2;
            MudarTela();
        }
        public void TelaClientes()
        {
            this.pContainer.Controls.Clear();
            frmClientes frmCli = new frmClientes(idempresa, this);
            frmCli.TopLevel = false;
            this.pContainer.Controls.Add(frmCli);
            frmCli.WindowState = this.WindowState;
            frmCli.Show();
            LabelTitle = "Tela de Clientes";
        }

        private void BtnFornecedores_Click(object sender, EventArgs e)
        {
            buttonTelas = 3;
            MudarTela();
        }
        public void TelaFornecedores()
        {
            this.pContainer.Controls.Clear();
            frmFornecedores frmFor = new frmFornecedores(this);
            frmFor.TopLevel = false;
            this.pContainer.Controls.Add(frmFor);
            frmFor.WindowState = this.WindowState;
            frmFor.Show();
            LabelTitle = "Fornecedores";
        }

        private void BtnEstoque_Click(object sender, EventArgs e)
        {
            buttonTelas = 4;
            MudarTela();
        }
        public void TelaProdutos()
        {
            this.pContainer.Controls.Clear();
            frmProduto frmEst = new frmProduto(idempresa, this);
            frmEst.TopLevel = false;
            this.pContainer.Controls.Add(frmEst);
            frmEst.WindowState = this.WindowState;
            frmEst.Show();
            LabelTitle = "Tela de Produtos";
        }

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            buttonTelas = 5;
            MudarTela();
        }
        public void TelaUsuarios()
        {
            this.pContainer.Controls.Clear();
            frmUsuario frmUsu = new frmUsuario(this);
            frmUsu.TopLevel = false;
            this.pContainer.Controls.Add(frmUsu);
            frmUsu.WindowState = this.WindowState;
            frmUsu.Show();
            LabelTitle = "Usuarios";
        }

        private void btnFluxCaix_Click(object sender, EventArgs e)
        {
            buttonTelas = 6;
            MudarTela();
        }
        public void TelaFluxo()
        {
            this.pContainer.Controls.Clear();
            frmFluxoCaixa frmFluxCaix = new frmFluxoCaixa(idempresa, this);
            frmFluxCaix.TopLevel = false;
            this.pContainer.Controls.Add(frmFluxCaix);
            frmFluxCaix.WindowState = this.WindowState;
            frmFluxCaix.Show();
            LabelTitle = "Fluxo de Caixa";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buttonTelas = 7;
            MudarTela();
        }
        public void TelaDB()
        {
            this.pContainer.Controls.Clear();
            frmDB frmDB = new frmDB(this);
            frmDB.TopLevel = false;
            this.pContainer.Controls.Add(frmDB);
            frmDB.WindowState = this.WindowState;
            frmDB.Show();
            LabelTitle = "Banco de Dados";
        }
        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
