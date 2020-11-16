using descktop.Data;
using descktop.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace descktop.Views.Configuracao
{
    public partial class frmDB : Form
    {

        DBService DBService;
        frmInicio frmInicio;
        public frmDB(frmInicio frmIn)
        {
            DBService = new DBService();
            frmInicio = frmIn;
            InitializeComponent();
            frmInicio.Resize += new EventHandler(this.frmInicio_Resize);
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

        private void btnExecutarQuery_Click(object sender, EventArgs e)
        {
            lstDB.Clear();
            DBModel result = DBService.executarQuery(txtQuery.Text);
            if(result == null)
            {
                return;
            }

            montarColuna(result.colunas.nome);

            foreach (Linha linha in result.linhas.linhas)
            {
                List<string> row = new List<string>(); ;
                foreach (var valor in linha.item)
                {
                    row.Add(valor);
                }              

                ListViewItem item = new ListViewItem(row.ToArray());
                lstDB.Items.Add(item);
            }
            lstDB.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        public void montarColuna(List<string> colunas)
        {
            foreach (var coluna in colunas)
            {

                lstDB.Columns.Add(coluna, -2);
            }

            lstDB.View = View.Details;
            lstDB.FullRowSelect = true;            
        }

        private void btnBck_Click(object sender, EventArgs e)
        {
            bool result = DBService.backUp();

            MessageBox.Show("Comando Executado Com Sucesso");

        }

        private void btnProp_Click(object sender, EventArgs e)
        {
            DBService.propriedadesDB();
        }
    }
}
