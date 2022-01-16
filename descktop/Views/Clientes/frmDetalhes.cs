using descktop.Data;
using descktop.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace descktop.Views.Clientes
{
    public partial class frmDetalhes : Form
    {
        frmInicio frmInicio;
        frmClientes frmClientes;
        int idEmpresa;
        int idCliente;
        PrintDocument document = new PrintDocument();
        PrintDialog dialog = new PrintDialog();
        string etiquetaCliente;
        public frmDetalhes(int idEmp, int idCli, frmInicio ini, frmClientes cli)
        {
            frmInicio = ini;
            InitializeComponent();
            frmInicio.Resize += new EventHandler(this.frmInicio_Resize);
            montarCbEstado();
            montarHistorico();
            frmClientes = cli;
            idEmpresa = idEmp;
            idCliente = idCli;
            buscarCliente(idEmpresa, idCliente);
            document.PrintPage += new PrintPageEventHandler(document_PrintPage);
            buscarIdPedidos();
            //frmInicio.LoadingImage();
        }

        public void frmInicio_Resize(object sender, EventArgs e)
        {
            this.WindowState = frmInicio.WindowState;

        }

        public void buscarCliente(int idEmp, int idCli)
        {
            ClienteService clienteService = new ClienteService();

            ClientesModel cliente = clienteService.seCliente(idEmp, idCli);
            montaCliente(cliente);


        }
        public void montaCliente(ClientesModel cliente)
        {
            txtNome.Text = cliente.nome;
            txtResp.Text = cliente.responsavel;
            txtEnd.Text = cliente.endereco;
            txtNum.Text = cliente.numero;
            txtComp.Text = cliente.complemento;
            txtBair.Text = cliente.bairro;
            txtCid.Text = cliente.cidade;
            cbEst.SelectedIndex = cbEst.FindStringExact(cliente.estado);
            txtCEP.Text = cliente.CEP;
            txtTelef.Text = cliente.telefone;
            txtCel1.Text = cliente.celular1;
            txtCpfCnpj.Text = cliente.cpfCnpj;
            txtEmail.Text = cliente.email;
            txtObs.Text = cliente.observacao;

            etiquetaCliente = cliente.nome;
            etiquetaCliente += cliente.responsavel == "" ? "" : "\r\nA/C: " + cliente.responsavel;
            etiquetaCliente += "\r\n\r\nEndereço: " + cliente.endereco + ", " + cliente.numero;
            etiquetaCliente += cliente.complemento == "" ? "" : "\r\nComplemento: " + cliente.complemento;
            etiquetaCliente += "\r\nCEP: " + cliente.CEP;
            etiquetaCliente += cliente.bairro == "" ? "" : "\r\nBairro: " + cliente.bairro;
            etiquetaCliente += "\r\nCidade: " + cliente.cidade + " - " + cliente.estado;

            txtEtiqueta.Text = etiquetaCliente;
            txtEtiqueta.ScrollBars = ScrollBars.Vertical;
        }
        private void btnDetVoltar_Click(object sender, EventArgs e)
        {
            voltar();
            //frmInicio.pContainer.Controls.Clear();
            //frmClientes frmCli = new frmClientes(idEmpresa, frmInicio);
            //frmCli.TopLevel = false;
            //frmInicio.pContainer.Controls.Add(frmCli);
            //frmCli.WindowState = frmInicio.WindowState;
            //frmCli.Show();
        }

        public void montarCbEstado()
        {
            cbEst.Items.Add("");
            cbEst.Items.Add("AC");
            cbEst.Items.Add("AL");
            cbEst.Items.Add("AP");
            cbEst.Items.Add("AM");
            cbEst.Items.Add("BA");
            cbEst.Items.Add("CE");
            cbEst.Items.Add("ES");
            cbEst.Items.Add("GO");

            cbEst.Items.Add("MA");
            cbEst.Items.Add("MT");
            cbEst.Items.Add("MS");
            cbEst.Items.Add("MG");
            cbEst.Items.Add("PA");
            cbEst.Items.Add("PB");
            cbEst.Items.Add("PR");
            cbEst.Items.Add("PE");
            cbEst.Items.Add("PI");
            cbEst.Items.Add("RJ");
            cbEst.Items.Add("RN");
            cbEst.Items.Add("RS");
            cbEst.Items.Add("RO");
            cbEst.Items.Add("RR");
            cbEst.Items.Add("SC");
            cbEst.Items.Add("SP");
            cbEst.Items.Add("SE");
            cbEst.Items.Add("TO");
            cbEst.Items.Add("DF");

            cbEst.SelectedIndex = 0;

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            ClientesModel cliente = new ClientesModel();
            cliente.nome = txtNome.Text;
            cliente.responsavel = txtResp.Text;
            cliente.endereco = txtEnd.Text;
            cliente.numero = txtNum.Text;
            cliente.complemento = txtComp.Text;
            cliente.bairro = txtBair.Text;
            cliente.cidade = txtCid.Text;
            cliente.estado = cbEst.SelectedItem.ToString();
            cliente.CEP = txtCEP.Text;
            cliente.telefone = txtTelef.Text;
            cliente.celular1 = txtCel1.Text;
            cliente.cpfCnpj = txtCpfCnpj.Text;
            cliente.email = txtEmail.Text;
            cliente.observacao = txtObs.Text;
            cliente.dataSync = DateTime.Now;

            var valido = validarDados(cliente);
            if (valido != "")
            {
                var caption = "Preencha os Campos:";
                MessageBox.Show(valido, caption);

                return;
            }

            ClienteService clienteService = new ClienteService();
            bool success = clienteService.upCliente(idEmpresa, idCliente, cliente);

            if (success)
            {
                var result = MessageBox.Show("Cliente Alterado com Sucesso");
                voltar();
                //frmInicio.pContainer.Controls.Clear();
                //frmClientes frmCli = new frmClientes(idEmpresa, frmInicio);
                //frmCli.TopLevel = false;
                //frmInicio.pContainer.Controls.Add(frmCli);
                //frmCli.Show();
            }
            else
            {
                MessageBox.Show("Erro ao Alterar Cliente");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
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
                    voltar();
                    //frmInicio.pContainer.Controls.Clear();
                    //frmClientes frmCli = new frmClientes(idEmpresa, frmInicio);
                    //frmCli.TopLevel = false;
                    //frmInicio.pContainer.Controls.Add(frmCli);
                    //frmCli.Show();
                }
                else
                {
                    MessageBox.Show("Erro ao Excluir Cliente");
                }
            }
        }

        public string validarDados(ClientesModel cliente)
        {
            string mensagem = "";

            if (cliente.nome == "")
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
        public void montarHistorico()
        {
            lstHist.Columns.Add("Codigo do Pedido", -2);
            //lstVendas.Columns.Add("Empresa", -2);
            lstHist.Columns.Add("Cliente", -2);
            lstHist.Columns.Add("Valor Total", -2);
            lstHist.Columns.Add("Data da Venda", -2);
            //lstHist.Columns.Add("Pedido Aberto", -2);

            lstHist.View = View.Details;
            lstHist.FullRowSelect = true;
        }

        public void buscarIdPedidos()
        {
            PedidoService pedidoService = new PedidoService();

            List<int> idPedidos = pedidoService.lsIdPedido(idEmpresa, idCliente);

            if (idPedidos.Count > 0)
            {
                BuscarPedidos(idPedidos);

            }


        }
        public void BuscarPedidos(List<int> idPedidos)
        {
            bool pedidoAberto = true;

            PedidoService pedidoService = new PedidoService();
            ItemPedidoService itemPedidoService = new ItemPedidoService();
            CondicaoService condicaoService = new CondicaoService();
            FreteService freteService = new FreteService();
            ClienteService clienteService = new ClienteService();
            //MontalistaDeVendas

            List<PedidosModel> lista = pedidoService.lsPedidos(idEmpresa, idPedidos, pedidoAberto);

            foreach (PedidosModel venda in lista)
            {
                venda.cliente = clienteService.seCliente(venda.idEmpresa, venda.cliente.idCliente);
                venda.frete = freteService.seFretePedido(venda.idEmpresa, venda.idPedido);
                venda.condicao = condicaoService.seCondicaoPedido(venda.idEmpresa, venda.idPedido);

                ListViewItem item = null;
                if (pedidoAberto)
                {
                    String[] row = {
                    venda.idPedido.ToString(),
                    venda.cliente.nome is null ? "": venda.cliente.nome.ToString(),
                    venda.valorTotal.ToString("C"),
                    venda.dataVenda.ToShortDateString()
                    };
                    item = new ListViewItem(row);
                }
                else
                {
                    String[] row = {
                    venda.idPedido.ToString(),
                    venda.cliente.nome is null ? "": venda.cliente.nome.ToString(),
                    venda.valorTotal.ToString("C"),
                    venda.dataVenda.ToShortDateString()
                    };
                    item = new ListViewItem(row);
                }
                lstHist.Items.Add(item);
            }
            lstHist.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
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

        void document_PrintPage(object sender, PrintPageEventArgs e)
        {
            string etiquetaRemetente = "\r\n - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -" +
                                        "\r\nCentral de Afiação" +
                                        "\r\n\r\nEndereço: Rua Moacir Falaguasta, 2390" +
                                        "\r\nCEP: 14407-061" +
                                        "\r\nBairro: Tropical II" +
                                        "\r\nCidade: Franca - SP";

            e.Graphics.DrawString(etiquetaCliente + etiquetaRemetente, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, 20, 20);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dialog.Document = document;
            dialog.Document.DefaultPageSettings.PrinterResolution = dialog.Document.PrinterSettings.PrinterResolutions[3];// = dialog.Document.PrinterSettings.PrinterResolutions[];

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                document.Print();
            }
        }

        private void btnVisPed_Click(object sender, EventArgs e)
        {
            if (lstHist.SelectedItems.Count == 0)
                return;

            ListViewItem item = lstHist.SelectedItems[0];
            int idPedido = int.Parse(item.SubItems[0].Text);

            if (idPedido == 0)
            {
                MessageBox.Show("Escolha um pedido para visualizar");
            }
            else
            {
                frmInicio.pContainer.Controls.Clear();
                Vendas.frmDetalhes formDet = new Vendas.frmDetalhes(idEmpresa, idPedido, frmInicio);
                formDet.TopLevel = false;
                frmInicio.pContainer.Controls.Add(formDet);
                formDet.WindowState = frmInicio.WindowState;
                formDet.Show();
                frmInicio.LabelTitle = "Tela de Pedidos";
            }
        }
    }
}
