namespace descktop.Views.Clientes
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVisPed = new System.Windows.Forms.Button();
            this.Historico = new System.Windows.Forms.Label();
            this.lstHist = new System.Windows.Forms.ListView();
            this.label16 = new System.Windows.Forms.Label();
            this.txtEtiqueta = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txtCpfCnpj = new System.Windows.Forms.TextBox();
            this.txtCel1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTelef = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbEst = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBair = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtComp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtResp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDetVoltar
            // 
            this.btnDetVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDetVoltar.Location = new System.Drawing.Point(12, 435);
            this.btnDetVoltar.Name = "btnDetVoltar";
            this.btnDetVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnDetVoltar.TabIndex = 2;
            this.btnDetVoltar.Text = "Voltar";
            this.btnDetVoltar.UseVisualStyleBackColor = true;
            this.btnDetVoltar.Click += new System.EventHandler(this.btnDetVoltar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Location = new System.Drawing.Point(565, 435);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(103, 23);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar Alterações";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnVisPed);
            this.panel1.Controls.Add(this.Historico);
            this.panel1.Controls.Add(this.lstHist);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.txtEtiqueta);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.txtCpfCnpj);
            this.panel1.Controls.Add(this.txtCel1);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txtTelef);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtCEP);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.txtObs);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.cbEst);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtCid);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtBair);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtComp);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtNum);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtEnd);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtResp);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(736, 416);
            this.panel1.TabIndex = 3;
            // 
            // btnVisPed
            // 
            this.btnVisPed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVisPed.Location = new System.Drawing.Point(646, 228);
            this.btnVisPed.Name = "btnVisPed";
            this.btnVisPed.Size = new System.Drawing.Size(85, 81);
            this.btnVisPed.TabIndex = 75;
            this.btnVisPed.Text = "Visualizar Pedido";
            this.btnVisPed.UseVisualStyleBackColor = true;
            this.btnVisPed.Click += new System.EventHandler(this.btnVisPed_Click);
            // 
            // Historico
            // 
            this.Historico.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Historico.AutoSize = true;
            this.Historico.Location = new System.Drawing.Point(1, 215);
            this.Historico.Name = "Historico";
            this.Historico.Size = new System.Drawing.Size(48, 13);
            this.Historico.TabIndex = 74;
            this.Historico.Text = "Historico";
            // 
            // lstHist
            // 
            this.lstHist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstHist.HideSelection = false;
            this.lstHist.Location = new System.Drawing.Point(4, 228);
            this.lstHist.Name = "lstHist";
            this.lstHist.Size = new System.Drawing.Size(636, 79);
            this.lstHist.TabIndex = 73;
            this.lstHist.UseCompatibleStateImageBehavior = false;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(336, 310);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(46, 13);
            this.label16.TabIndex = 72;
            this.label16.Text = "Etiqueta";
            // 
            // txtEtiqueta
            // 
            this.txtEtiqueta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEtiqueta.Location = new System.Drawing.Point(339, 326);
            this.txtEtiqueta.Multiline = true;
            this.txtEtiqueta.Name = "txtEtiqueta";
            this.txtEtiqueta.ReadOnly = true;
            this.txtEtiqueta.Size = new System.Drawing.Size(319, 85);
            this.txtEtiqueta.TabIndex = 71;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(661, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 85);
            this.button1.TabIndex = 70;
            this.button1.Text = "Imprimir Etiqueta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(386, 172);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 13);
            this.label15.TabIndex = 69;
            this.label15.Text = "CPF / CNPJ";
            // 
            // txtCpfCnpj
            // 
            this.txtCpfCnpj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCpfCnpj.Location = new System.Drawing.Point(383, 189);
            this.txtCpfCnpj.Name = "txtCpfCnpj";
            this.txtCpfCnpj.Size = new System.Drawing.Size(341, 20);
            this.txtCpfCnpj.TabIndex = 68;
            // 
            // txtCel1
            // 
            this.txtCel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCel1.Location = new System.Drawing.Point(564, 146);
            this.txtCel1.Name = "txtCel1";
            this.txtCel1.Size = new System.Drawing.Size(160, 20);
            this.txtCel1.TabIndex = 67;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(565, 129);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 66;
            this.label12.Text = "Celular";
            // 
            // txtTelef
            // 
            this.txtTelef.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTelef.Location = new System.Drawing.Point(383, 146);
            this.txtTelef.Name = "txtTelef";
            this.txtTelef.Size = new System.Drawing.Size(160, 20);
            this.txtTelef.TabIndex = 65;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(383, 129);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 64;
            this.label11.Text = "Telefone Fixo";
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(4, 145);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(330, 20);
            this.txtCEP.TabIndex = 59;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(4, 129);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 13);
            this.label14.TabIndex = 58;
            this.label14.Text = "CEP";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(4, 188);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(330, 20);
            this.txtEmail.TabIndex = 57;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 172);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 56;
            this.label13.Text = "E-mail";
            // 
            // txtObs
            // 
            this.txtObs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtObs.Location = new System.Drawing.Point(3, 326);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(330, 85);
            this.txtObs.TabIndex = 51;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 310);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 50;
            this.label10.Text = "Observações";
            // 
            // cbEst
            // 
            this.cbEst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbEst.FormattingEnabled = true;
            this.cbEst.Location = new System.Drawing.Point(661, 102);
            this.cbEst.Name = "cbEst";
            this.cbEst.Size = new System.Drawing.Size(63, 21);
            this.cbEst.TabIndex = 49;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(658, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 48;
            this.label9.Text = "Estado";
            // 
            // txtCid
            // 
            this.txtCid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCid.Location = new System.Drawing.Point(383, 103);
            this.txtCid.Name = "txtCid";
            this.txtCid.Size = new System.Drawing.Size(240, 20);
            this.txtCid.TabIndex = 47;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(383, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "Cidade";
            // 
            // txtBair
            // 
            this.txtBair.Location = new System.Drawing.Point(4, 101);
            this.txtBair.Name = "txtBair";
            this.txtBair.Size = new System.Drawing.Size(330, 20);
            this.txtBair.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "Bairro";
            // 
            // txtComp
            // 
            this.txtComp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtComp.Location = new System.Drawing.Point(521, 57);
            this.txtComp.Name = "txtComp";
            this.txtComp.Size = new System.Drawing.Size(203, 20);
            this.txtComp.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(518, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Complemento";
            // 
            // txtNum
            // 
            this.txtNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNum.Location = new System.Drawing.Point(383, 58);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 20);
            this.txtNum.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(380, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Numero";
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(4, 57);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(330, 20);
            this.txtEnd.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Endereço";
            // 
            // txtResp
            // 
            this.txtResp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResp.Location = new System.Drawing.Point(383, 16);
            this.txtResp.Name = "txtResp";
            this.txtResp.Size = new System.Drawing.Size(341, 20);
            this.txtResp.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(380, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Responsavel";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(4, 16);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(326, 20);
            this.txtNome.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Nome do Estabelecimento";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(674, 435);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Excluir";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmDetalhes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(760, 470);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDetVoltar);
            this.Controls.Add(this.btnSalvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDetalhes";
            this.Text = "frmDetalhes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDetVoltar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbEst;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBair;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtComp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtResp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCEP;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtCpfCnpj;
        private System.Windows.Forms.TextBox txtCel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTelef;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtEtiqueta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Historico;
        private System.Windows.Forms.ListView lstHist;
        private System.Windows.Forms.Button btnVisPed;
    }
}