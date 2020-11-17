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

namespace descktop.Views.FluxoCaixa.Pagamentos
{
    public partial class frmNovo : Form
    {
        frmPaga frmDividas;
        frmFluxoCaixa frmFluxoCaixa;
        List<ParcelaDividasModel> parcelas;
        int idEmpresa;

        public frmNovo(int idEmp, frmFluxoCaixa frmFlux , frmPaga frmDiv)
        {
            InitializeComponent();
            idEmpresa = idEmp;
            frmDividas = frmDiv;
            frmFluxoCaixa = frmFlux;
            parcelas = new List<ParcelaDividasModel>();
            frmDividas.Resize += new EventHandler(this.frmDividas_Resize);
            montarColunas();
        }

        public void frmDividas_Resize(object sender, EventArgs e)
        {
            this.WindowState = frmDividas.WindowState;

        }

        public void montarColunas()
        {
            lstParcelas.Columns.Add("Parcela", -2);
            lstParcelas.Columns.Add("Valor Parcela", -2);
            lstParcelas.Columns.Add("Data Parcela", -2);
            lstParcelas.Columns.Add("Pago", -2);

            lstParcelas.View = View.Details;
            lstParcelas.FullRowSelect = true;
        }

        private void btnAddParcela_Click(object sender, EventArgs e)
        {
            int qtdPar = (int)qtdParc.Value;
            decimal valorTotal = decimal.Parse(txtValorTotal.Text);
            decimal valorParcela = valorTotal / qtdPar;
            DateTime data1Parcela = dtPriParcela.Value;

            for (int i = 1; i <= qtdPar; i++)
            {
            ParcelaDividasModel parcela = new ParcelaDividasModel();
                String[] row = {
                            i.ToString(),
                            valorParcela.ToString("C"),
                            data1Parcela.AddMonths(i-1).ToString("dd/MM/yyyy"),
                            "Não"
                        };
                ListViewItem item = new ListViewItem(row);
                lstParcelas.Items.Add(item);

                parcela.idEmpresa = idEmpresa;
                parcela.parcela = i.ToString();
                parcela.valorParcela = valorParcela;
                parcela.pago = 0;
                parcela.dataParcela = data1Parcela.AddMonths(i - 1);

                parcelas.Add(parcela);
            }
            lstParcelas.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lstParcelas.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            
            DividaService dividaService = new DividaService();
            DividasModel dividas = new DividasModel();
            dividas.divida = txtParcela.Text;
            dividas.pago = 0;
            dividas.observacao = txtObservacao.Text;
            dividas.tipoDivida = cbTipoDivida.SelectedIndex;
            dividas.valorTotal = txtValorTotal.Text == "" ? 0 :decimal.Parse(txtValorTotal.Text);
            dividas.dataCriacao = DateTime.Now;
            dividas.parcelaDividas = parcelas;

            string validacao = validarDados(dividas);

            if(validacao != "")
            {
                MessageBox.Show(validacao);
                return;
            }

            bool success = dividaService.inDivida(idEmpresa, dividas);


            if (success)
            {
                MessageBox.Show("Pedido Gravado com Sucesso");
                voltar();
            }
            else
            {
                MessageBox.Show("Erro ao Gravar Pedido");
            }
        }

        public string validarDados(DividasModel dividas)
        {
            string mensagem = "";
            if (dividas.divida is null)
            {
                mensagem += "***Nome da Divida não Escolhidos***\r\n\r\n";
            }
            if (dividas.valorTotal == 0)
            {
                mensagem += "***Valor Total igual a 0***\r\n\r\n";
            }
            return mensagem;
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

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            voltar();
        }

        private void txtValorTotal_GotFocus(object sender, EventArgs e)
        {
            txtValorTotal.Text = "";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            parcelas.Clear();
            lstParcelas.Items.Clear();
        }
    }
}
