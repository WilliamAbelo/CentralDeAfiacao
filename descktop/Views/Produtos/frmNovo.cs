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
    public partial class frmNovo : Form
    {
        frmInicio frmInicio;
        frmProduto frmProduto;
        int idEmpresa;
        int idCategoria;
        string localPath;
        string Resources;
        public frmNovo(int idEmp, frmInicio frmIni, frmProduto frmPrd)
        {
            frmInicio = frmIni;
            frmProduto = frmPrd;
            idEmpresa = idEmp;
            InitializeComponent();
            frmInicio.Resize += new EventHandler(this.frmInicio_Resize);
            localPath = Environment.CurrentDirectory;
            Resources = ConfigurationManager.AppSettings["Resources"];
            MontarChkListBox();
        }

        public void frmInicio_Resize(object sender, EventArgs e)
        {
            this.WindowState = frmInicio.WindowState;

        }
        public void MontarChkListBox()
        {
            lstCateg.Columns.Add("Código Categoria", -2);
            //lstCateg.Columns.Add("Código Empresa", -2);
            lstCateg.Columns.Add("Categoria", -2);
            //lstCateg.Columns.Add("Observações", -2);
            //lstCateg.Columns.Add("Data de Criação", -2);

            lstCateg.View = View.Details;
            lstCateg.FullRowSelect = true;

            CategoriaService categoriaService = new CategoriaService();
            List<CategoriasModel> lstCategorias = categoriaService.lsCategorias(1);


            foreach (CategoriasModel item in lstCategorias)
            {
                String[] row = {
                    item.idCategoria.ToString(),
                    //item.idEmpresa.ToString(),
                    item.categoria,
                    //item.observacao,
                    //item.dataCriacao.ToString()
                };

                ListViewItem listViewItem = new ListViewItem(row);
                lstCateg.Items.Add(listViewItem);
            }
        }

        private void btnGravNovo_Click(object sender, EventArgs e)
        {
            ProdutosModel produto = new ProdutosModel();

            produto.idProduto = 0;
            produto.idEmpresa = idEmpresa;
            produto.produto = txtProd.Text;
            produto.valor = decimal.Parse(txtValor.Text == "" ? "0": txtValor.Text);
            produto.idCategoria = idCategoria;
            produto.ativo = 1;
            produto.observacao = txtObsProd.Text;
            produto.dataCriacao = DateTime.Now;
            produto.dataSync = DateTime.Now;

            var valido = validarDados(produto);
            if (valido != "")
            {
                var caption = "Preencha os Campos:";
                MessageBox.Show(valido, caption);

                return;
            }

            ProdutoService produtoService = new ProdutoService();
            bool success = produtoService.inProduto(1, produto);
            if (success)
            {                
                MessageBox.Show("Produto Criado com Sucesso");
                voltar();
                //frmInicio.pContainer.Controls.Clear();
                //frmProduto frmPro = new frmProduto(idEmpresa, frmInicio);
                //frmPro.TopLevel = false;
                //frmInicio.pContainer.Controls.Add(frmPro);
                //frmPro.Show();  
            } else
            {
                MessageBox.Show("Erro ao Alterar Produto");
            }
        }

        private void btnNovVoltar_Click(object sender, EventArgs e)
        {
            voltar();
            //frmInicio.pContainer.Controls.Clear();
            //frmProduto frmPro = new frmProduto(idEmpresa, frmInicio);
            //frmPro.TopLevel = false;
            //frmInicio.pContainer.Controls.Add(frmPro);
            //frmPro.WindowState = frmInicio.WindowState;
            //frmPro.Show();
        }

        //private void frmNovo_Load(object sender, EventArgs e)
        //{
        //    this.Anchor = (AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom);
        //}

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
                case 11:
                    File = "FresW.jpg";
                    break;
                case 9:
                    File = "Rol.jpg";
                    break;
                case 8:
                    File = "Reb.jpg";
                    break;
                case 3:
                    File = "Cab.jpg";
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

        private void lstCateg_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (lstCateg.SelectedItems.Count == 0)
                return;
            ListViewItem selecionado = lstCateg.SelectedItems[0];
            idCategoria = int.Parse(selecionado.SubItems[0].Text);
            lblCat.Text = selecionado.SubItems[1].Text;
            LoadNewPict(idCategoria);
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtValor.Text, "[^0-9.]"))
            {
                txtValor.Text = txtValor.Text.Remove((txtValor.Text.Length - 1), 1);
                txtValor.SelectionStart = txtValor.Text.Length;
            }
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
