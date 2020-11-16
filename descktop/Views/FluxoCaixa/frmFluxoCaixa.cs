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

namespace descktop.Views.FluxoCaixa
{
    public partial class frmFluxoCaixa : Form
    {
        int idEmpresa;
        frmInicio frmInicio;
        public frmFluxoCaixa(int idEmp, frmInicio frmIn)
        {
            frmInicio = frmIn;
            InitializeComponent();
            frmInicio.Resize += new EventHandler(this.frmInicio_Resize);
            this.WindowState = frmIn.WindowState;
            montarList();
            idEmpresa = idEmp;
            buscarRecebimentos();
        }
        public void frmInicio_Resize(object sender, EventArgs e)
        {
            this.WindowState = frmInicio.WindowState;

        }

        //public void frmInicio_Resize(object sender, EventArgs e)
        //{
        //    switch (frmInicio.WindowState)
        //    {
        //        case FormWindowState.Normal:
        //            this.WindowState = FormWindowState.Normal;
        //            break;
        //        case FormWindowState.Minimized:
        //            this.WindowState = FormWindowState.Maximized;
        //            break;
        //        case FormWindowState.Maximized:
        //            this.WindowState = FormWindowState.Maximized;
        //            break;
        //        default:
        //            break;
        //    }
        //}

        private void btnPaga_Click_1(object sender, EventArgs e)
        {
            this.pcFluxo.Controls.Clear();
            frmPaga frmPg = new frmPaga(idEmpresa, this);
            frmPg.TopLevel = false;
            frmPg.WindowState = this.WindowState;
            this.pcFluxo.Controls.Add(frmPg);
            frmPg.Show();
        }

        private void btnReceb_Click_1(object sender, EventArgs e)
        {
            this.pcFluxo.Controls.Clear();
            frmReceb frmRec = new frmReceb(idEmpresa, this);
            frmRec.TopLevel = false;
            frmRec.WindowState = this.WindowState;
            this.pcFluxo.Controls.Add(frmRec);
            frmRec.Show();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {

        }

        public void montarList()
        {
            lstReceb.Columns.Add("Pedido", -2);
            lstReceb.Columns.Add("Cliente", -2);
            lstReceb.Columns.Add("Parcela", -2);
            lstReceb.Columns.Add("Valor", -2);
            lstReceb.Columns.Add("Data Parcela", -2);
            lstReceb.Columns.Add("Pago", -2);
            lstReceb.View = View.Details;
            lstReceb.FullRowSelect = true;
            lstReceb.GridLines = true;

            lstPag.Columns.Add("Nome da Despesa", -2);
            lstPag.Columns.Add("Valor", -2);
            lstPag.Columns.Add("Data Vencimento", -2);
            lstPag.Columns.Add("Data Pagamento", -2);
            lstPag.Columns.Add("Pago", -2);
            lstPag.View = View.Details;
            lstPag.FullRowSelect = true;
        }

        public void buscarRecebimentos()
        {
            FCaixaService fCaixaService = new FCaixaService();

            RecebimentosModel recebimentos = fCaixaService.recebSemanais(idEmpresa, new DateTime(), DateTime.Now.AddYears(1));

            foreach (var parcela in recebimentos.parcelas)
            {
                String[] row = {
                                parcela.idPedido.ToString(),
                                parcela.cliente,
                                parcela.parcela,
                                parcela.valor.ToString("C"),
                                parcela.dataParcela.ToShortDateString(),
                                parcela.pago.ToString()
                            };

                ListViewItem item = new ListViewItem(row);
                if(row[5] == "1")
                {
                    item.BackColor = Color.FromArgb(152,251,152); //verde
                } else if(parcela.dataParcela < DateTime.Now)
                {
                    item.BackColor = Color.FromArgb(219, 112, 147); //vermelho
                } else
                {
                    item.BackColor = Color.FromArgb(175, 238, 238); //azul
                }
                lstReceb.Items.Add(item);

            }
        }
    }
}
