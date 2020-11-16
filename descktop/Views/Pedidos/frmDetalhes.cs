using descktop.Data;
using descktop.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace descktop.Views.Vendas
{
    public partial class frmDetalhes : Form
    {
        frmInicio frmInicio;
        PedidosModel pedido = new PedidosModel();
        int idEmpresa;
        int idPedido;
        int idParcela; 
        PrintDocument document = new PrintDocument();
        PrintDialog dialog = new PrintDialog();
        string etiquetaCliente;
        public frmDetalhes(int idEmp, int idPed, frmInicio frmIni)
        {
            frmInicio = frmIni;
            idEmpresa = idEmp;
            idPedido = idPed;
            InitializeComponent();
            frmInicio.Resize += new EventHandler(this.frmInicio_Resize);
            document.PrintPage += new PrintPageEventHandler(document_PrintPage);
            montaListView();
            montaPed();
        }

        public void frmInicio_Resize(object sender, EventArgs e)
        {
            this.WindowState = frmInicio.WindowState;

        }
        public void montaListView()
        {
            // montar o list view dos produtos
            lstProd.Columns.Add("Codigo do Produto", -2);
            lstProd.Columns.Add("Produto", -2);
            lstProd.Columns.Add("Valor Unitario", -2);
            lstProd.Columns.Add("Quantidade", -2);
            lstProd.Columns.Add("Desconto", -2);
            lstProd.Columns.Add("Valor Total", -2);
            lstProd.View = View.Details;
            lstProd.FullRowSelect = true;

            lstPag.Columns.Add("Codigo da Parcela", -2);
            lstPag.Columns.Add("Parcela", -2);
            lstPag.Columns.Add("Valor", -2);
            lstPag.Columns.Add("forma de Pagamento", -2);
            lstPag.Columns.Add("Data da Parcela", -2);
            lstPag.Columns.Add("Pago", -2);
            lstPag.Columns.Add("Data do Pagamento", -2);
            lstPag.View = View.Details;
            lstPag.FullRowSelect = true;

            // montar o list view das condições de pagamento

            lblDtPag.Visible = false;
            dtPag.Visible = false;
        }

        private void montaPed()
        {
            PedidoService pedidoService = new PedidoService();
            ItemPedidoService itemPedidoService = new ItemPedidoService();
            CondicaoService condicaoService = new CondicaoService();
            ClienteService clienteService = new ClienteService();
            ProdutoService produtoService = new ProdutoService();
            FreteService freteService = new FreteService();

            pedido = pedidoService.sePedido(idEmpresa, idPedido);
            pedido.cliente = clienteService.seCliente(idEmpresa, pedido.cliente.idCliente);
            pedido.Produtos = itemPedidoService.seItensPedido(idEmpresa, idPedido);
            pedido.condicao = condicaoService.seCondicaoPedido(idEmpresa, idPedido);
            pedido.frete = freteService.seFretePedido(idEmpresa, idPedido);

            lblCliente.Text = pedido.cliente.nome;
            if (pedido.cliente.nome.Length > 23)
            {
                lblCliente.Text = pedido.cliente.nome.Substring(0, 23) + "...";
            }
            
            lblDataVenda.Text = pedido.dataVenda.ToShortDateString();
            lblTotal.Text = pedido.valorTotal.ToString("C");
            lblFrete.Text = pedido.frete.valorFrete.ToString("C");
            txtObs.Text = pedido.observacao;

            foreach (ProdutosCesta itemCesta in pedido.Produtos.produtos)
            {
                String[] row = {
                    itemCesta.produto.idProduto.ToString(),
                    itemCesta.produto.produto,
                    itemCesta.produto.valor.ToString("C"),
                    itemCesta.quantidade.ToString(),
                    itemCesta.desconto.ToString("C"),
                    itemCesta.valorTotal.ToString("C")
                };

                ListViewItem item = new ListViewItem(row);
                lstProd.Items.Add(item);
            }

            foreach (CondicaoParcelas parcela in pedido.condicao.parcelas)
            {
                String[] row = {
                    parcela.idParcela.ToString(),
                    parcela.numeroParcela,
                    parcela.valorParcela.ToString("C"),
                    parcela.formaPagamento,
                    parcela.dataParcela.ToShortDateString(),
                    (parcela.pago == 1? "Sim": "Não"),
                    (parcela.pago == 1? parcela.dataPagamento.ToShortDateString(): "")
                };

                ListViewItem item = new ListViewItem(row);
                lstPag.Items.Add(item);
            }

            etiquetaCliente = pedido.cliente.nome;
            etiquetaCliente += pedido.cliente.responsavel == "" ? "" : "\r\nA/C: " + pedido.cliente.responsavel;
            etiquetaCliente += "\r\n\r\nEndereço: " + pedido.cliente.endereco + ", " + pedido.cliente.numero;
            etiquetaCliente += pedido.cliente.complemento == "" ? "" : "\r\nComplemento: " + pedido.cliente.complemento;
            etiquetaCliente += "\r\nCEP: " + pedido.cliente.CEP;
            etiquetaCliente += pedido.cliente.bairro == "" ? "" : "\r\nBairro: " + pedido.cliente.bairro;
            etiquetaCliente += "\r\nCidade: " + pedido.cliente.cidade + " - " + pedido.cliente.estado;
            txtEtiqueta.Text = etiquetaCliente;
            txtEtiqueta.ScrollBars = ScrollBars.Vertical;
        }

        private void btnDetVoltar_Click_1(object sender, EventArgs e)
        {
            voltar();
            //    frmInicio.pContainer.Controls.Clear();
            //    frmPedidos frmPed = new frmPedidos(idEmpresa, frmInicio);
            //    frmPed.TopLevel = false;
            //    frmInicio.pContainer.Controls.Add(frmPed);
            //    frmPed.WindowState = frmInicio.WindowState;
            //    frmPed.Show();
        }

        private void lstPag_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPag.SelectedItems.Count == 0)
                return;

            ListViewItem item = lstPag.SelectedItems[0];

            txtNumParc.Text = item.SubItems[1].Text;
            txtValorParc.Text = item.SubItems[2].Text;
            txtFormPag.Text = item.SubItems[3].Text;
            dtParc.Value = DateTime.Parse(item.SubItems[4].Text);
            
            idParcela = int.Parse(item.SubItems[0].Text);

            if (item.SubItems[5].Text == "Sim")
            {
                ckbPaga.Checked = true;
                dtPag.Visible = true;
                lblDtPag.Visible = true;
                dtPag.Value = DateTime.Parse(item.SubItems[6].Text);

            }
            else
            {
                ckbPaga.Checked = false;
                lblDtPag.Visible = false;
                dtPag.Visible = false;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            bool success = true;
            //fazer a rotina de edição da parcela

            PedidoService pedidoService = new PedidoService();

            success = pedidoService.upPedidos(idEmpresa, idPedido, txtObs.Text);

            if (success)
            {
                MessageBox.Show("Pedido Alterado com Sucesso");
                voltar();
                //frmInicio.pContainer.Controls.Clear();
                //frmPedidos frmPed = new frmPedidos(idEmpresa, frmInicio);
                //frmPed.TopLevel = false;
                //frmInicio.pContainer.Controls.Add(frmPed);
                //frmPed.Show();
            }
            else
            {
                MessageBox.Show("Erro ao Alterar Pedido");
            }
        }

        private void btnEdtParc_Click(object sender, EventArgs e)
        {
            CondicaoParcelas parcela = new CondicaoParcelas();
            if (ckbPaga.Checked)
            {
                parcela.pago = 1;
                parcela.dataPagamento = dtPag.Value;
            }
            else
            {
                parcela.pago = 0;

            }
            parcela.idParcela = idParcela;
            
            parcela.dataParcela = dtParc.Value;
            CondicaoService condicaoService = new CondicaoService();
            bool success = condicaoService.upCondicaoPedido(idEmpresa, idPedido, parcela);

            if (success)
            {
                MessageBox.Show("Parcela Alterada com Sucesso");
                lstPag.Items.Clear();
                lstProd.Items.Clear();
                montaPed();
            }
            else
            {
                MessageBox.Show("Erro ao Alterar Parcela");
            }
        }

        private void ckbPaga_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbPaga.Checked)
            {
                lblDtPag.Visible = true;
                dtPag.Visible = true;
            }
            else
            {
                lblDtPag.Visible = false;
                dtPag.Visible = false;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string message = "Confirma a Exclusão do Pedido?";
            string caption = "Excluir Pedido";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
            if (result == DialogResult.Yes)
            {
                PedidoService pedidoService = new PedidoService();
                bool success = pedidoService.dePedido(idEmpresa, idPedido);

                if (success)
                {
                    MessageBox.Show("Pedido Excluido com Sucesso");
                    voltar();
                    //frmInicio.pContainer.Controls.Clear();
                    //frmPedidos frmPed = new frmPedidos(idEmpresa, frmInicio);
                    //frmPed.TopLevel = false;
                    //frmInicio.pContainer.Controls.Add(frmPed);
                    //frmPed.Show();
                }
                else
                {
                    MessageBox.Show("Erro ao Excluir Pedido");
                }
            }
        }

        public void voltar()
        {
            frmInicio.pContainer.Controls.Clear();
            frmPedidos frmPed = new frmPedidos(idEmpresa, frmInicio);
            frmPed.TopLevel = false;
            frmInicio.pContainer.Controls.Add(frmPed);
            frmPed.WindowState = frmInicio.WindowState;
            frmPed.Show();
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
        private void btnEtiqueta_Click(object sender, EventArgs e)
        {
            dialog.Document = document;
            dialog.Document.DefaultPageSettings.PrinterResolution = dialog.Document.PrinterSettings.PrinterResolutions[3];// = dialog.Document.PrinterSettings.PrinterResolutions[];

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                document.Print();
            }
        }
    }
}
