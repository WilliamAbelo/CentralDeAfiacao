using descktop.Data;
using descktop.Services;
using descktop.Views.FluxoCaixa;
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
    public partial class frmReceb : Form
    {
        int idEmpresa;
        DateTime ultimoInicio;
        frmFluxoCaixa frmFluxoCaixa;
        public frmReceb(int idEmp, frmFluxoCaixa frmFlu)
        {
            idEmpresa = idEmp;
            frmFluxoCaixa = frmFlu;
            InitializeComponent();
            frmFluxoCaixa.Resize += new EventHandler(this.frmFluxoCaixa_Resize);
            MontarListView();
            buscaReceb();
        }

        public void frmFluxoCaixa_Resize(object sender, EventArgs e)
        {
            this.WindowState = frmFluxoCaixa.WindowState;

        }
        public void buscaReceb()
        {
            int numeroSemanas = 6;
            ultimoInicio = DateTime.UtcNow;
            for (int i = 0; i < numeroSemanas; i++)
            {
                DateTime inicio = primeiroDiaSemana(ultimoInicio);
                DateTime final = ultimoDiaSemana(inicio);

                FCaixaService caixaService = new FCaixaService();
                RecebimentosModel recebimentos = new RecebimentosModel();
                recebimentos = caixaService.recebSemanais(idEmpresa, inicio, final);

                decimal totalSemana = 0;

                switch (i)
                {
                    case 0:
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
                            lstSem1.Items.Add(item);

                            totalSemana += parcela.valor;
                        }

                        lblSem1.Text = inicio.ToShortDateString() + " ate " + final.ToShortDateString();
                        lblTotSem1.Text = totalSemana.ToString("C");
                        break;
                    case 1:
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
                            lstSem2.Items.Add(item);

                            totalSemana += parcela.valor;
                        }

                        lblSem2.Text = inicio.ToShortDateString() + " ate " + final.ToShortDateString();
                        lblTotSem2.Text = totalSemana.ToString("C");
                        break;
                    case 2:
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
                            lstSem3.Items.Add(item);

                            totalSemana += parcela.valor;
                        }

                        lblSem3.Text = inicio.ToShortDateString() + " ate " + final.ToShortDateString();
                        lblTotSem3.Text = totalSemana.ToString("C");
                        break;
                    case 3:
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
                            lstSem4.Items.Add(item);

                            totalSemana += parcela.valor;
                        }

                        lblSem4.Text = inicio.ToShortDateString() + " ate " + final.ToShortDateString();
                        lblTotSem4.Text = totalSemana.ToString("C");
                        break;
                    case 4:
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
                            lstSem5.Items.Add(item);

                            totalSemana += parcela.valor;
                        }

                        lblSem5.Text = inicio.ToShortDateString() + " ate " + final.ToShortDateString();
                        lblTotSem5.Text = totalSemana.ToString("C");
                        break;
                    case 5:
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
                            lstSem6.Items.Add(item);

                            totalSemana += parcela.valor;
                        }

                        lblSem6.Text = inicio.ToShortDateString() + " ate " + final.ToShortDateString();
                        lblTotSem6.Text = totalSemana.ToString("C");
                        break;
                    default:
                        break;
                }

            }
        }

        public DateTime primeiroDiaSemana(DateTime dt)
        {
            var culture = System.Threading.Thread.CurrentThread.CurrentCulture;
            var diff = dt.DayOfWeek - culture.DateTimeFormat.FirstDayOfWeek;

            if (diff < 0)
            {
                diff += 7;
            }

            return dt.AddDays(-diff).Date;
        }

        public DateTime ultimoDiaSemana(DateTime dt)
        {
            ultimoInicio = dt.AddDays(7);
            return dt.AddDays(6);
        }

        public void MontarListView()
        {
            lstSem1.Columns.Add("Pedido", -2);
            lstSem1.Columns.Add("Cliente", -2);
            lstSem1.Columns.Add("Parcela", -2);
            lstSem1.Columns.Add("Valor", -2);
            lstSem1.Columns.Add("Data", -2);
            lstSem1.Columns.Add("Pago", -2);
            lstSem1.View = View.Details;
            lstSem1.FullRowSelect = true;

            lstSem2.Columns.Add("Pedido", -2);
            lstSem2.Columns.Add("Cliente", -2);
            lstSem2.Columns.Add("Parcela", -2);
            lstSem2.Columns.Add("Valor", -2);
            lstSem2.Columns.Add("Data", -2);
            lstSem2.Columns.Add("Pago", -2);
            lstSem2.View = View.Details;
            lstSem2.FullRowSelect = true;

            lstSem3.Columns.Add("Pedido", -2);
            lstSem3.Columns.Add("Cliente", -2);
            lstSem3.Columns.Add("Parcela", -2);
            lstSem3.Columns.Add("Valor", -2);
            lstSem3.Columns.Add("Data", -2);
            lstSem3.Columns.Add("Pago", -2);
            lstSem3.View = View.Details;
            lstSem3.FullRowSelect = true;

            lstSem4.Columns.Add("Pedido", -2);
            lstSem4.Columns.Add("Cliente", -2);
            lstSem4.Columns.Add("Parcela", -2);
            lstSem4.Columns.Add("Valor", -2);
            lstSem4.Columns.Add("Data", -2);
            lstSem4.Columns.Add("Pago", -2);
            lstSem4.View = View.Details;
            lstSem4.FullRowSelect = true;

            lstSem5.Columns.Add("Pedido", -2);
            lstSem5.Columns.Add("Cliente", -2);
            lstSem5.Columns.Add("Parcela", -2);
            lstSem5.Columns.Add("Valor", -2);
            lstSem5.Columns.Add("Data", -2);
            lstSem5.Columns.Add("Pago", -2);
            lstSem5.View = View.Details;
            lstSem5.FullRowSelect = true;

            lstSem6.Columns.Add("Pedido", -2);
            lstSem6.Columns.Add("Cliente", -2);
            lstSem6.Columns.Add("Parcela", -2);
            lstSem6.Columns.Add("Valor", -2);
            lstSem6.Columns.Add("Data", -2);
            lstSem6.Columns.Add("Pago", -2);
            lstSem6.View = View.Details;
            lstSem6.FullRowSelect = true;

            tbSemana.AutoScroll = true;


        }

    }
}
