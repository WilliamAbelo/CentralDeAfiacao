namespace descktop
{
    partial class frmProduto
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
            this.pnlEst = new System.Windows.Forms.Panel();
            this.TxtBuscaNom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscaNom = new System.Windows.Forms.Button();
            this.ctrListaProd = new System.Windows.Forms.TabControl();
            this.tbSC = new System.Windows.Forms.TabPage();
            this.listProd = new System.Windows.Forms.ListView();
            this.tbSF = new System.Windows.Forms.TabPage();
            this.tbFA = new System.Windows.Forms.TabPage();
            this.tbFW = new System.Windows.Forms.TabPage();
            this.tbFreA = new System.Windows.Forms.TabPage();
            this.tbFreW = new System.Windows.Forms.TabPage();
            this.tbReb = new System.Windows.Forms.TabPage();
            this.tbOut = new System.Windows.Forms.TabPage();
            this.btnVisualizarEst = new System.Windows.Forms.Button();
            this.btnNovoEst = new System.Windows.Forms.Button();
            this.btnExcluirEst = new System.Windows.Forms.Button();
            this.pnlEst.SuspendLayout();
            this.ctrListaProd.SuspendLayout();
            this.tbSC.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEst
            // 
            this.pnlEst.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlEst.Controls.Add(this.TxtBuscaNom);
            this.pnlEst.Controls.Add(this.label1);
            this.pnlEst.Controls.Add(this.btnBuscaNom);
            this.pnlEst.Controls.Add(this.ctrListaProd);
            this.pnlEst.Location = new System.Drawing.Point(13, 12);
            this.pnlEst.Name = "pnlEst";
            this.pnlEst.Size = new System.Drawing.Size(736, 417);
            this.pnlEst.TabIndex = 0;
            // 
            // TxtBuscaNom
            // 
            this.TxtBuscaNom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBuscaNom.Location = new System.Drawing.Point(395, 3);
            this.TxtBuscaNom.Name = "TxtBuscaNom";
            this.TxtBuscaNom.Size = new System.Drawing.Size(231, 20);
            this.TxtBuscaNom.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nome do Produto";
            // 
            // btnBuscaNom
            // 
            this.btnBuscaNom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscaNom.Location = new System.Drawing.Point(631, 2);
            this.btnBuscaNom.Name = "btnBuscaNom";
            this.btnBuscaNom.Size = new System.Drawing.Size(100, 23);
            this.btnBuscaNom.TabIndex = 12;
            this.btnBuscaNom.Text = "Buscar Por Nome";
            this.btnBuscaNom.UseVisualStyleBackColor = true;
            this.btnBuscaNom.Click += new System.EventHandler(this.btnBuscaNom_Click_1);
            // 
            // ctrListaProd
            // 
            this.ctrListaProd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrListaProd.Controls.Add(this.tbSC);
            this.ctrListaProd.Controls.Add(this.tbSF);
            this.ctrListaProd.Controls.Add(this.tbFA);
            this.ctrListaProd.Controls.Add(this.tbFW);
            this.ctrListaProd.Controls.Add(this.tbFreA);
            this.ctrListaProd.Controls.Add(this.tbFreW);
            this.ctrListaProd.Controls.Add(this.tbReb);
            this.ctrListaProd.Controls.Add(this.tbOut);
            this.ctrListaProd.Location = new System.Drawing.Point(4, 31);
            this.ctrListaProd.Name = "ctrListaProd";
            this.ctrListaProd.SelectedIndex = 0;
            this.ctrListaProd.Size = new System.Drawing.Size(729, 383);
            this.ctrListaProd.TabIndex = 1;
            this.ctrListaProd.SelectedIndexChanged += new System.EventHandler(this.ctrListaProd_SelectedIndexChanged);
            // 
            // tbSC
            // 
            this.tbSC.Controls.Add(this.listProd);
            this.tbSC.Location = new System.Drawing.Point(4, 22);
            this.tbSC.Name = "tbSC";
            this.tbSC.Padding = new System.Windows.Forms.Padding(3);
            this.tbSC.Size = new System.Drawing.Size(721, 357);
            this.tbSC.TabIndex = 0;
            this.tbSC.Text = "Serras Circular";
            this.tbSC.UseVisualStyleBackColor = true;
            // 
            // listProd
            // 
            this.listProd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listProd.HideSelection = false;
            this.listProd.Location = new System.Drawing.Point(3, 3);
            this.listProd.Name = "listProd";
            this.listProd.Size = new System.Drawing.Size(715, 351);
            this.listProd.TabIndex = 0;
            this.listProd.UseCompatibleStateImageBehavior = false;
            this.listProd.SelectedIndexChanged += new System.EventHandler(this.listProd_SelectedIndexChanged);
            // 
            // tbSF
            // 
            this.tbSF.Location = new System.Drawing.Point(4, 22);
            this.tbSF.Name = "tbSF";
            this.tbSF.Padding = new System.Windows.Forms.Padding(3);
            this.tbSF.Size = new System.Drawing.Size(721, 357);
            this.tbSF.TabIndex = 1;
            this.tbSF.Text = "Serras Fita";
            this.tbSF.UseVisualStyleBackColor = true;
            // 
            // tbFA
            // 
            this.tbFA.Location = new System.Drawing.Point(4, 22);
            this.tbFA.Name = "tbFA";
            this.tbFA.Size = new System.Drawing.Size(721, 357);
            this.tbFA.TabIndex = 2;
            this.tbFA.Text = "Facas de Aço";
            this.tbFA.UseVisualStyleBackColor = true;
            // 
            // tbFW
            // 
            this.tbFW.Location = new System.Drawing.Point(4, 22);
            this.tbFW.Name = "tbFW";
            this.tbFW.Size = new System.Drawing.Size(721, 357);
            this.tbFW.TabIndex = 3;
            this.tbFW.Text = "Facas de Widea";
            this.tbFW.UseVisualStyleBackColor = true;
            // 
            // tbFreA
            // 
            this.tbFreA.Location = new System.Drawing.Point(4, 22);
            this.tbFreA.Name = "tbFreA";
            this.tbFreA.Size = new System.Drawing.Size(721, 357);
            this.tbFreA.TabIndex = 4;
            this.tbFreA.Text = "Fresas de Aço";
            this.tbFreA.UseVisualStyleBackColor = true;
            // 
            // tbFreW
            // 
            this.tbFreW.Location = new System.Drawing.Point(4, 22);
            this.tbFreW.Name = "tbFreW";
            this.tbFreW.Size = new System.Drawing.Size(721, 357);
            this.tbFreW.TabIndex = 5;
            this.tbFreW.Text = "Fresa de Widea";
            this.tbFreW.UseVisualStyleBackColor = true;
            // 
            // tbReb
            // 
            this.tbReb.Location = new System.Drawing.Point(4, 22);
            this.tbReb.Name = "tbReb";
            this.tbReb.Size = new System.Drawing.Size(721, 357);
            this.tbReb.TabIndex = 6;
            this.tbReb.Text = "Roletes/Rebolos/Cabeçotes";
            this.tbReb.UseVisualStyleBackColor = true;
            // 
            // tbOut
            // 
            this.tbOut.Location = new System.Drawing.Point(4, 22);
            this.tbOut.Name = "tbOut";
            this.tbOut.Size = new System.Drawing.Size(721, 357);
            this.tbOut.TabIndex = 8;
            this.tbOut.Text = "Outros";
            this.tbOut.UseVisualStyleBackColor = true;
            // 
            // btnVisualizarEst
            // 
            this.btnVisualizarEst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVisualizarEst.Location = new System.Drawing.Point(12, 435);
            this.btnVisualizarEst.Name = "btnVisualizarEst";
            this.btnVisualizarEst.Size = new System.Drawing.Size(75, 23);
            this.btnVisualizarEst.TabIndex = 7;
            this.btnVisualizarEst.Text = "Visualizar";
            this.btnVisualizarEst.UseVisualStyleBackColor = true;
            this.btnVisualizarEst.Click += new System.EventHandler(this.btnVisualizarEst_Click);
            // 
            // btnNovoEst
            // 
            this.btnNovoEst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNovoEst.Location = new System.Drawing.Point(93, 435);
            this.btnNovoEst.Name = "btnNovoEst";
            this.btnNovoEst.Size = new System.Drawing.Size(75, 23);
            this.btnNovoEst.TabIndex = 6;
            this.btnNovoEst.Text = "Novo";
            this.btnNovoEst.UseVisualStyleBackColor = true;
            this.btnNovoEst.Click += new System.EventHandler(this.btnNovoEst_Click);
            // 
            // btnExcluirEst
            // 
            this.btnExcluirEst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluirEst.Location = new System.Drawing.Point(673, 435);
            this.btnExcluirEst.Name = "btnExcluirEst";
            this.btnExcluirEst.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirEst.TabIndex = 8;
            this.btnExcluirEst.Text = "Excluir";
            this.btnExcluirEst.UseVisualStyleBackColor = true;
            this.btnExcluirEst.Click += new System.EventHandler(this.btnExcluirEst_Click);
            // 
            // frmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(760, 470);
            this.Controls.Add(this.btnExcluirEst);
            this.Controls.Add(this.btnVisualizarEst);
            this.Controls.Add(this.btnNovoEst);
            this.Controls.Add(this.pnlEst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProduto";
            this.Text = "frmEstoque";
            this.pnlEst.ResumeLayout(false);
            this.pnlEst.PerformLayout();
            this.ctrListaProd.ResumeLayout(false);
            this.tbSC.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEst;
        private System.Windows.Forms.Button btnVisualizarEst;
        private System.Windows.Forms.Button btnNovoEst;
        private System.Windows.Forms.Button btnExcluirEst;
        private System.Windows.Forms.ListView listProd;
        private System.Windows.Forms.TabControl ctrListaProd;
        private System.Windows.Forms.TabPage tbSC;
        private System.Windows.Forms.TabPage tbSF;
        private System.Windows.Forms.TabPage tbFA;
        private System.Windows.Forms.TabPage tbFW;
        private System.Windows.Forms.TabPage tbFreA;
        private System.Windows.Forms.TabPage tbFreW;
        private System.Windows.Forms.TabPage tbReb;
        private System.Windows.Forms.TabPage tbOut;
        private System.Windows.Forms.TextBox TxtBuscaNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscaNom;
    }
}