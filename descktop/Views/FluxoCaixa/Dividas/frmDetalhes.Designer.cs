namespace descktop.Views.FluxoCaixa.Dividas
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
            this.cbTipoDivida = new System.Windows.Forms.ComboBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lstParcelas = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.qtdParc = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEdtParcela = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblEditDtPagamento = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ckbEdtPago = new System.Windows.Forms.CheckBox();
            this.dtEdtPag = new System.Windows.Forms.DateTimePicker();
            this.dtEdtVenc = new System.Windows.Forms.DateTimePicker();
            this.txtEdtValorParcela = new System.Windows.Forms.TextBox();
            this.txtEditParcela = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtPriParcela = new System.Windows.Forms.DateTimePicker();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.txtParcela = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtTotalmentePago = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.qtdParc)).BeginInit();
            this.SuspendLayout();
            // 
            // cbTipoDivida
            // 
            this.cbTipoDivida.Enabled = false;
            this.cbTipoDivida.FormattingEnabled = true;
            this.cbTipoDivida.Items.AddRange(new object[] {
            "Afiação (Loja)",
            "Casa (Pessoal)"});
            this.cbTipoDivida.Location = new System.Drawing.Point(13, 95);
            this.cbTipoDivida.Name = "cbTipoDivida";
            this.cbTipoDivida.Size = new System.Drawing.Size(121, 21);
            this.cbTipoDivida.TabIndex = 124;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVoltar.Location = new System.Drawing.Point(12, 382);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 123;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(253, 266);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 13);
            this.label13.TabIndex = 122;
            this.label13.Text = "R$";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(254, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 121;
            this.label6.Text = "R$";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 286);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 13);
            this.label12.TabIndex = 120;
            this.label12.Text = "Observações";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Location = new System.Drawing.Point(649, 382);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 119;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // txtObservacao
            // 
            this.txtObservacao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtObservacao.Location = new System.Drawing.Point(12, 302);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(712, 74);
            this.txtObservacao.TabIndex = 118;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 117;
            this.label8.Text = "Lista de Parcelas";
            // 
            // lstParcelas
            // 
            this.lstParcelas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstParcelas.HideSelection = false;
            this.lstParcelas.Location = new System.Drawing.Point(13, 135);
            this.lstParcelas.Name = "lstParcelas";
            this.lstParcelas.Size = new System.Drawing.Size(711, 105);
            this.lstParcelas.TabIndex = 116;
            this.lstParcelas.UseCompatibleStateImageBehavior = false;
            this.lstParcelas.SelectedIndexChanged += new System.EventHandler(this.lstParcelas_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 115;
            this.label1.Text = "Divida";
            // 
            // qtdParc
            // 
            this.qtdParc.Location = new System.Drawing.Point(531, 56);
            this.qtdParc.Name = "qtdParc";
            this.qtdParc.ReadOnly = true;
            this.qtdParc.Size = new System.Drawing.Size(52, 20);
            this.qtdParc.TabIndex = 114;
            this.qtdParc.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(528, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 113;
            this.label5.Text = "Qtd Parcelas";
            // 
            // btnEdtParcela
            // 
            this.btnEdtParcela.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdtParcela.Location = new System.Drawing.Point(637, 260);
            this.btnEdtParcela.Name = "btnEdtParcela";
            this.btnEdtParcela.Size = new System.Drawing.Size(87, 23);
            this.btnEdtParcela.TabIndex = 112;
            this.btnEdtParcela.Text = "Editar Parcela";
            this.btnEdtParcela.UseVisualStyleBackColor = true;
            this.btnEdtParcela.Click += new System.EventHandler(this.btnEdtParcela_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(493, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 111;
            this.label7.Text = "Pago";
            // 
            // lblEditDtPagamento
            // 
            this.lblEditDtPagamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEditDtPagamento.AutoSize = true;
            this.lblEditDtPagamento.Location = new System.Drawing.Point(543, 247);
            this.lblEditDtPagamento.Name = "lblEditDtPagamento";
            this.lblEditDtPagamento.Size = new System.Drawing.Size(87, 13);
            this.lblEditDtPagamento.TabIndex = 110;
            this.lblEditDtPagamento.Text = "Data Pagamento";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(386, 247);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 109;
            this.label9.Text = "Data Vencimento";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(274, 247);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 13);
            this.label10.TabIndex = 108;
            this.label10.Text = "Valor da Parcela";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 247);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 13);
            this.label11.TabIndex = 107;
            this.label11.Text = "Nome da Parcela";
            // 
            // ckbEdtPago
            // 
            this.ckbEdtPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ckbEdtPago.AutoSize = true;
            this.ckbEdtPago.Location = new System.Drawing.Point(497, 263);
            this.ckbEdtPago.Name = "ckbEdtPago";
            this.ckbEdtPago.Size = new System.Drawing.Size(15, 14);
            this.ckbEdtPago.TabIndex = 106;
            this.ckbEdtPago.UseVisualStyleBackColor = true;
            this.ckbEdtPago.CheckedChanged += new System.EventHandler(this.ckbEdtPago_CheckedChanged);
            // 
            // dtEdtPag
            // 
            this.dtEdtPag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtEdtPag.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEdtPag.Location = new System.Drawing.Point(534, 263);
            this.dtEdtPag.Name = "dtEdtPag";
            this.dtEdtPag.Size = new System.Drawing.Size(96, 20);
            this.dtEdtPag.TabIndex = 105;
            // 
            // dtEdtVenc
            // 
            this.dtEdtVenc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtEdtVenc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEdtVenc.Location = new System.Drawing.Point(383, 263);
            this.dtEdtVenc.Name = "dtEdtVenc";
            this.dtEdtVenc.Size = new System.Drawing.Size(95, 20);
            this.dtEdtVenc.TabIndex = 104;
            // 
            // txtEdtValorParcela
            // 
            this.txtEdtValorParcela.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtEdtValorParcela.Location = new System.Drawing.Point(277, 263);
            this.txtEdtValorParcela.Name = "txtEdtValorParcela";
            this.txtEdtValorParcela.ReadOnly = true;
            this.txtEdtValorParcela.Size = new System.Drawing.Size(100, 20);
            this.txtEdtValorParcela.TabIndex = 103;
            // 
            // txtEditParcela
            // 
            this.txtEditParcela.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtEditParcela.Location = new System.Drawing.Point(12, 263);
            this.txtEditParcela.Name = "txtEditParcela";
            this.txtEditParcela.ReadOnly = true;
            this.txtEditParcela.Size = new System.Drawing.Size(232, 20);
            this.txtEditParcela.TabIndex = 102;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(387, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 101;
            this.label4.Text = "Data Criação";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 100;
            this.label3.Text = "Valor Total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 99;
            this.label2.Text = "Nome da Divida";
            // 
            // dtPriParcela
            // 
            this.dtPriParcela.Enabled = false;
            this.dtPriParcela.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPriParcela.Location = new System.Drawing.Point(390, 56);
            this.dtPriParcela.Name = "dtPriParcela";
            this.dtPriParcela.Size = new System.Drawing.Size(106, 20);
            this.dtPriParcela.TabIndex = 98;
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Location = new System.Drawing.Point(278, 56);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.ReadOnly = true;
            this.txtValorTotal.Size = new System.Drawing.Size(100, 20);
            this.txtValorTotal.TabIndex = 96;
            // 
            // txtParcela
            // 
            this.txtParcela.Location = new System.Drawing.Point(13, 56);
            this.txtParcela.Name = "txtParcela";
            this.txtParcela.ReadOnly = true;
            this.txtParcela.Size = new System.Drawing.Size(231, 20);
            this.txtParcela.TabIndex = 95;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 79);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 13);
            this.label14.TabIndex = 125;
            this.label14.Text = "Tipo da Divida";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(278, 95);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(94, 13);
            this.label15.TabIndex = 126;
            this.label15.Text = "Totalmente Pago: ";
            // 
            // txtTotalmentePago
            // 
            this.txtTotalmentePago.Location = new System.Drawing.Point(370, 93);
            this.txtTotalmentePago.Name = "txtTotalmentePago";
            this.txtTotalmentePago.ReadOnly = true;
            this.txtTotalmentePago.Size = new System.Drawing.Size(49, 20);
            this.txtTotalmentePago.TabIndex = 127;
            this.txtTotalmentePago.Text = "Não";
            // 
            // frmDetalhes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(736, 417);
            this.Controls.Add(this.txtTotalmentePago);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cbTipoDivida);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lstParcelas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.qtdParc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnEdtParcela);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblEditDtPagamento);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ckbEdtPago);
            this.Controls.Add(this.dtEdtPag);
            this.Controls.Add(this.dtEdtVenc);
            this.Controls.Add(this.txtEdtValorParcela);
            this.Controls.Add(this.txtEditParcela);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtPriParcela);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.txtParcela);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDetalhes";
            this.Text = "frmDetalhes";
            ((System.ComponentModel.ISupportInitialize)(this.qtdParc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTipoDivida;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView lstParcelas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown qtdParc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEdtParcela;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblEditDtPagamento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox ckbEdtPago;
        private System.Windows.Forms.DateTimePicker dtEdtPag;
        private System.Windows.Forms.DateTimePicker dtEdtVenc;
        private System.Windows.Forms.TextBox txtEdtValorParcela;
        private System.Windows.Forms.TextBox txtEditParcela;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtPriParcela;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.TextBox txtParcela;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtTotalmentePago;
    }
}