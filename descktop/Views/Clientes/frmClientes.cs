using descktop.Data;
using descktop.Services;
using descktop.Views.Clientes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace descktop
{
    public partial class frmClientes : Form
    {
        frmInicio frmInicio;
        int idEmpresa;
        string estado;
        public frmClientes(int idEmp, frmInicio frmIn)
        {
            estado = " = 'SP'";
            idEmpresa = idEmp;
            frmInicio = frmIn;
            InitializeComponent();
            //frmInicio.LoadingImage();
            frmInicio.Resize += new EventHandler(this.frmInicio_Resize);
            MontarColunas();
            BuscarLista(estado);
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {

            //frmInicio.LoadingImage();
        }

        public void frmInicio_Resize(object sender, EventArgs e)
        {
            this.WindowState = frmInicio.WindowState;

        }

        public void BuscarLista(string estado, string nome = "")
        {
            ClienteService clienteService = new ClienteService();

            List<ClientesModel> lstClientes = new List<ClientesModel>();

            lstClientes = clienteService.lsClientes(idEmpresa, estado);

            PopularLista(lstClientes, nome);
        }

        public void MontarColunas()
        {
            lstCli.Columns.Add("idCliente", -2);
            lstCli.Columns.Add("idEmpresa", -2);
            lstCli.Columns.Add("Cliente", -2);
            lstCli.Columns.Add("Responsavel", -2);
            lstCli.Columns.Add("Telefone", -2);
            lstCli.Columns.Add("Email", -2);
            lstCli.Columns.Add("Endereço", -2);
            lstCli.Columns.Add("Numero", -2);

            lstCli.View = View.Details;
            lstCli.FullRowSelect = true;
        }

        public void PopularLista(List<ClientesModel> clientes, string nome = "")
        {
            foreach (ClientesModel cliente in clientes)
            {
                if (nome != "" && cliente.nome.ToLower().Contains(nome.ToLower()))
                {
                    String[] row = {
                    cliente.idCliente.ToString(),
                    cliente.idEmpresa.ToString(),
                    cliente.nome,
                    cliente.responsavel,
                    cliente.telefone,
                    cliente.email,
                    cliente.endereco,
                    cliente.numero,
                    cliente.ativo.ToString()
                    };

                    ListViewItem item = new ListViewItem(row);
                    lstCli.Items.Add(item);
                } 
                else if(nome == "")
                {
                    String[] row = {
                    cliente.idCliente.ToString(),
                    cliente.idEmpresa.ToString(),
                    cliente.nome,
                    cliente.responsavel,
                    cliente.telefone,
                    cliente.email,
                    cliente.endereco,
                    cliente.numero,
                    cliente.ativo.ToString()
                    };

                    ListViewItem item = new ListViewItem(row);
                    lstCli.Items.Add(item);
                }
            }
        }

        private void btnVisualizarCli_Click(object sender, EventArgs e)
        {
            if (lstCli.SelectedItems.Count == 0)
                return;

            ListViewItem item = lstCli.SelectedItems[0];

            int idCliente = int.Parse(item.SubItems[0].Text);

            if (idCliente == 0)
            {
                MessageBox.Show("Escolha um cliente para visualizar");
            }
            else
            {
                frmInicio.pContainer.Controls.Clear();
                frmDetalhes formDet = new frmDetalhes(idEmpresa, idCliente, frmInicio, this);
                formDet.TopLevel = false;
                frmInicio.pContainer.Controls.Add(formDet);
                formDet.WindowState = frmInicio.WindowState;
                formDet.Show();
            }
        }

        private void btnNovoCli_Click(object sender, EventArgs e)
        {
            frmInicio.pContainer.Controls.Clear();
            frmNovo formNov = new frmNovo(idEmpresa, frmInicio);
            formNov.TopLevel = false;
            frmInicio.pContainer.Controls.Add(formNov);
            formNov.WindowState = frmInicio.WindowState;
            formNov.Show();
        }

        private void ctrListaCli_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstCli.Items.Clear();
            switch (ctrListaCli.SelectedIndex)
            {
                case 0: //SP
                    estado = " = 'SP'";
                    tbSP.Controls.Add(lstCli);
                    break;
                case 1: //MG
                    estado = " = 'MG'";
                    tbMG.Controls.Add(lstCli);
                    break;
                case 2: //PR
                    estado = " = 'PR'";
                    tbPR.Controls.Add(lstCli);
                    break;
                case 3: //GO
                    estado = " = 'GO'";
                    tbGO.Controls.Add(lstCli);
                    break;
                case 4: //MS
                    estado = " = 'MS'";
                    tbMS.Controls.Add(lstCli);
                    break;
                case 5: //PA
                    estado = " = 'PA'";
                    tbPA.Controls.Add(lstCli);
                    break;
                case 6: //TO
                    estado = " = 'TO'";
                    tbTO.Controls.Add(lstCli);
                    break;
                case 7: //RJ
                    estado = " = 'RJ'";
                    tbRJ.Controls.Add(lstCli);
                    break;
                default: //outros produtos                   
                    break;
            }
            BuscarLista(estado);
        }

        private void btnExcluirCli_Click(object sender, EventArgs e)
        {
            if (lstCli.SelectedItems.Count == 0)
                return;
            ListViewItem item = lstCli.SelectedItems[0];
            int idCliente = int.Parse(item.SubItems[0].Text);

            string message = "Confirma a Exclusão do Cliente?";
            string caption = "Excluir Cliente";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
            if (result == DialogResult.Yes)
            {
                ClienteService clienteService = new ClienteService();
                bool success = clienteService.deCliente(idEmpresa, idCliente);

                if (success)
                {
                    MessageBox.Show("Cliente Excluido com Sucesso");

                    frmInicio.pContainer.Controls.Clear();
                    frmClientes frmCli = new frmClientes(idEmpresa, frmInicio);
                    frmCli.TopLevel = false;
                    frmInicio.pContainer.Controls.Add(frmCli);
                    frmCli.WindowState = frmInicio.WindowState;
                    frmCli.Show();
                }
                else
                {
                    MessageBox.Show("Erro ao Excluir Cliente");
                }
            }
        }

        private void btnBuscNom_Click(object sender, EventArgs e)
        {
            lstCli.Items.Clear();
            //MontarColunas();
            BuscarLista(estado, txtBuscaNom.Text);
        }

    }

}
