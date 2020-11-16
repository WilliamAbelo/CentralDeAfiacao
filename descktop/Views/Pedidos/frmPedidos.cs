using descktop.Data;
using descktop.Services;
using descktop.Views.Vendas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListView;

namespace descktop
{
    public partial class frmPedidos : Form
    {
        frmInicio frmInicio;
        int idEmpresa;
        int idPedido;
        int pagina;
        string paginacao;
        int primeiroId;
        int ultimoId;
        List<int> idPedidos;
        bool buscarPedAbertos;
        public frmPedidos(int idEmp, frmInicio frmIn)
        {
            frmInicio = frmIn;
            idEmpresa = idEmp;
            InitializeComponent();

            frmInicio.Resize += new EventHandler(this.frmInicio_Resize);
            ctrListaPed.SelectedTab = tbAbr;
            buscarPedAbertos = true;
            pagina = 1;
            lblPage.Text = "... " + pagina + " ...";
            paginacao = " and ped_Pedido_int_PK > 0 ";
            ultimoId = 0;
            primeiroId = 0;
            montaListView();
            buscarIdPeds();

        }

        public void frmPedidos_Load(object sender, EventArgs e)
        {
            if (idPedidos.Count > 0)
            {
                BuscarPedidos(buscarPedAbertos); // false ele concatena 'in (' ou seja busca todos os pedidos com ids que ainda tem condiçoes em aberto
            }
        }

        public void frmInicio_Resize(object sender, EventArgs e)
        {
            this.WindowState = frmInicio.WindowState;
            frmInicio.LabelTitle = "Tela de Pedidos Abertos";

        }

        public void montaListView()
        {
            lstVendas.Columns.Add("Codigo do Pedido", -2);
            //lstVendas.Columns.Add("Empresa", -2);
            lstVendas.Columns.Add("Cliente", -2);
            lstVendas.Columns.Add("Valor Total", -2);
            lstVendas.Columns.Add("Data da Venda", -2);
            lstVendas.Columns.Add("Parcelas Pagas", -2);
            lstVendas.Columns.Add("Parcelas Restantes", -2);
            lstVendas.Columns.Add("Parcelas Em Atraso", -2);

            lstVendas.View = View.Details;
            lstVendas.FullRowSelect = true;
        }

        public void buscarIdPeds()
        {
            CondicaoService condicaoService = new CondicaoService();
            //busca os ids de pedidos que ainda estao com condiçoes em aberto

            idPedidos = condicaoService.lsCondicaoPedido(idEmpresa, 0); //remover depois do teste
        }

        public void BuscarPedidos(bool buscarPedAbertos, string nome = "")
        {
            //frmInicio.LabelLoad = true;
            PedidoService pedidoService = new PedidoService();
            ItemPedidoService itemPedidoService = new ItemPedidoService();
            CondicaoService condicaoService = new CondicaoService();
            FreteService freteService = new FreteService();
            ClienteService clienteService = new ClienteService();

            List<PedidosModel> lista = pedidoService.lsPedidos(idEmpresa, idPedidos, buscarPedAbertos, paginacao, pagina);

            if (lista.Count == 0)
            {
                return;
            };
            var first = lista.First();
            var last = lista.Last();
            
            foreach (PedidosModel venda in lista)
            {
                if (nome == "")
                {
                    if (venda.Equals(first) && !buscarPedAbertos)
                    {
                        primeiroId = venda.idPedido;
                    }
                    if (venda.Equals(last) && !buscarPedAbertos)
                    {
                        ultimoId = venda.idPedido;
                    }
                }
                venda.cliente = clienteService.seCliente(venda.idEmpresa, venda.cliente.idCliente);
                venda.frete = freteService.seFretePedido(venda.idEmpresa, venda.idPedido);
                venda.condicao = condicaoService.seCondicaoPedido(venda.idEmpresa, venda.idPedido);


                string ParcPagas = "";
                string ParcRest = "";
                string ParcAtrs = "";
                DateTime hoje = DateTime.Now.Date;
                foreach (CondicaoParcelas parcela in venda.condicao.parcelas)
                {

                    if (parcela.pago != 1)
                    {
                        if ((parcela.dataParcela.Date < hoje) && (parcela.pago == 0))
                        {
                            ParcAtrs += "[ " + parcela.numeroParcela + " ], ";
                        }
                        else
                        {
                            ParcRest += "[ " + parcela.numeroParcela + " ], ";
                        }
                    }
                    else
                    {
                        ParcPagas += "[ " + parcela.numeroParcela + " ], ";
                    }


                }

                if (nome != "" && venda.cliente.nome.ToLower().Contains(nome.ToLower()))
                {

                    String[] row = {
                        venda.idPedido.ToString(),
                        //venda.idEmpresa.ToString(),
                        venda.cliente.nome is null ? "": venda.cliente.nome.ToString(),
                        venda.valorTotal.ToString("C"),
                        venda.dataVenda.ToShortDateString(),
                        ParcPagas,
                        ParcRest,
                        ParcAtrs
                    };

                    ListViewItem item = new ListViewItem(row);
                    lstVendas.Items.Add(item);
                }
                else if (nome == "")
                {
                    String[] row = {
                        venda.idPedido.ToString(),
                        //venda.idEmpresa.ToString(),
                        venda.cliente.nome is null ? "": venda.cliente.nome.ToString(),
                        venda.valorTotal.ToString("C"),
                        venda.dataVenda.ToShortDateString(),
                        ParcPagas,
                        ParcRest,
                        ParcAtrs
                    };

                    ListViewItem item = new ListViewItem(row);
                    lstVendas.Items.Add(item);
                }
            }
            lstVendas.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            //frmInicio.LabelLoad = false;
            if ((!buscarPedAbertos) && (lstVendas.Items.Count < 5) && (txtBuscaNom.Text == ""))
            {
                btnPagMais.Enabled = false;
                //pagina = 0;
            }
        }
        private void btnVisualizarVen_Click(object sender, EventArgs e)
        {
            if (idPedido == 0)
            {
                MessageBox.Show("Escolha um pedido para visualizar");
            }
            else
            {
                frmInicio.pContainer.Controls.Clear();
                frmDetalhes formDet = new frmDetalhes(idEmpresa, idPedido, frmInicio);
                formDet.TopLevel = false;
                frmInicio.pContainer.Controls.Add(formDet);
                formDet.WindowState = frmInicio.WindowState;
                formDet.Show();
            }
        }

