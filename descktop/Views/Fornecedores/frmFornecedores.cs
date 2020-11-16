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
    public partial class frmFornecedores : Form
    {
        frmInicio frmInicio;
        public frmFornecedores(frmInicio frmIn)
        {
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
    }
}
