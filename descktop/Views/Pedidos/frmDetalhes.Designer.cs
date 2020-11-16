namespace descktop.Views.Vendas
{
    partial class frmDetalhes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDetVoltar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEtiqueta = new System.Windows.Forms.Button();
            this.txtEtiqueta = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblFrete = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblDataVenda = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValorUnitario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numNovoQuantidade = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNovoProdutoEsco = new System.Windows.Forms.TextBox();
            this.btnAlterProd = new System.Windows.Forms.Button();
            this.lstProd = new System.Windows.Forms.ListView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.dtParc = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.ckbPaga = new System.Windows.Forms.CheckBox();
            this.lblDtPag = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumParc = new System.Windows.Forms.TextBox();
            this.dtPag = new System.Windows.Forms.DateTimePicker();
            this.txtFormPag = new System.Windows.Forms.TextBox();
            this.txtValorParc = new System.Windows.Forms.TextBox();
            this.btnEdtParc = new System.Windows.Forms.Button();
            this.btnExcParc = new System.Windows.Forms.Button();
            this.lstPag = new System.Windows.Forms.ListView();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNovoQuantidade)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDetVoltar
            // 
            this.btnDetVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDetVoltar.Location = new System.Drawing.Point(12, 435);
            this.btnDetVoltar.Name = "btnDetVoltar";
            this.btnDetVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnDetVoltar.TabIndex = 1;
            this.btnDetVoltar.Text = "Voltar";
            this.btnDetVoltar.UseVisualStyleBackColor = true;
            this.btnDetVoltar.Click += new System.EventHandler(this.btnDetVoltar_Click_1);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnEtiqueta);
            this.panel1.Controls.Add(this.txtEtiqueta);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.lblFrete);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.lblDataVenda);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.lblCliente);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtObs);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(736, 416);
            this.panel1.TabIndex = 10;
            // 
            // btnEtiqueta
            // 
            this.btnEtiqueta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEtiqueta.Location = new System.Drawing.Point(671, 346);
            this.btnEtiqueta.Name = "btnEtiqueta";
            this.btnEtiqueta.Size = new System.Drawing.Size(60, 65);
            this.btnEtiqueta.TabIndex = 22;
            this.btnEtiqueta.Text = "Imprimir Etiqueta";
            this.btnEtiqueta.UseVisualStyleBackColor = true;
            this.btnEtiqueta.Click += new System.EventHandler(this.btnEtiqueta_Click);
            // 
            // txtEtiqueta
            // 
            this.txtEtiqueta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEtiqueta.Location = new System.Drawing.Point(357, 290);
            this.txtEtiqueta.Multiline = true;
            this.txtEtiqueta.Name = "txtEtiqueta";
            this.txtEtiqueta.ReadOnly = true;
            this.txtEtiqueta.Size = new System.Drawing.Size(308, 121);
            this.txtEtiqueta.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(357, 274);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Etiqueta";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(486, 12);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 13);
            this.label14.TabIndex = 19;
            this.label14.Text = "Frete";
            // 
            // lblFrete
            // 
            this.lblFrete.AutoSize = true;
            this.lblFrete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrete.Location = new System.Drawing.Point(515, 10);
            this.lblFrete.Name = "lblFrete";
            this.lblFrete.Size = new System.Drawing.Size(65, 15);
            this.lblFrete.TabIndex = 18;
            this.lblFrete.Text = "R$ 00.00";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(645, 10);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(65, 15);
            this.lblTotal.TabIndex = 17;
            this.lblTotal.Text = "R$ 00,00";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(589, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Valor Total";
            // 
            // lblDataVenda
            // 
            this.lblDataVenda.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDataVenda.AutoSize = true;
            this.lblDataVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataVenda.Location = new System.Drawing.Point(401, 10);
            this.lblDataVenda.Name = "lblDataVenda";
            this.lblDataVenda.Size = new System.Drawing.Size(79, 15);
            this.lblDataVenda.TabIndex = 15;
            this.lblDataVenda.Text = "01/01/1900";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(324, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Data da Venda";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(88, 10);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(95, 15);
            this.lblCliente.TabIndex = 13;
            this.lblCliente.Text = "___________";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Cliente escolhido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Observções";
            // 
            // txtObs
            // 
            this.txtObs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtObs.Location = new System.Drawing.Point(6, 289);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(345, 122);
            this.txtObs.TabIndex = 6;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(6, 30);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(723, 240);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtValorUnitario);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.numNovoQuantidade);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtNovoProdutoEsco);
            this.tabPage1.Controls.Add(this.btnAlterProd);
            this.tabPage1.Controls.Add(this.lstProd);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(715, 214);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Produtos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(297, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 25;
            this.label3.Text = "Valor Unitario";
            // 
            // txtValorUnitario
            // 
            this.txtValorUnitario.Location = new System.Drawing.Point(297, 186);
            this.txtValorUnitario.Name = "txtValorUnitario";
            this.txtValorUnitario.Size = new System.Drawing.Size(72, 20);
            this.txtValorUnitario.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(227, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "Quantidade";
            // 
            // numNovoQuantidade
            // 
            this.numNovoQuantidade.Location = new System.Drawing.Point(227, 187);
            this.numNovoQuantidade.Name = "numNovoQuantidade";
            this.numNovoQuantidade.Size = new System.Drawing.Size(64, 20);
            this.numNovoQuantidade.TabIndex = 22;
            this.numNovoQuantidade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(6, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "Produto escolhido";
            // 
            // txtNovoProdutoEsco
            // 
            this.txtNovoProdutoEsco.Location = new System.Drawing.Point(6, 186);
            this.txtNovoProdutoEsco.Name = "txtNovoProdutoEsco";
            this.txtNovoProdutoEsco.Size = new System.Drawing.Size(215, 20);
            this.txtNovoProdutoEsco.TabIndex = 20;
            // 
            // btnAlterProd
            // 
            this.btnAlterProd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAlterProd.Location = new System.Drawing.Point(615, 183);
            this.btnAlterProd.Name = "btnAlterProd";
            this.btnAlterProd.Size = new System.Drawing.Size(92, 23);
            this.btnAlterProd.TabIndex = 1;
            this.btnAlterProd.Text = "Alterar Produto";
            this.btnAlterProd.UseVisualStyleBackColor = true;
            // 
            // lstProd
            // 
            this.lstProd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstProd.HideSelection = false;
            this.lstProd.Location = new System.Drawing.Point(6, 6);
            this.lstProd.Name = "lstProd";
            this.lstProd.Size = new System.Drawing.Size(701, 160);
            this.lstProd.TabIndex = 0;
            this.lstProd.UseCompatibleStateImageBehavior = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.lstPag);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(715, 214);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Condições de Pagamento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.dtParc);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.ckbPaga);
            this.panel2.Controls.Add(this.lblDtPag);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtNumParc);
            this.panel2.Controls.Add(this.dtPag);
            this.panel2.Controls.Add(this.txtFormPag);
            this.panel2.Controls.Add(this.txtValorParc);
            this.panel2.Controls.Add(this.btnEdtParc);
            this.panel2.Controls.Add(this.btnExcParc);
            this.panel2.Location = new System.Drawing.Point(6, 154);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(701, 52);
            this.panel2.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label13.AutoSize = true;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Location = new System.Drawing.Point(267, 5);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 15);
            this.label13.TabIndex = 41;
            this.label13.Text = "Data da Parcela";
            // 
            // dtParc
            // 
            this.dtParc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtParc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtParc.Location = new System.Drawing.Point(267, 26);
            this.dtParc.Name = "dtParc";
            this.dtParc.Size = new System.Drawing.Size(100, 20);
            this.dtParc.TabIndex = 40;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Location = new System.Drawing.Point(483, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 15);
            this.label12.TabIndex = 39;
            this.label12.Text = "Pago";
            // 
            // ckbPaga
            // 
            this.ckbPaga.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ckbPaga.AutoSize = true;
            this.ckbPaga.Location = new System.Drawing.Point(493, 26);
            this.ckbPaga.Name = "ckbPaga";
            this.ckbPaga.Size = new System.Drawing.Size(15, 14);
            this.ckbPaga.TabIndex = 38;
            this.ckbPaga.UseVisualStyleBackColor = true;
            this.ckbPaga.CheckedChanged += new System.EventHandler(this.ckbPaga_CheckedChanged);
            // 
            // lblDtPag
            // 
            this.lblDtPag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDtPag.AutoSize = true;
            this.lblDtPag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDtPag.Location = new System.Drawing.Point(373, 4);
            this.lblDtPag.Name = "lblDtPag";
            this.lblDtPag.Size = new System.Drawing.Size(104, 15);
            this.lblDtPag.TabIndex = 37;
            this.lblDtPag.Text = "Data da Pagamento";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Location = new System.Drawing.Point(177, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 15);
            this.label8.TabIndex = 36;
            this.label8.Text = "F de Pagamento";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(84, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 15);
            this.label7.TabIndex = 35;
            this.label7.Text = "Valor da Parcela";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(3, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 15);
            this.label6.TabIndex = 34;
            this.label6.Text = "Nº da Parcela";
            // 
            // txtNumParc
            // 
            this.txtNumParc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtNumParc.Location = new System.Drawing.Point(3, 26);
            this.txtNumParc.Name = "txtNumParc";
            this.txtNumParc.Size = new System.Drawing.Size(75, 20);
            this.txtNumParc.TabIndex = 33;
            // 
            // dtPag
            // 
            this.dtPag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dtPag.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPag.Location = new System.Drawing.Point(373, 26);
            this.dtPag.Name = "dtPag";
            this.dtPag.Size = new System.Drawing.Size(104, 20);
            this.dtPag.TabIndex = 32;
            // 
            // txtFormPag
            // 
            this.txtFormPag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtFormPag.Location = new System.Drawing.Point(177, 26);
            this.txtFormPag.Name = "txtFormPag";
            this.txtFormPag.Size = new System.Drawing.Size(84, 20);
            this.txtFormPag.TabIndex = 31;
            // 
            // txtValorParc
            // 
            this.txtValorParc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtValorParc.Location = new System.Drawing.Point(84, 26);
            this.txtValorParc.Name = "txtValorParc";
            this.txtValorParc.Size = new System.Drawing.Size(87, 20);
            this.txtValorParc.TabIndex = 30;
            // 
            // btnEdtParc
            // 
            this.btnEdtParc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdtParc.Location = new System.Drawing.Point(514, 24);
            this.btnEdtParc.Name = "btnEdtParc";
            this.btnEdtParc.Size = new System.Drawing.Size(87, 23);
            this.btnEdtParc.TabIndex = 28;
            this.btnEdtParc.Text = "Salvar Parcela";
            this.btnEdtParc.UseVisualStyleBackColor = true;
            this.btnEdtParc.Click += new System.EventHandler(this.btnEdtParc_Click);
            // 
            // btnExcParc
            // 
            this.btnExcParc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcParc.Location = new System.Drawing.Point(607, 24);
            this.btnExcParc.Name = "btnExcParc";
            this.btnExcParc.Size = new System.Drawing.Size(89, 23);
            this.btnExcParc.TabIndex = 6;
            this.btnExcParc.Text = "Excluir Parcela";
            this.btnExcParc.UseVisualStyleBackColor = true;
            // 
            // lstPag
            // 
            this.lstPag.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstPag.HideSelection = false;
            this.lstPag.Location = new System.Drawing.Point(6, 6);
            this.lstPag.Name = "lstPag";
            this.lstPag.Size = new System.Drawing.Size(701, 142);
            this.lstPag.TabIndex = 0;
            this.lstPag.UseCompatibleStateImageBehavior = false;
            this.lstPag.SelectedIndexChanged += new System.EventHandler(this.lstPag_SelectedIndexChanged);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Location = new System.Drawing.Point(564, 435);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(103, 23);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Salvar Alterações";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluir.Location = new System.Drawing.Point(673, 435);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 11;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // frmDetalhes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(760, 470);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDetVoltar);
            this.Controls.Add(this.btnSalvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDetalhes";
            this.Text = "frmDetalhes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNovoQuantidade)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDetVoltar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValorUnitario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numNovoQuantidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNovoProdutoEsco;
        private System.Windows.Forms.Button btnAlterProd;
        private System.Windows.Forms.ListView lstProd;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDtPag;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNumParc;
        private System.Windows.Forms.DateTimePicker dtPag;
        private System.Windows.Forms.TextBox txtFormPag;
        private System.Windows.Forms.TextBox txtValorParc;
        private System.Windows.Forms.Button btnEdtParc;
        private System.Windows.Forms.Button btnExcParc;
        private System.Windows.Forms.ListView lstPag;
        private System.Windows.Forms.Label lblDataVenda;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox ckbPaga;
        private System.Windows.Forms.DateTimePicker dtParc;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblFrete;
        private System.Windows.Forms.Button btnEtiqueta;
        private System.Windows.Forms.TextBox txtEtiqueta;
        private System.Windows.Forms.Label label9;
    }
}