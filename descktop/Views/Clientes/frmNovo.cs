using descktop.Data;
using descktop.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace descktop.Views.Clientes
{
    public partial class frmNovo : Form
    {
        frmInicio frmInicio;
        int idEmpresa;
        public frmNovo(int idEmp, frmInicio frmIni)
        {
            idEmpresa = idEmp;
            frmInicio = frmIni;
            InitializeComponent();
            frmInicio.Resize += new EventHandler(this.frmInicio_Resize);
            montarCbEstado();
            //frmInicio.LoadingImage();
        }

        public void frmInicio_Resize(object sender, EventArgs e)
        {
            this.WindowState = frmInicio.WindowState;

        }

        private void btnNovVoltar_Click(object sender, EventArgs e)
        {
            voltar();
            //frmInicio.pContainer.Controls.Clear();
            //frmClientes frmCli = new frmClientes(idEmpresa, frmInicio);
            //frmCli.TopLevel = false;
            //frmInicio.pContainer.Controls.Add(frmCli);
            //frmCli.WindowState = frmInicio.WindowState;
            //frmCli.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClientesModel cliente = new ClientesModel();
            cliente.nome = txtNome.Text;
            cliente.responsavel = txtResp.Text;
            cliente.endereco = txtEnd.Text;
            cliente.numero = txtNum.Text;
            cliente.complemento = txtComp.Text;
            cliente.bairro = txtBairro.Text;
            cliente.cidade = txtCid.Text;
            cliente.estado = cbEst.SelectedItem.ToString();
            cliente.telefone = txtTelef.Text;
            cliente.celular1 = txtCel1.Text;
            cliente.cpfCnpj = txtCpfCnpj.Text;
            cliente.CEP = txtCEP.Text;
            cliente.email = txtEmail.Text;
            cliente.observacao = txtObsr.Text;
            cliente.dataCriacao = DateTime.Now;
            cliente.dataSync = DateTime.Now;
            cliente.ativo = 1;

            var valido = validarDados(cliente);
            if (valido != "")
            {
                var caption = "Preencha os Campos:";
               MessageBox.Show(valido, caption);
                
                return;
            }

            ClienteService clienteService = new ClienteService();
            bool success  = clienteService.inCliente(idEmpresa, cliente);

            if (success)
            {
                var result = MessageBox.Show("Cliente Gravado com Sucesso");
                voltar();
                //frmInicio.pContainer.Controls.Clear();
                //frmClientes frmCli = new frmClientes(idEmpresa, frmInicio);
                //frmCli.TopLevel = false;
                //frmInicio.pContainer.Controls.Add(frmCli);
                //frmCli.Show();
            }
            else
            {
                MessageBox.Show("Erro ao Gravar Cliente");
            }
        }

        public void montarCbEstado()
        {
            cbEst.Items.Add("");
            cbEst.Items.Add("MG");
            cbEst.Items.Add("SP");
            cbEst.Items.Add("PR");
            cbEst.Items.Add("GO");
            cbEst.Items.Add("MS");
            cbEst.Items.Add("PA");
            cbEst.Items.Add("TO");
            cbEst.Items.Add("RJ");

            cbEst.SelectedIndex = 0;
        }


        public string validarDados(ClientesModel cliente)
        {
            string mensagem = "";

            if(cliente.nome == "")
            {

                mensagem += "***Nome do Estabelecimento***\r\n\r\n";
            }
            if (cliente.responsavel == "")
            {
                mensagem += "***Responsavel***\r\n\r\n"; ;
            }
            if (cliente.cidade == "")
            {
                mensagem += "***Cidade***\r\n\r\n"; ;
            }
            if (cliente.estado == "")
            {
                mensagem += "***Estado***\r\n\r\n"; ;
            }
            //nome estabelecomento
            //nome responsavel
            //cidade
            //estado

            return mensagem;
        }

        public void voltar()
        {
            frmInicio.pContainer.Controls.Clear();
            frmClientes frmCli = new frmClientes(idEmpresa, frmInicio);
            frmCli.TopLevel = false;
            frmInicio.pContainer.Controls.Add(frmCli);
            frmCli.WindowState = frmInicio.WindowState;
            frmCli.Show();
        }
    }
}
