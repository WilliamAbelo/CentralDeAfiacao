namespace descktop.Views.FluxoCaixa.Pagamentos
{
    partial class frmNovo
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
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lstParcelas = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.qtdParc = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtPriParcela = new System.Windows.Forms.DateTimePicker();
            this.btnAddParcela = new System.Windows.Forms.Button();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.txtParcela = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.cbTipoDivida = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qtdParc)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(254, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 91;
            this.label6.Text = "R$";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 286);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 13);
            this.label12.TabIndex = 90;
            this.label12.Text = "Observações";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Location = new System.Drawing.Point(649, 382);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 89;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtObservacao
            // 
            this.txtObservacao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtObservacao.Location = new System.Drawing.Point(12, 302);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(712, 74);
            this.txtObservacao.TabIndex = 88;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 87;
            this.label8.Text = "Lista de Parcelas";
            // 
            // lstParcelas
            // 
            this.lstParcelas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstParcelas.HideSelection = false;
            this.lstParcelas.Location = new System.Drawing.Point(13, 142);
            this.lstParcelas.Name = "lstParcelas";
            this.lstParcelas.Size = new System.Drawing.Size(711, 135);
            this.lstParcelas.TabIndex = 86;
            this.lstParcelas.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 85;
            this.label1.Text = "Divida";
            // 
            // qtdParc
            // 
            this.qtdParc.Location = new System.Drawing.Point(531, 56);
            this.qtdParc.Name = "qtdParc";
            this.qtdParc.Size = new System.Drawing.Size(52, 20);
            this.qtdParc.TabIndex = 84;
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
            this.label5.TabIndex = 83;
            this.label5.Text = "Qtd Parcelas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(387, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 71;
            this.label4.Text = "Data Primeira Parcela";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 70;
            this.label3.Text = "Valor Total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 69;
            this.label2.Text = "Nome da Divida";
            // 
            // dtPriParcela
            // 
            this.dtPriParcela.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPriParcela.Location = new System.Drawing.Point(390, 56);
            this.dtPriParcela.Name = "dtPriParcela";
            this.dtPriParcela.Size = new System.Drawing.Size(106, 20);
            this.dtPriParcela.TabIndex = 68;
            // 
            // btnAddParcela
            // 
            this.btnAddParcela.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddParcela.Location = new System.Drawing.Point(615, 116);
            this.btnAddParcela.Name = "btnAddParcela";
            this.btnAddParcela.Size = new System.Drawing.Size(109, 23);
            this.btnAddParcela.TabIndex = 67;
            this.btnAddParcela.Text = "Adicionar Parcelas";
            this.btnAddParcela.UseVisualStyleBackColor = true;
            this.btnAddParcela.Click += new System.EventHandler(this.btnAddParcela_Click);
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Location = new System.Drawing.Point(278, 56);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(100, 20);
            this.txtValorTotal.TabIndex = 66;
            this.txtValorTotal.Text = "0.00";
            this.txtValorTotal.GotFocus += new System.EventHandler(this.txtValorTotal_GotFocus);
            // 
            // txtParcela
            // 
            this.txtParcela.Location = new System.Drawing.Point(13, 56);
            this.txtParcela.Name = "txtParcela";
            this.txtParcela.Size = new System.Drawing.Size(231, 20);
            this.txtParcela.TabIndex = 65;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVoltar.Location = new System.Drawing.Point(12, 382);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 93;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // cbTipoDivida
            // 
            this.cbTipoDivida.FormattingEnabled = true;
            this.cbTipoDivida.Items.AddRange(new object[] {
            "Afiação (Loja)",
            "Casa (Pessoal)"});
            this.cbTipoDivida.Location = new System.Drawing.Point(12, 95);
            this.cbTipoDivida.Name = "cbTipoDivida";
            this.cbTipoDivida.Size = new System.Drawing.Size(121, 21);
            this.cbTipoDivida.TabIndex = 94;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 95;
            this.label7.Text = "Tipo da Divida";
            // 
            // frmNovo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(736, 417);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbTipoDivida);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lstParcelas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.qtdParc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtPriParcela);
            this.Controls.Add(this.btnAddParcela);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.txtParcela);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNovo";
            this.Text = "frmNovo";
            ((System.ComponentModel.ISupportInitialize)(this.qtdParc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView lstParcelas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown qtdParc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtPriParcela;
        private System.Windows.Forms.Button btnAddParcela;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.TextBox txtParcela;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.ComboBox cbTipoDivida;
        private System.Windows.Forms.Label label7;
    }
}