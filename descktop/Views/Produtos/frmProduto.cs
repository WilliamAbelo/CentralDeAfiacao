using descktop.Data;
using descktop.Services;
using descktop.Views.Produtos;
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
    public partial class frmProduto : Form
    {
        frmInicio frmInicio;
        int idEmpresa;
        int idProduto;
        List<int> idCat;
        public frmProduto(int idEmp, frmInicio frmIn)
        {
            idCat = new List<int> { 4 };
            frmInicio = frmIn;
            idEmpresa = idEmp;
            InitializeComponent();
            frmInicio.Resize += new EventHandler(this.frmInicio_Resize);
            montarListView();
            buscarProdutos(idCat); //o primeiro a ser montado é a serra circular
        }
        public void frmInicio_Resize(object sender, EventArgs e)
        {
            this.WindowState = frmInicio.WindowState;

        }

        public void montarListView()
        {
            listProd.Columns.Add("Código Produto", -2);
            listProd.Columns.Add("Código Empresa", -2);
            listProd.Columns.Add("Produto", -2);
            listProd.Columns.Add("Código Categoria", -2);
            listProd.Columns.Add("Valor Unitário", -2);
            listProd.Columns.Add("Observação", -2);
            listProd.Columns.Add("Ultima Edição", -2);
            listProd.View = View.Details;
            listProd.FullRowSelect = true;
        }
        private void btnNovoEst_Click(object sender, EventArgs e)
        {
            frmInicio.pContainer.Controls.Clear();
            frmNovo formNov = new frmNovo(idEmpresa, frmInicio, this);
            formNov.TopLevel = false;
            frmInicio.pContainer.Controls.Add(formNov);
            formNov.WindowState = frmInicio.WindowState;
            formNov.Show();
        }
        public void buscarProdutos(List<int> idCat, string nome = "")
        {
            ProdutoService produtoService = new ProdutoService();

            List<ProdutosModel> lstProdutos = produtoService.lsProdutos(idEmpresa, idCat);

            foreach (ProdutosModel item in lstProdutos)
            {

                if(nome != "" && item.produto.ToLower().Contains(nome.ToLower()))
                {
                    String[] row = {
                    item.idProduto.ToString(),
                    item.idEmpresa.ToString(),
                    item.produto,
                    item.idCategoria.ToString(),
                    item.valor.ToString("C"),
                    item.observacao,
                    item.dataSync.ToString()
                    };

                    ListViewItem itemList = new ListViewItem(row);
                    listProd.Items.Add(itemList);
                } else if(nome == "")
                {

                    String[] row = {
                    item.idProduto.ToString(),
                    item.idEmpresa.ToString(),
                    item.produto,
                    item.idCategoria.ToString(),
                    item.valor.ToString("C"),
                    item.observacao,
                    item.dataSync.ToString()
                    };

                    ListViewItem itemList = new ListViewItem(row);
                    listProd.Items.Add(itemList);
                }
            }
            listProd.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void btnVisualizarEst_Click(object sender, EventArgs e)
        {
            frmInicio.pContainer.Controls.Clear();
            frmDetalhes formDet = new frmDetalhes(idEmpresa, idProduto, frmInicio, this);
            formDet.TopLevel = false;
            frmInicio.pContainer.Controls.Add(formDet);
            formDet.WindowState = frmInicio.WindowState;
            formDet.Show();
        }

        private void listProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listProd.SelectedItems.Count == 0)
                return;

            ListViewItem item = listProd.SelectedItems[0];
            idProduto = int.Parse(item.SubItems[0].Text);
        }

        private void ctrListaProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            idCat = new List<int>();
            //listProd.Items.Clear();
            //listProd.Columns.Clear();
            listProd.Clear();
            switch (ctrListaProd.SelectedIndex)
            {
                case 0: //Serra Circular
                    idCat.Add(4);
                    tbSC.Controls.Add(listProd);
                    break;
                case 1: //Serra Fita
                    idCat.Add(2);
                    tbSF.Controls.Add(listProd);
                    break;
                case 2: //Facas de Aço
                    idCat.Add(6);
                    tbFA.Controls.Add(listProd);
                    break;
                case 3: //Facas de Widea
                    idCat.Add(7);
                    tbFW.Controls.Add(listProd);
                    break;
                case 4: //Fresas de Aço
                    idCat.Add(1);
                    tbFreA.Controls.Add(listProd);
                    break;
                case 5: //Fresas de Widea
                    idCat.Add(11); //ainda nao tem essa categoria
                    tbFreW.Controls.Add(listProd);
                    break;
                case 6: //rebolos,roletes, cabeçotes
                    idCat.Add(3);
                    idCat.Add(8);
                    idCat.Add(9);
                    tbReb.Controls.Add(listProd);
                    break;
                default: //outros produtos
                    idCat.Add(12);
                    tbOut.Controls.Add(listProd);
                    break;
            }
            montarListView();
            buscarProdutos(idCat);
        }

        private void btnExcluirEst_Click(object sender, EventArgs e)
        {
            if (listProd.SelectedItems.Count == 0)
                return;
            ListViewItem item = listProd.SelectedItems[0];
            int idProduto = int.Parse(item.SubItems[0].Text);

            string message = "Confirma a Exclusão do Produto?";
            string caption = "Excluir Produto";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
            if (result == DialogResult.Yes)
            {
                ProdutoService produtoService = new ProdutoService();
                bool success = produtoService.deProduto(idEmpresa, idProduto);

                if (success)
                {
                    MessageBox.Show("Produto Excluido com Sucesso");

                    frmInicio.pContainer.Controls.Clear();
                    frmProduto frmPro = new frmProduto(idEmpresa, frmInicio);
                    frmPro.TopLevel = false;
                    frmInicio.pContainer.Controls.Add(frmPro);
                    frmPro.WindowState = frmInicio.WindowState;
                    frmPro.Show();
                }
                else
                {
                    MessageBox.Show("Erro ao Excluir Produto");
                }
            }
        }
        private void btnBuscaNom_Click_1(object sender, EventArgs e)
        {
            listProd.Items.Clear();
            buscarProdutos(idCat, TxtBuscaNom.Text);
        }
    }
}
