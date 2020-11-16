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

namespace descktop.Views.FluxoCaixa.Dividas
{
    public partial class frmDetalhes : Form
    {
        frmPaga frmDividas;
        frmFluxoCaixa frmFluxoCaixa;
        int idEmpresa;
        int idDivida;
        int parcela;
        public frmDetalhes(int idEmp, int idDiv, frmFluxoCaixa frmFlux, frmPaga frmDiv)
        {
            InitializeComponent();
            montarColunas();
            frmFluxoCaixa = frmFlux;
            frmDividas = frmDiv;
            idEmpresa = idEmp;
            idDivida = idDiv;
            lblEditDtPagamento.Visible = false;
            dtEdtPag.Visible = false;
            buscaDivida();
        }

        public void montarColunas()
        {
            lstParcelas.Columns.Add("Parcela", -2);
            lstParcelas.Columns.Add("Valor Parcela", -2);
            lstParcelas.Columns.Add("Data Parcela", -2);
            lstParcelas.Columns.Add("Pago", -2);
            lstParcelas.Columns.Add("Data Pagamento", -2);

            lstParcelas.View = View.Details;
            lstParcelas.FullRowSelect = true;
        }

        private void buscaDivida()
        {
            DividaService dividaService = new DividaService();
            ParcelasDividaServices parcelasDividaServices = new ParcelasDividaServices();
            DividasModel divida = new DividasModel();
            ParcelaDividasModel parcelas = new ParcelaDividasModel();

            divida = dividaService.seDivida(idEmpresa, idDivida);
            if(divida.pago == 1)
            {
                txtTotalmentePago.Text = "Sim";
            }
            else
            {
                txtTotalmentePago.Text = "Não";
            }

            divida.parcelaDividas = parcelasDividaServices.lsParcelasDividas(idEmpresa, idDivida);

            txtParcela.Text = divida.divida;
            txtValorTotal.Text = divida.valorTotal.ToString();
            dtPriParcela.Value = divida.dataCriacao;
            qtdParc.Value = divida.parcelaDividas.Count();
            cbTipoDivida.SelectedIndex = divida.tipoDivida;

            foreach (var parcela in divida.parcelaDividas)
            {
                String[] row = {
                            parcela.parcela,
                            parcela.valorParcela.ToString("C"),
                            parcela.dataParcela.ToString("dd/MM/yyyy"),
                            parcela.pago == 0? "Não": "Sim",
                            parcela.dataPagamento.ToString("dd/MM/yyyy")
                        };
                ListViewItem item = new ListViewItem(row);
                lstParcelas.Items.Add(item);
            }
            lstParcelas.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lstParcelas.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        public void voltar()
        {
            frmFluxoCaixa.pcFluxo.Controls.Clear();
            frmPaga frmPaga = new frmPaga(idEmpresa, frmFluxoCaixa);
            frmPaga.TopLevel = false;
            frmFluxoCaixa.pcFluxo.Controls.Add(frmPaga);
            frmPaga.WindowState = frmFluxoCaixa.WindowState;
            frmPaga.Show();
        }

        private void lstParcelas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstParcelas.SelectedItems.Count == 0)
                return;

            ListViewItem item = lstParcelas.SelectedItems[0];

            parcela = int.Parse(item.SubItems[0].Text);
            txtEditParcela.Text = item.SubItems[0].Text;
            txtEdtValorParcela.Text = item.SubItems[1].Text;
            dtEdtVenc.Value = DateTime.Parse(item.SubItems[2].Text);
            if (item.SubItems[3].Text == "Sim")
            {
                lblEditDtPagamento.Visible = true;
                dtEdtPag.Visible = true;
                ckbEdtPago.Checked = true;
                dtEdtPag.Value = DateTime.Parse(item.SubItems[4].Text);
            }
            else
            {
                ckbEdtPago.Checked = false;
            }

        }

        private void ckbEdtPago_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbEdtPago.Checked)
            {
                lblEditDtPagamento.Visible = true;
                dtEdtPag.Visible = true;
            }
            else
            {
                lblEditDtPagamento.Visible = false;
                dtEdtPag.Visible = false;
            }
        }

        private void btnEdtParcela_Click(object sender, EventArgs e)
        {
            ParcelasDividaServices parcelasDividaServices = new ParcelasDividaServices();
            DividaService dividaService = new DividaService();
            ParcelaDividasModel parcelaDividasModel = new ParcelaDividasModel();

            parcelaDividasModel.pago = ckbEdtPago.Checked ? 1 : 0;
            parcelaDividasModel.idDivida = idDivida;
            parcelaDividasModel.dataPagamento = dtEdtPag.Value;

            bool succ = parcelasDividaServices.upParcelaDivida(idEmpresa, parcela, parcelaDividasModel);

            if (succ)
            {
                MessageBox.Show("Parcela da Divida Alterada com Sucesso");
                lstParcelas.Items.Clear();
                List<ParcelaDividasModel> parcelas = new List<ParcelaDividasModel>();
                parcelas = parcelasDividaServices.lsParcelasDividas(idEmpresa, idDivida);

                bool finalizaDivida = true;
                foreach (var parcela in parcelas)
                {
                    if (parcela.pago == 0)
                    {
                        finalizaDivida = false;
                    }
                }
                if (finalizaDivida)
                {
                    bool success = dividaService.upFinalizaDivida(idEmpresa, idDivida, 1);
                    if (!success)
                    {
                        MessageBox.Show("Erro ao Alterar Parcela da Divida");
                    }
                } else
                {
                    bool success = dividaService.upFinalizaDivida(idEmpresa, idDivida, 0);
                    if (!success)
                    {
                        MessageBox.Show("Erro ao Alterar Parcela da Divida");
                    }
                }
                buscaDivida();

                ckbEdtPago.Checked = false;
                txtEditParcela.Text = "";
                txtEdtValorParcela.Text = "";
            }
            else
            {
                MessageBox.Show("Erro ao Alterar Parcela da Divida");
            }
        }
    }
}