        private void btnNovoPed_Click(object sender, EventArgs e)
        {
            frmInicio.pContainer.Controls.Clear();
            frmNovo formNov = new frmNovo(idEmpresa, frmInicio, this);
            formNov.TopLevel = false;
            frmInicio.pContainer.Controls.Add(formNov);
            formNov.WindowState = frmInicio.WindowState;
            formNov.Show();
        }


        private void ctrListaPed_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstVendas.Items.Clear();
            ultimoId = 0;
            primeiroId = 0;
            btnPagMenos.Enabled = false;
            btnPagMais.Enabled = true;
            switch (ctrListaPed.SelectedIndex)
            {
                case 1: //Em Andamento  
                    pnPag.Visible = false;
                    tbAbr.Controls.Add(lstVendas);
                    buscarPedAbertos = true;
                    frmInicio.LabelTitle = "Tela de Pedidos Abertos";
                    break;
                case 0: //Finalizado  
                    pnPag.Visible = true;
                    tbFin.Controls.Add(lstVendas);
                    buscarPedAbertos = false;
                    frmInicio.LabelTitle = "Tela de Pedidos Finalizados";
                    break;

                default: //outros produtos    
                    pnPag.Visible = false;
                    tbAbr.Controls.Add(lstVendas);
                    buscarPedAbertos = true;
                    break;
            }
            if (idPedidos.Count > 0)
            {
                BuscarPedidos(buscarPedAbertos);
            }
        }

        private void btnExcluirVen_Click(object sender, EventArgs e)
        {
            if (lstVendas.SelectedItems.Count == 0)
                return;
            ListViewItem item = lstVendas.SelectedItems[0];
            int idPedido = int.Parse(item.SubItems[0].Text);

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

                    frmInicio.pContainer.Controls.Clear();
                    frmPedidos frmPed = new frmPedidos(idEmpresa, frmInicio);
                    frmPed.TopLevel = false;
                    frmInicio.pContainer.Controls.Add(frmPed);
                    frmPed.WindowState = frmInicio.WindowState;
                    frmPed.Show();
                }
                else
                {
                    MessageBox.Show("Erro ao Excluir Pedido");
                }
            }
        }
        private void btnBuscarNmAbe_Click(object sender, EventArgs e)
        {
            lstVendas.Items.Clear();
            if (idPedidos.Count > 0)
            {
                if (buscarPedAbertos)
                {
                    BuscarPedidos(buscarPedAbertos, txtBuscaNom.Text);
                }
                else
                {
                    BuscarPedidos(buscarPedAbertos, txtBuscaNom.Text);
                }
            }
            //pagina = 1;
        }

        private void lstVendas_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (lstVendas.SelectedItems.Count == 0)
                return;

            ListViewItem item = lstVendas.SelectedItems[0];
            idPedido = int.Parse(item.SubItems[0].Text);
        }

        private void btnPagMenos_Click(object sender, EventArgs e)
        {
            if (pagina > 0)
            {
                pagina--;
            }
            if (pagina == 1)
            {
                btnPagMenos.Enabled = false;
                btnPagMais.Enabled = true;
            }
            lstVendas.Items.Clear();
            paginacao = " and ped_Pedido_int_PK < " + primeiroId + " ";
            if (idPedidos.Count > 0)
            {
                BuscarPedidos(buscarPedAbertos);
            }
            lblPage.Text = "... " + pagina + " ...";
        }

        private void btnPagMais_Click(object sender, EventArgs e)
        {
            lstVendas.Items.Clear();
            paginacao = " and ped_Pedido_int_PK > " + ultimoId + " ";
            pagina++;
            if (pagina > 1)
            {
                btnPagMenos.Enabled = true;
            }
            if (idPedidos.Count > 0)
            {
                BuscarPedidos(buscarPedAbertos);
            }
            lblPage.Text = "... " + pagina + " ...";
        }
    }
}
