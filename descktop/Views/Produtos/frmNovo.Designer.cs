﻿namespace descktop.Views.Produtos
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
            this.btnNovVoltar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstCateg = new System.Windows.Forms.ListView();
            this.lblCat = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtObsProd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnGravNovo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNovVoltar
            // 
            this.btnNovVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNovVoltar.Location = new System.Drawing.Point(12, 435);
            this.btnNovVoltar.Name = "btnNovVoltar";
            this.btnNovVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnNovVoltar.TabIndex = 4;
            this.btnNovVoltar.Text = "Voltar";
            this.btnNovVoltar.UseVisualStyleBackColor = true;
            this.btnNovVoltar.Click += new System.EventHandler(this.btnNovVoltar_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lstCateg);
            this.panel1.Controls.Add(this.lblCat);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtObsProd);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtProd);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtValor);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(735, 416);
            this.panel1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(290, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "R$";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(393, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(329, 203);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Categoria";
            // 
            // lstCateg
            // 
            this.lstCateg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstCateg.HideSelection = false;
            this.lstCateg.Location = new System.Drawing.Point(10, 81);
            this.lstCateg.Name = "lstCateg";
            this.lstCateg.Size = new System.Drawing.Size(376, 203);
            this.lstCateg.TabIndex = 29;
            this.lstCateg.UseCompatibleStateImageBehavior = false;
            this.lstCateg.SelectedIndexChanged += new System.EventHandler(this.lstCateg_SelectedIndexChanged_1);
            // 
            // lblCat
            // 
            this.lblCat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCat.AutoSize = true;
            this.lblCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCat.Location = new System.Drawing.Point(505, 40);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(180, 20);
            this.lblCat.TabIndex = 26;
            this.lblCat.Text = "___________________";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(413, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 20);
            this.label8.TabIndex = 25;
            this.label8.Text = "Categoria: ";
            // 
            // txtObsProd
            // 
            this.txtObsProd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtObsProd.Location = new System.Drawing.Point(10, 316);
            this.txtObsProd.Multiline = true;
            this.txtObsProd.Name = "txtObsProd";
            this.txtObsProd.Size = new System.Drawing.Size(713, 91);
            this.txtObsProd.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Observação";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nome do Produto";
            // 
            // txtProd
            // 
            this.txtProd.Location = new System.Drawing.Point(10, 40);
            this.txtProd.Name = "txtProd";
            this.txtProd.Size = new System.Drawing.Size(251, 20);
            this.txtProd.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Preço";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(314, 40);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(72, 20);
            this.txtValor.TabIndex = 21;
            this.txtValor.Text = "0.00";
            this.txtValor.TextChanged += new System.EventHandler(this.txtValor_TextChanged);
            this.txtValor.GotFocus += new System.EventHandler(this.txtValor_GotFocus);
            // 
            // btnGravNovo
            // 
            this.btnGravNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGravNovo.Location = new System.Drawing.Point(659, 435);
            this.btnGravNovo.Name = "btnGravNovo";
            this.btnGravNovo.Size = new System.Drawing.Size(89, 23);
            this.btnGravNovo.TabIndex = 0;
            this.btnGravNovo.Text = "Gravar Produto";
            this.btnGravNovo.UseVisualStyleBackColor = true;
            this.btnGravNovo.Click += new System.EventHandler(this.btnGravNovo_Click);
            // 
            // frmNovo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(760, 470);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnNovVoltar);
            this.Controls.Add(this.btnGravNovo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNovo";
            this.Text = "frmNovo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNovVoltar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGravNovo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lstCateg;
        private System.Windows.Forms.Label lblCat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtObsProd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValor;
    }
}