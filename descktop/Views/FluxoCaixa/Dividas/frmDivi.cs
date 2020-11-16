using descktop.Data;
using descktop.Services;
using descktop.Views.FluxoCaixa;
using descktop.Views.FluxoCaixa.Dividas;
using descktop.Views.FluxoCaixa.Pagamentos;
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
    public partial class frmPaga : Form
    {
        int idEmpresa;
        int idDivida;
        int parcelasPagas;
        frmFluxoCaixa frmFluxoCaixa;
        public frmPaga(int idEmp, frmFluxoCaixa frmFlu)
        {
            idEmpresa = idEmp;
            frmFluxoCaixa = frmFlu;
            InitializeComponent();
            frmFluxoCaixa.Resize += new EventHandler(this.frmFluxoCaixa_Resize);
            ctrDividas.SelectedTab = tbAPagar;
            parcelasPagas = 0;
            montarColunas();
            buscarDividas();
        }
        public void frmFluxoCaixa_Resize(object sender, EventArgs e)
        {
            this.WindowState = frmFluxoCaixa.WindowState;

        }

        public void montarColunas()
        {
            lstDividas.Columns.Add("Codigo da Divida", -2);
            lstDividas.Columns.Add("Divida", -2);
            lstDividas.Columns.Add("Valor Parcelas", -2);
            lstDividas.Columns.Add("Valor total", -2);
            lstDividas.Columns.Add("Parcelas Pagas", -2);
            lstDividas.Columns.Add("Parcelas Restantes", -2);
            lstDividas.Columns.Add("Parcelas Em Atraso", -2);

            lstDividas.View = View.Details;
            lstDividas.FullRowSelect = true;            
        }

        public void buscarDividas()
        {
            DividaService dividaService = new DividaService();
            PedidoService pedidoService = new PedidoService();
            ParcelasDividaServices parcelasDividaServices = new ParcelasDividaServices();

            List<DividasModel> lista = dividaService.lsDividas(idEmpresa, parcelasPagas);
            if (lista.Count == 0)
            {
                return;
            };

            foreach (DividasModel divida in lista)
            {

                divida.parcelaDividas = parcelasDividaServices.lsParcelasDividas(idEmpresa, divida.idDivida);
               
                string ParcPagas = "";
                string ParcRest = "";
                string ParcAtrs = "";
                decimal valorParcela = 0;
                DateTime hoje = DateTime.Now.Date;
                foreach (ParcelaDividasModel parcela in divida.parcelaDividas)
                {
                    valorParcela = parcela.valorParcela;
                    if (parcela.pago != 1)
                    {
                        if ((parcela.dataParcela.Date < hoje) && (parcela.pago == 0))
                        {
                            ParcAtrs += "[ " + parcela.parcela + " ], ";
                        }
                        else
                        {
                            ParcRest += "[ " + parcela.parcela + " ], ";
                        }
                    }
                    else
                    {
                        ParcPagas += "[ " + parcela.parcela + " ], ";
                    }
                }

                String[] row = {
                        divida.idDivida.ToString(),
                        //venda.idEmpresa.ToString(),
                        divida.divida is null ? "": divida.divida,
                        valorParcela.ToString("C"),
                        divida.valorTotal.ToString("C"),
                        ParcPagas,
                        ParcRest,
                        ParcAtrs
                    };

                ListViewItem item = new ListViewItem(row);
                lstDividas.Items.Add(item);
            }
            lstDividas.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void btnNovoPag_Click(object sender, EventArgs e)
        {
            frmFluxoCaixa.pcFluxo.Controls.Clear();
            frmNovo frmNov = new frmNovo(idEmpresa, frmFluxoCaixa, this);
            frmNov.TopLevel = false;
            frmFluxoCaixa.pcFluxo.Controls.Add(frmNov);
            frmNov.WindowState = frmFluxoCaixa.WindowState;
            frmNov.Show();
        }

        private void btnDetalhes_Click(object sender, EventArgs e)
        {
            if (idDivida == 0)
            {
                MessageBox.Show("Escolha uma divida para visualizar");
            }
            else
            {
                frmFluxoCaixa.pcFluxo.Controls.Clear();
                frmDetalhes frmNov = new frmDetalhes(idEmpresa, idDivida, frmFluxoCaixa, this);
                frmNov.TopLevel = false;
                frmFluxoCaixa.pcFluxo.Controls.Add(frmNov);
                frmNov.WindowState = frmFluxoCaixa.WindowState;
                frmNov.Show();
            }
        }

        private void lstDividas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstDividas.SelectedItems.Count == 0)
                return;

            ListViewItem item = lstDividas.SelectedItems[0];
            idDivida = int.Parse(item.SubItems[0].Text);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void ctrDividas_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstDividas.Items.Clear();
            switch (ctrDividas.SelectedIndex)
            {
                case 0: //Ja Pagos
                    parcelasPagas = 1;
                    tbJaPagos.Controls.Add(lstDividas);
                    break;
                case 1: //A Pagar
                    parcelasPagas = 0;
                    tbAPagar.Controls.Add(lstDividas);
                    break;
                default:
                    parcelasPagas = 0;
                    tbAPagar.Controls.Add(lstDividas);
                    break;
            }
            buscarDividas();
        }
    }
}
