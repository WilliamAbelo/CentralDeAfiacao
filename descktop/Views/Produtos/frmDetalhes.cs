using descktop.Data;
using descktop.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace descktop.Views.Produtos
{
    public partial class frmDetalhes : Form
    {
        frmInicio frmInicio;
        frmProduto frmProduto;
        int idEmpresa;
        int idCategoria;
        int idProduto; 
        string localPath;
        string Resources;

        public frmDetalhes(int idEmp, int idProd, frmInicio frmIni, frmProduto frmPrd)
        {
            frmInicio = frmIni;
            frmProduto = frmPrd;
            idEmpresa = idEmp;
            idProduto = idProd;
            InitializeComponent();
            frmInicio.Resize += new EventHandler(this.frmInicio_Resize);
            localPath = Environment.CurrentDirectory;
            Resources = ConfigurationManager.AppSettings["Resources"];
            MontarChkListBox();
            BuscaProd(idEmp, idProd);
        }

        public void frmInicio_Resize(object sender, EventArgs e)
        {
            this.WindowState = frmInicio.WindowState;

        }

        public void MontarChkListBox()
        {
            lstCateg.Columns.Add("Código Categoria", -2);
            lstCateg.Columns.Add("Código Empresa", -2);
            lstCateg.Columns.Add("Categoria", -2);
            lstCateg.Columns.Add("Observações", -2);
            lstCateg.Columns.Add("Data de Criação", -2);

            lstCateg.View = View.Details;
            lstCateg.FullRowSelect = true;

            CategoriaService categoriaService = new CategoriaService();
            List<CategoriasModel> lstCategorias = categoriaService.lsCategorias(1);


            foreach (CategoriasModel item in lstCategorias)
            {
                String[] row = {
                    item.idCategoria.ToString(),
                    item.idEmpresa.ToString(),
                    item.categoria,
                    item.observacao,
                    item.dataCriacao.ToString()
                };

                ListViewItem listViewItem = new ListViewItem(row);
                lstCateg.Items.Add(listViewItem);
            }
        }

        //private void btnCriarCat_Click_1(object sender, EventArgs e)
        //{
        //    if (txtCat.Text == "")
        //    {
        //        MessageBox.Show("Insira um nome de no campo 'Nome' para criar uma nova categoria");
        //    }
        //    else
        //    {
        //        CategoriaService categoriaService = new CategoriaService();
        //        CategoriasModel categoria = new CategoriasModel();

        //        categoria.categoria = txtCat.Text;
        //        categoria.observacao = txtObsCat.Text;
        //        categoria.dataCriacao = DateTime.Now;
        //        categoria.unidade = cbUnidade.SelectedItem.ToString();
        //        categoria.idEmpresa = 1;

        //        categoriaService.inCategoria(1, categoria);

        //        lstCateg.Items.Clear();
        //        MontarChkListBox();
        //    }
        //}

        private void BuscaProd(int idEmp, int idProd)
        {
            ProdutoService produtoService = new ProdutoService();
            ProdutosModel produto = new ProdutosModel();

            produto = produtoService.seProdutos(idEmp, idProd);

            PopularTxt(produto);
        }

        public void PopularTxt(ProdutosModel produto)
        {

            txtProd.Text = produto.produto;
            txtValor.Text = produto.valor.ToString();
            txtObsProd.Text = produto.observacao;
            idCategoria = produto.idCategoria;
            LoadNewPict(idCategoria);

            for (int i = 0; i < lstCateg.Items.Count; i++)
            {
                if (produto.idCategoria.ToString() == lstCateg.Items[i].SubItems[0].Text)
                {
                    lblCat.Text = lstCateg.Items[i].SubItems[2].Text;
                }
            }
        }

        private void btnAltProd_Click(object sender, EventArgs e)
        {
            ProdutoService produtoService = new ProdutoService();
            ProdutosModel produto = new ProdutosModel();

            produto.idProduto = idProduto;
            produto.idEmpresa = idEmpresa;
            produto.produto = txtProd.Text;
            produto.valor = decimal.Parse(txtValor.Text == "" ? "0" : txtValor.Text);
            produto.idCategoria = idCategoria;
            produto.observacao = txtObsProd.Text;
            produto.dataSync = DateTime.Now;

            var valido = validarDados(produto);
            if (valido != "")
            {
                var caption = "Preencha os Campos:";
                MessageBox.Show(valido, caption);

                return;
            }

            bool success = produtoService.upProduto(1, idProduto, produto);
            if (success)
            {
                MessageBox.Show("Produto Alterado com Sucesso");
                voltar();
                //frmInicio.pContainer.Controls.Clear();
                //frmProduto frmPro = new frmProduto(idEmpresa, frmInicio);
                //frmPro.TopLevel = false;
                //frmInicio.pContainer.Controls.Add(frmPro);
                //frmPro.Show();
            }
            else
            {
                MessageBox.Show("Erro ao Alterar Produto");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
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
                    voltar();
                    //frmInicio.pContainer.Controls.Clear();
                    //frmProduto frmPro = new frmProduto(idEmpresa, frmInicio);
                    //frmPro.TopLevel = false;
                    //frmInicio.pContainer.Controls.Add(frmPro);
                    //frmPro.Show();
                }
                else
                {
                    MessageBox.Show("Erro ao Excluir Produto");
                }
            }
        }

        private void LoadNewPict(int idCat)
        {
            // You should replace the bold image
            // in the sample below with an icon of your own choosing.  
            // Note the escape character used (@) when specifying the path.  
            string File = "Etc.jpg";

            switch (idCat)
            {
                case 4:
                    File = "SerrC.jpg";
                    break;
                case 2:
                    File = "SerrF.jpg";
                    break;
                case 6:
                    File = "FacA.jpg";
                    break;
                case 7:
                    File = "FacW.jpg";
                    break;
                case 1:
                    File = "FresA.jpg";
                    break;
                case 5:
                    File = "FresW.jpg";
                    break;
                case 8:
                    File = "Reb.jpg";
                    break;
                case 9:
                    File = "Rol.jpg";
                    break;
                default:
                    File = "Etc.jpg";
                    break;
            }

            pictureBox1.Image = Image.FromFile(localPath + Resources + File);
        }

        public string validarDados(ProdutosModel produto)
        {
            string mensagem = "";

            if (produto.produto == "")
            {

                mensagem += "***Nome do Produto***\r\n\r\n";
            }
            if (produto.valor is 0)
            {
                mensagem += "***Valor***\r\n\r\n"; ;
            }
            if (produto.idCategoria == 0)
            {
                mensagem += "***Categoria***\r\n\r\n"; ;
            }

            return mensagem;
        }

        private void txtValor_GotFocus(object sender, EventArgs e)
        {
            txtValor.Clear();
        }

        private void btnNovVoltar_Click_1(object sender, EventArgs e)
        {
            voltar();
            //frmInicio.pContainer.Controls.Clear();
            //frmProduto frmPro = new frmProduto(idEmpresa, frmInicio);
            //frmPro.TopLevel = false;
            //frmInicio.pContainer.Controls.Add(frmPro);
            //frmPro.WindowState = frmInicio.WindowState;
            //frmPro.Show();
        }

        private void lstCateg_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCateg.SelectedItems.Count == 0)
                return;
            ListViewItem selecionado = lstCateg.SelectedItems[0];
            idCategoria = int.Parse(selecionado.SubItems[0].Text);
            lblCat.Text = selecionado.SubItems[2].Text;
            LoadNewPict(idCategoria);
        }

        public void voltar()
        {
            frmInicio.pContainer.Controls.Clear();
            frmProduto frmPro = new frmProduto(idEmpresa, frmInicio);
            frmPro.TopLevel = false;
            frmInicio.pContainer.Controls.Add(frmPro);
            frmPro.WindowState = frmInicio.WindowState;
            frmPro.Show();
        }
    }
}
