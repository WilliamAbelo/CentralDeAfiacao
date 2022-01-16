using descktop.Data;
using descktop.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace descktop.Views.Vendas
{
    public partial class frmNovo : Form
    {
        frmInicio frmInicio;
        frmPedidos frmPedidos;
        string idItem;
        decimal valorTotal;
        decimal valorParcialItens;
        decimal valorDesconto;
        decimal valorFrete;
        int idEmpresa;
        CondicoesModel condicoes = new CondicoesModel();
        ClientesModel cliente = new ClientesModel();
        ProdutosCarrinho produtos = new ProdutosCarrinho();
        FreteModel frete = new FreteModel();
        string etiquetaCliente;
        string estado;
        List<int> idCat;
        PrintDocument document = new PrintDocument();
        PrintDialog dialog = new PrintDialog();
        public frmNovo(int idEmp, frmInicio frmIni, frmPedidos frmPed)
        {
            idCat = new List<int> { 4 };
            estado = " = 'AC'";
            frmInicio = frmIni;
            frmPedidos = frmPed;
            idEmpresa = idEmp;
            produtos.produtos = new List<ProdutosCesta>();
            condicoes.parcelas = new List<CondicaoParcelas>();
            InitializeComponent();
            frmInicio.Resize += new EventHandler(this.frmInicio_Resize);
            montarColunas();
            BuscarLista(estado);
            document.PrintPage += new PrintPageEventHandler(document_PrintPage);
            tbAC.Controls.Add(lstCli);
        }

        public void frmInicio_Resize(object sender, EventArgs e)
        {
            this.WindowState = frmInicio.WindowState;

        }

        public void montarColunas()
        {
            lstItensPedidos.Columns.Add("Código Produto", -2);
            lstItensPedidos.Columns.Add("Produto", -2);
            lstItensPedidos.Columns.Add("Quantidade", -2);
            lstItensPedidos.Columns.Add("Valor Unitario", -2);
            lstItensPedidos.Columns.Add("Valor Desconto", -2);
            lstItensPedidos.Columns.Add("Valor Parcial", -2);

            lstItensPedidos.View = View.Details;
            lstItensPedidos.FullRowSelect = true;



            listProd.Columns.Add("Código Produto", -2);
            listProd.Columns.Add("Código Empresa", -2);
            listProd.Columns.Add("Produto", -2);
            listProd.Columns.Add("Código Categoria", -2);
            listProd.Columns.Add("Valor Unitário", -2);
            listProd.Columns.Add("Observação", -2);
            listProd.Columns.Add("Ultima Edição", -2);
            //listProd.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listProd.View = View.Details;
            listProd.FullRowSelect = true;



            lstCond.Columns.Add("Parcela", -2);
            lstCond.Columns.Add("Valor", -2);
            lstCond.Columns.Add("Forma da Parcela", -2);
            lstCond.Columns.Add("Data", -2);
            lstCond.Columns.Add("Pago", -2);
            lstCond.Columns.Add("Data do Pagamento", -2);
            lstCond.View = View.Details;
            lstCond.FullRowSelect = true;


            lstCli.Columns.Add("idCliente", -2);
            lstCli.Columns.Add("idEmpresa", -2);
            lstCli.Columns.Add("Cliente", -2);
            lstCli.Columns.Add("Responsavel", -2);
            lstCli.Columns.Add("Telefone", -2);
            lstCli.Columns.Add("Email", -2);
            lstCli.Columns.Add("Endereço", -2);
            lstCli.Columns.Add("Numero", -2);
            lstCli.View = View.Details;
            lstCli.FullRowSelect = true;


            cbPgEnt.Items.Add("Dinheiro");
            cbPgEnt.Items.Add("Cartão");
            cbPgEnt.Items.Add("Boleto");
            cbPgEnt.Items.Add("Cheque");
            cbPgEnt.Items.Add("Depósito");
            cbPgEnt.SelectedIndex = 0;

            cbPgPar.Items.Add("Dinheiro");
            cbPgPar.Items.Add("Cartão");
            cbPgPar.Items.Add("Boleto");
            cbPgPar.Items.Add("Cheque");
            cbPgPar.Items.Add("Depósito");
            cbPgPar.SelectedIndex = 0;
        }


        private void btnNovVoltar_Click(object sender, EventArgs e)
        {
            voltar();
            //frmInicio.pContainer.Controls.Clear();
            //frmPedidos frmPed = new frmPedidos(idEmpresa, frmInicio);
            //frmPed.TopLevel = false;
            //frmInicio.pContainer.Controls.Add(frmPed);
            //frmPed.WindowState = frmInicio.WindowState;
            //frmPed.Show();
        }

        public void montarItens(List<int> idCat, string nome = "")
        {

            ProdutoService produtoService = new ProdutoService();

            List<ProdutosModel> lstProdutos = produtoService.lsProdutos(idEmpresa, idCat);

            foreach (ProdutosModel item in lstProdutos)
            {
                if (nome != "" && item.produto.ToLower().Contains(nome.ToLower()))
                {
                    String[] row = {
                    item.idProduto.ToString(),
                    item.idEmpresa.ToString(),
                    item.produto,
                    item.idCategoria.ToString(),
                    item.valor.ToString(),
                    item.observacao,
                    item.dataSync.ToString()
                    };

                    ListViewItem itemList = new ListViewItem(row);
                    listProd.Items.Add(itemList);
                }
                else if (nome == "")
                {
                    String[] row = {
                    item.idProduto.ToString(),
                    item.idEmpresa.ToString(),
                    item.produto,
                    item.idCategoria.ToString(),
                    item.valor.ToString(),
                    item.observacao,
                    item.dataSync.ToString()
                    };

                    ListViewItem itemList = new ListViewItem(row);
                    listProd.Items.Add(itemList);
                }

            }
            listProd.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void listProd_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            idItem = null;
            numNovoQuantidade.Value = 1;
            numNovoQuantidade.DecimalPlaces = 0;
            numNovoQuantidade.Increment = 1;
            txtDesc.Text = "0.00";
            lblQtd.Text = "Qtd";
            if (listProd.SelectedItems.Count == 0)
                return;

            ListViewItem item = listProd.SelectedItems[0];

            int idCategoria = int.Parse(item.SubItems[3].Text);

            CategoriasModel categoriasModel = new CategoriasModel();
            CategoriaService categoriaService = new CategoriaService();
            categoriasModel = categoriaService.seCategorias(idEmpresa, idCategoria);


            if (categoriasModel.unidade is "Metros") //2 é a categoria de Serra fita
            {
                numNovoQuantidade.DecimalPlaces = 2;
                numNovoQuantidade.Increment = 0.1M;
                lblQtd.Text = "Mts";
            }

            idItem = item.SubItems[0].Text;
            txtNovoProdutoEsco.Text = item.SubItems[2].Text;
            txtValorUnitario.Text = item.SubItems[4].Text;
            txtTotProd.Text = (numNovoQuantidade.Value * decimal.Parse(txtValorUnitario.Text)).ToString();
        }

        private void btnAddProd_Click(object sender, EventArgs e)
        {
            decimal valorUni = decimal.Parse(txtValorUnitario.Text);
            decimal valorDesc = decimal.Parse(txtDesc.Text);
            decimal valorTotPro = decimal.Parse(txtTotProd.Text);
            //valorUni = valorUni.Substring(3);

            if (valorTotPro < valorDesc)
            {
                var caption = "Erro no Desconto ";
                MessageBox.Show("Valor do Desconto '''Maior''' que o Valor Total do Item", caption);
                return;
            }
            if (txtNovoProdutoEsco.Text == "" || idItem == "")
            {
                var caption = "Erro ao Adicionar Produto";
                MessageBox.Show("Selecione um '''Produto''' para Adicionar", caption);
                return;
            }


            decimal valorParcial = numNovoQuantidade.Value * valorUni;
            valorParcial = valorParcial - valorDesc;


            String[] row = {
                idItem,
                txtNovoProdutoEsco.Text,
                numNovoQuantidade.Value.ToString(),
                valorUni.ToString("C"),
                valorDesc.ToString("C"),
                valorParcial.ToString("C")
            };

            valorTotal += valorParcial;

            ListViewItem itemList = new ListViewItem(row);
            lstItensPedidos.Items.Add(itemList);

            ProdutosCesta produtosCesta = new ProdutosCesta();
            ProdutosModel produto = new ProdutosModel();
            produto.idProduto = int.Parse(row[0]);
            produto.idEmpresa = 1;
            produto.idCategoria = 1;
            produto.produto = row[1];
            produto.valor = valorUni;

            produtosCesta.produto = produto;
            produtosCesta.quantidade = numNovoQuantidade.Value;
            produtosCesta.valorTotal = valorParcial;
            produtosCesta.desconto = valorDesc;
            //produtosCesta.desconto = int.Parse(row[4]);

            produtos.produtos.Add(produtosCesta);
            valorParcialItens += valorParcial + decimal.Parse(txtDesc.Text); ;
            valorDesconto += decimal.Parse(txtDesc.Text);

            txtDesc.Text = "0.00";
            txtNovoProdutoEsco.Clear();
            txtValorUnitario.Text = "0.00";
            numNovoQuantidade.Value = 1;

            lstItensPedidos.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            Totallbl(valorTotal, valorParcialItens, valorFrete, valorDesconto);
        }

        private void btnAddCli_Click(object sender, EventArgs e)
        {
            if (txtCliEsco.Text == "")
            {
                var caption = "Erro ao Adicionar Cliente";
                MessageBox.Show("Selecione um '''Cliente''' para Adicionar", caption);
                return;
            }
            lblCliente.Text = txtCliEsco.Text;
            label7.Text = txtCliEsco.Text;
            lblCli.Text = txtCliEsco.Text;
            lblFrecliente.Text = txtCliEsco.Text;

            if (lstCli.SelectedItems.Count == 0)
                return;

            ListViewItem item = lstCli.SelectedItems[0];

            ClienteService clienteService = new ClienteService();

            ClientesModel clientesModel = clienteService.seCliente(idEmpresa, int.Parse(item.SubItems[0].Text));

            cliente.idCliente = clientesModel.idCliente;
            cliente.idEmpresa = clientesModel.idEmpresa;
            cliente.nome = clientesModel.nome;
            cliente.responsavel = clientesModel.responsavel;
            cliente.telefone = clientesModel.telefone;
            cliente.email = clientesModel.email;
            cliente.endereco = clientesModel.endereco;
            cliente.numero = clientesModel.numero;
            cliente.complemento = clientesModel.complemento;
            cliente.bairro = clientesModel.bairro;
            cliente.cidade = clientesModel.cidade;
            cliente.estado = clientesModel.estado;
            cliente.CEP = clientesModel.CEP;
            cliente.ativo = clientesModel.ativo;

            //84 caracteres
            etiquetaCliente = cliente.nome;
            etiquetaCliente += cliente.responsavel == "" ? "" : "\r\nA/C: " + cliente.responsavel;
            etiquetaCliente += "\r\n\r\nEndereço: " + cliente.endereco + ", " + cliente.numero;
            etiquetaCliente += cliente.complemento == "" ? "" : "\r\nComplemento: " + cliente.complemento;
            etiquetaCliente += "\r\nCEP: " + cliente.CEP;
            etiquetaCliente += cliente.bairro == "" ? "" : "\r\nBairro: " + cliente.bairro;
            etiquetaCliente += "\r\nCidade: " + cliente.cidade + " - " + cliente.estado;

            txtEtiq.Text = etiquetaCliente;
            txtEtiq.ScrollBars = ScrollBars.Vertical;

            frete.idCliente = int.Parse(item.SubItems[0].Text);
            frete.CEP = cliente.CEP;

        }

        private void lstCli_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCli.SelectedItems.Count == 0)
                return;

            ListViewItem item = lstCli.SelectedItems[0];

            txtCliEsco.Text = item.SubItems[2].Text;

        }

        private void btnAddForm_Click(object sender, EventArgs e)
        {

            lstCond.Items.Clear();
            condicoes.parcelas.Clear();
            decimal entrada = txtValorEnt.Text == "" ? 0 : decimal.Parse(txtValorEnt.Text);
            int qtdPar = int.Parse(qtdParcelas.Value.ToString());
            DateTime dtEntrada = dtpEntrada.Value;
            string formaPgEnt = "";
            string formaPgPar = "";

            if ((valorTotal + valorFrete) > entrada && (qtdPar == 0))
            {
                var caption = "Erro nas Condições de Pagamento: ";
                MessageBox.Show("Não Existe Numero de Parcelas, Por Favor, Adicione Parcelas\r\n" +
                    "Pois, o Valor da Entrada é '''Menor''' que o Valor Total do Pedido", caption);
                return;
            }

            if ((valorTotal + valorFrete) < entrada)
            {
                var caption = "Erro nas Condições de Pagamento: ";
                MessageBox.Show("Valor da Entrada é '''Maior''' que o Valor Total do Pedido", caption);
                return;
            }
            if (((valorTotal + valorFrete) == entrada) && (qtdPar > 0))
            {
                var caption = "Erro nas Condições de Pagamento: ";
                MessageBox.Show("Impossivel adicionar parcelas, pois \r\n" +
                    "O Valor da Entrada '''é Igual''' ao Valor Total do Pedido", caption);
                return;
            }


            if (!(cbPgEnt.SelectedItem is null))
            {
                formaPgEnt = cbPgEnt.SelectedItem.ToString();
            }
            if (!(cbPgPar.SelectedItem is null))
            {
                formaPgPar = cbPgPar.SelectedItem.ToString();
            }

            decimal valorFim = (valorTotal + valorFrete) - entrada;

            string dtPagEnt = ""; ;
            if (dtEntrada <= DateTime.Now)
            {
                dtPagEnt = DateTime.Now.ToString("dd/MM/yyyy");
            }
            else if (dtEntrada > DateTime.Now)
            {
                dtPagEnt = "";
            }

            if (entrada > 0)
            {
                CondicaoParcelas parcela = new CondicaoParcelas();
                String[] row = {
                            "Entrada",
                            entrada.ToString("C"),
                            formaPgEnt,
                            dtEntrada.ToString("dd/MM/yyyy"),
                            dtPagEnt == ""? "Não": "Sim",
                            dtPagEnt
                        };
                ListViewItem item = new ListViewItem(row);
                lstCond.Items.Add(item);

                parcela.numeroParcela = row[0];
                parcela.valorParcela = entrada;
                parcela.formaPagamento = row[2];
                parcela.dataParcela = dtEntrada;
                parcela.pago = (row[4] == "Sim" ? 1 : 0);// int.Parse(row[4]);
                parcela.dataPagamento = dtEntrada;
                condicoes.parcelas.Add(parcela);
            }

            if (qtdPar > 0)
            {
                decimal vParcela = valorFim / qtdPar;

                for (int i = 0; i < qtdPar; i++)
                {
                    CondicaoParcelas parcela = new CondicaoParcelas();
                    DateTime dataParcela = dtEntrada.AddMonths(i + 1);

                    String[] row = {
                            (i+1).ToString(),
                            vParcela.ToString("C"),
                            formaPgPar,
                            dataParcela.ToString("dd/MM/yyyy"),
                            dataParcela > DateTime.Now? "Não": "Sim",
                            ""
                        };
                    ListViewItem item = new ListViewItem(row);
                    lstCond.Items.Add(item);

                    parcela.numeroParcela = row[0];
                    parcela.valorParcela = vParcela;
                    parcela.formaPagamento = row[2];
                    parcela.dataParcela = dtEntrada.AddMonths(i + 1);
                    parcela.pago = (row[4] == "Sim" ? 1 : 0);
                    //sem data de pagamento para as parcelas, pois ainda nao foram pagas
                    condicoes.parcelas.Add(parcela);
                }
            }
            lstCond.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lstCond.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }


        private void btnFecharPed_Click(object sender, EventArgs e)
        {

            valorTotal += valorFrete;
            //valorTotal -= valorDesconto;

            PedidosModel pedido = new PedidosModel();

            pedido.idPedido = 0;
            pedido.Produtos = produtos;
            pedido.cliente = cliente;
            pedido.dataVenda = DateTime.Now;
            pedido.desconto = valorDesconto;
            pedido.condicao = condicoes;
            pedido.frete = frete;
            pedido.valorTotal = valorTotal;
            pedido.observacao = txtObs.Text;

            var valido = validarDados(pedido);
            if (valido != "")
            {
                valorTotal -= valorFrete;
                var caption = "Erro no Preenchimento do Pedido: ";
                MessageBox.Show(valido, caption);

                return;
            }

            PedidoService pedidoService = new PedidoService();
            bool success = pedidoService.inPedido(idEmpresa, pedido);
            if (success)
            {
                MessageBox.Show("Pedido Gravado com Sucesso");
                voltar();
                //frmInicio.pContainer.Controls.Clear();
                //frmPedidos frmPed = new frmPedidos(idEmpresa, frmInicio);
                //frmPed.TopLevel = false;
                //frmInicio.pContainer.Controls.Add(frmPed);
                //frmPed.Show();
            }
            else
            {
                MessageBox.Show("Erro ao Gravar Pedido");
            }
        }


        public void Totallbl(decimal valTotal, decimal valProdutos, decimal valFrete, decimal valDesconto)
        {
            valTotal += valFrete;
            //valTotal -= valDesconto;
            string valorProdutos = valProdutos.ToString("C");
            string valorFrete = valFrete.ToString("C");
            string valorDesconto = valDesconto.ToString("C");
            string valorTotal = valTotal.ToString("C");

            //if (Tipo == 1) //Produtos
            //{
            lblValProdI.Text = valorProdutos;
            lblValProdC.Text = valorProdutos;
            lblValProdO.Text = valorProdutos;
            lblValProdF.Text = valorProdutos;
            //}
            //if (Tipo == 2) //Frete
            //{
            lblValFretI.Text = valorFrete;
            lblValFretC.Text = valorFrete;
            lblValFretO.Text = valorFrete;
            lblValFretF.Text = valorFrete;

            lblValDesI.Text = valorDesconto;
            lblValDesC.Text = valorDesconto;
            lblValDesO.Text = valorDesconto;
            lblValDesF.Text = valorDesconto;
            //}

            lblTotal.Text = valorTotal;
            lblTot2.Text = valorTotal;
            lblTotObs.Text = valorTotal;
            lblTotFre.Text = valorTotal;
        }
        private void btnAddFre_Click(object sender, EventArgs e)
        {

            //if (dtEnvio.Value.DayOfYear < DateTime.Now.DayOfYear)
            //{
            //    MessageBox.Show("Data de Envio Anterior da Data de Hoje.\r\n Selecione uma data maior que hoje");
            //}
            //else
            //{


            valorFrete = decimal.Parse(txtValFret.Text);


            lblValFre.Text = valorFrete.ToString("C");
            lblDtFre.Text = dtEnv.Value.ToShortDateString();

            frete.valorFrete = valorFrete;
            frete.dataEnvio = dtEnv.Value;
            if ((frete.dataEnvio <= DateTime.Now))
            {
                frete.enviado = 1;
            }
            else
            {
                frete.enviado = 0;
            }
            //}

            Totallbl(valorTotal, valorParcialItens, valorFrete, valorDesconto);

        }

        private void txtDesc_GotFocus(object sender, EventArgs e)
        {
            txtDesc.Clear();
        }

        private void txtValFret_GotFocus(object sender, EventArgs e)
        {

            txtValFret.Text = "";

        }

        private void txtValorEnt_GotFocus(object sender, EventArgs e)
        {

            txtValorEnt.Text = "";

        }

        //private void btnAddDesc_Click(object sender, EventArgs e)
        //{
        //    valorDesconto = decimal.Parse(txtDesc.Text);
        //    Totallbl(valorTotal, valorParcialItens, valorFrete, valorDesconto);
        //}
        private void ctrNovoPed_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ctrNovoPed.SelectedIndex)
            {
                case 0: //Clentes
                    lstCli.Items.Clear();
                    lblBusca.Text = "Nome do Cliente";
                    BuscarLista(estado);
                    break;
                case 1: //Produtos
                    listProd.Items.Clear();
                    lblBusca.Text = "Nome do Produto";
                    montarItens(idCat);
                    break;
                default:
                    break;
            }
        }

        private void ctrListaProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            idCat = new List<int>();
            //listProd.Items.Clear();
            //listProd.Columns.Clear();
            listProd.Items.Clear();
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
            montarItens(idCat);
        }


        public void PopularLista(List<ClientesModel> clientes, string nome = "")
        {


            foreach (ClientesModel cliente in clientes)
            {
                if (nome != "" && cliente.nome.ToLower().Contains(nome.ToLower()))
                {
                    String[] row = {
                    cliente.idCliente.ToString(),
                    cliente.idEmpresa.ToString(),
                    cliente.nome,
                    cliente.responsavel,
                    cliente.telefone,
                    cliente.email,
                    cliente.endereco,
                    cliente.numero,
                    cliente.ativo.ToString()
                    };

                    ListViewItem item = new ListViewItem(row);
                    lstCli.Items.Add(item);
                }
                else if (nome == "")
                {
                    String[] row = {
                    cliente.idCliente.ToString(),
                    cliente.idEmpresa.ToString(),
                    cliente.nome,
                    cliente.responsavel,
                    cliente.telefone,
                    cliente.email,
                    cliente.endereco,
                    cliente.numero,
                    cliente.ativo.ToString()
                    };

                    ListViewItem item = new ListViewItem(row);
                    lstCli.Items.Add(item);
                }
            }
            lstCli.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void ctrListaCli_SelectedIndexChanged(object sender, EventArgs e)
        {

            lstCli.Items.Clear();
            switch (ctrListaCli.SelectedIndex)
            {
                case 0: //AC
                    estado = " = 'AC'";
                    tbAC.Controls.Add(lstCli);
                    break;
                case 1: //AL
                    estado = " = 'AL'";
                    tbAL.Controls.Add(lstCli);
                    break;
                case 2: //AP
                    estado = " = 'AP'";
                    tbAP.Controls.Add(lstCli);
                    break;
                case 3: //AM
                    estado = " = 'AM'";
                    tbAM.Controls.Add(lstCli);
                    break;
                case 4: //BA
                    estado = " = 'BA'";
                    tbBA.Controls.Add(lstCli);
                    break;
                case 5: //CE
                    estado = " = 'CE'";
                    tbCE.Controls.Add(lstCli);
                    break;
                case 6: //ES
                    estado = " = 'ES'";
                    tbES.Controls.Add(lstCli);
                    break;
                case 7: //GO
                    estado = " = 'GO'";
                    tbGO.Controls.Add(lstCli);
                    break;
                case 8: //MA
                    estado = " = 'MA'";
                    tbMA.Controls.Add(lstCli);
                    break;
                case 9: //MT
                    estado = " = 'MT'";
                    tbMT.Controls.Add(lstCli);
                    break;
                case 10: //MS
                    estado = " = 'MS'";
                    tbMS.Controls.Add(lstCli);
                    break;
                case 11: //MG
                    estado = " = 'MG'";
                    tbMG.Controls.Add(lstCli);
                    break;
                case 12: //PA
                    estado = " = 'PA'";
                    tbPA.Controls.Add(lstCli);
                    break;
                case 13: //PB
                    estado = " = 'PB'";
                    tbPB.Controls.Add(lstCli);
                    break;
                case 14: //PR
                    estado = " = 'PR'";
                    tbPR.Controls.Add(lstCli);
                    break;
                case 15: //PE
                    estado = " = 'PE'";
                    tbPE.Controls.Add(lstCli);
                    break;
                case 16: //PI
                    estado = " = 'PI'";
                    tbPI.Controls.Add(lstCli);
                    break;
                case 17: //RJ
                    estado = " = 'RJ'";
                    tbRJ.Controls.Add(lstCli);
                    break;
                case 18: //RN
                    estado = " = 'RN'";
                    tbRN.Controls.Add(lstCli);
                    break;
                case 19: //RS
                    estado = " = 'RS'";
                    tbRS.Controls.Add(lstCli);
                    break;
                case 20: //RO
                    estado = " = 'RO'";
                    tbRO.Controls.Add(lstCli);
                    break;
                case 21: //RR
                    estado = " = 'RR'";
                    tbRR.Controls.Add(lstCli);
                    break;
                case 22: //StC
                    estado = " = 'SC'";
                    tbSC.Controls.Add(lstCli);
                    break;
                case 23: //SP
                    estado = " = 'SP'";
                    tbSP.Controls.Add(lstCli);
                    break;
                case 24: //SE
                    estado = " = 'SE'";
                    tbSE.Controls.Add(lstCli);
                    break;
                case 25: //TO
                    estado = " = 'TO'";
                    tbTO.Controls.Add(lstCli);
                    break;
                case 26: //DF
                    estado = " = 'DF'";
                    tbDF.Controls.Add(lstCli);
                    break;
                default: //outros produtos                   
                    break;
            }
            BuscarLista(estado);
        }

        public void BuscarLista(string estado, string nome = "")
        {
            ClienteService clienteService = new ClienteService();

            List<ClientesModel> lstClientes = new List<ClientesModel>();

            lstClientes = clienteService.lsClientes(idEmpresa, estado);

            PopularLista(lstClientes, nome);
        }

        public string validarDados(PedidosModel pedido)
        {
            string mensagem = "";

            if (pedido.cliente.idCliente is 0)
            {
                mensagem += "***Cliente não Escolhido***\r\n\r\n";
            }
            if (pedido.Produtos.produtos.Count == 0)
            {
                mensagem += "***Produtos não Escolhidos***\r\n\r\n";
            }
            if (pedido.condicao.parcelas.Count == 0)
            {
                mensagem += "***Forma de Pagamento não Escolhida***\r\n\r\n";
            }
            else
            {
                decimal valorTotalParcela = 0;
                foreach (var item in pedido.condicao.parcelas)
                {
                    valorTotalParcela += item.valorParcela;
                }
                if (valorTotalParcela < pedido.valorTotal)
                {
                    mensagem += "***Valor das Parcelas esta '''Abaixo''' do Valor Total do Pedido***";
                }
                if (valorTotalParcela > pedido.valorTotal)
                {
                    mensagem += "***Valor das Parcelas esta '''Acima''' do Valor Total do Pedido***";
                }
            }
            return mensagem;
        }

        private void txtDesc_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtDesc.Text, "[^0-9,.]"))
            {
                txtDesc.Text = txtDesc.Text.Remove((txtDesc.Text.Length - 1), 1);
                txtDesc.SelectionStart = txtDesc.Text.Length;
            }
        }

        private void txtValFret_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtValFret.Text, "[^0-9,.]"))
            {
                txtValFret.Text = txtValFret.Text.Remove((txtValFret.Text.Length - 1), 1);
                txtValFret.SelectionStart = txtValFret.Text.Length;
            }
        }

        private void txtValorEnt_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtValorEnt.Text, "[^0-9,.]"))
            {
                txtValorEnt.Text = txtValorEnt.Text.Remove((txtValorEnt.Text.Length - 1), 1);
                txtValorEnt.SelectionStart = txtValorEnt.Text.Length;
            }
        }

        public void voltar()
        {
            frmInicio.pContainer.Controls.Clear();
            frmPedidos frmPed = new frmPedidos(idEmpresa, frmInicio);
            frmPed.TopLevel = false;
            frmInicio.pContainer.Controls.Add(frmPed);
            frmPed.WindowState = frmInicio.WindowState;
            frmPed.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (ctrNovoPed.SelectedIndex)
            {
                case 0: //Clentes
                        //BuscarLista(estado);
                    lstCli.Items.Clear();
                    BuscarLista(estado, txtBuscar.Text);
                    break;
                case 1: //Produtos
                    //montarItens(idCat);
                    listProd.Items.Clear();
                    montarItens(idCat, txtBuscar.Text);
                    break;
                default:
                    break;
            }
        }

        void document_PrintPage(object sender, PrintPageEventArgs e)
        {
            string etiquetaRemetente = "\r\n - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -" +
                                        "\r\nCentral de Afiação" +
                                        "\r\n\r\nEndereço: Rua Moacir Falaguasta, 2390" +
                                        "\r\nCEP: 14407-061" +
                                        "\r\nBairro: Tropical II" +
                                        "\r\nCidade: Franca - SP";

            e.Graphics.DrawString(etiquetaCliente + etiquetaRemetente, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, 20, 20);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dialog.Document = document;
            dialog.Document.DefaultPageSettings.PrinterResolution = dialog.Document.PrinterSettings.PrinterResolutions[3];// = dialog.Document.PrinterSettings.PrinterResolutions[];

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                document.Print();
            }
        }

        private void numNovoQuantidade_ValueChanged(object sender, EventArgs e)
        {
            txtTotProd.Text = (numNovoQuantidade.Value * decimal.Parse(txtValorUnitario.Text)).ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lstCond.Items.Clear();
            condicoes.parcelas.Clear();
            //Totallbl(valorTotal, valorParcialItens, valorFrete, valorDesconto);
        }

        private void btnLimparFrete_Click(object sender, EventArgs e)
        {
            txtValFret.Text = "0.00";
            lblValFre.Text = "0.00";
            dtEnv.Value = DateTime.Now;
            lblDtFre.Text = "01/01/2020";
            frete = new FreteModel();
            valorFrete = 0;
            Totallbl(valorTotal, valorParcialItens, valorFrete, valorDesconto);
        }

        private void btnLimparItens_Click(object sender, EventArgs e)
        {
            lstItensPedidos.Items.Clear();
            produtos.produtos.Clear();
            valorTotal = 0;
            valorParcialItens = 0;
            valorDesconto = 0;
            Totallbl(valorTotal, valorParcialItens, valorFrete, valorDesconto);
        }
    }
}
