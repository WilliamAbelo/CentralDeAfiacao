namespace descktop
{
    partial class frmPedidos
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
            this.venContainer = new System.Windows.Forms.Panel();
            this.pnPag = new System.Windows.Forms.Panel();
            this.lblPage = new System.Windows.Forms.Label();
            this.btnPagMais = new System.Windows.Forms.Button();
            this.btnPagMenos = new System.Windows.Forms.Button();
            this.btnBuscaNom = new System.Windows.Forms.Button();
            this.txtBuscaNom = new System.Windows.Forms.TextBox();
            this.ctrListaPed = new System.Windows.Forms.TabControl();
            this.tbFin = new System.Windows.Forms.TabPage();
            this.tbAbr = new System.Windows.Forms.TabPage();
            this.lstVendas = new System.Windows.Forms.ListView();
            this.label7 = new System.Windows.Forms.Label();
            this.btnExcluirVen = new System.Windows.Forms.Button();
            this.btnVisualizarVen = new System.Windows.Forms.Button();
            this.btnNovoPed = new System.Windows.Forms.Button();
            this.venContainer.SuspendLayout();
            this.pnPag.SuspendLayout();
            this.ctrListaPed.SuspendLayout();
            this.tbAbr.SuspendLayout();
            this.SuspendLayout();
            // 
            // venContainer
            // 
            this.venContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.venContainer.Controls.Add(this.pnPag);
            this.venContainer.Controls.Add(this.btnBuscaNom);
            this.venContainer.Controls.Add(this.txtBuscaNom);
            this.venContainer.Controls.Add(this.ctrListaPed);
            this.venContainer.Controls.Add(this.label7);
            this.venContainer.Location = new System.Drawing.Point(13, 12);
            this.venContainer.Name = "venContainer";
            this.venContainer.Size = new System.Drawing.Size(736, 413);
            this.venContainer.TabIndex = 0;
            // 
            // pnPag
            // 
            this.pnPag.Controls.Add(this.lblPage);
            this.pnPag.Controls.Add(this.btnPagMais);
            this.pnPag.Controls.Add(this.btnPagMenos);
            this.pnPag.Location = new System.Drawing.Point(6, 1);
            this.pnPag.Name = "pnPag";
            this.pnPag.Size = new System.Drawing.Size(149, 27);
            this.pnPag.TabIndex = 0;
            this.pnPag.Visible = false;
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.Location = new System.Drawing.Point(66, 7);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(37, 13);
            this.lblPage.TabIndex = 20;
            this.lblPage.Text = "... 0 ...";
            // 
            // btnPagMais
            // 
            this.btnPagMais.Location = new System.Drawing.Point(124, 2);
            this.btnPagMais.Name = "btnPagMais";
            this.btnPagMais.Size = new System.Drawing.Size(22, 22);
            this.btnPagMais.TabIndex = 19;
            this.btnPagMais.Text = ">";
            this.btnPagMais.UseVisualStyleBackColor = true;
            this.btnPagMais.Click += new System.EventHandler(this.btnPagMais_Click);
            // 
            // btnPagMenos
            // 
            this.btnPagMenos.Enabled = false;
            this.btnPagMenos.Location = new System.Drawing.Point(3, 3);
            this.btnPagMenos.Name = "btnPagMenos";
            this.btnPagMenos.Size = new System.Drawing.Size(51, 22);
            this.btnPagMenos.TabIndex = 13;
            this.btnPagMenos.Text = "Inicio";
            this.btnPagMenos.UseVisualStyleBackColor = true;
            this.btnPagMenos.Click += new System.EventHandler(this.btnPagMenos_Click);
            // 
            // btnBuscaNom
            // 
            this.btnBuscaNom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscaNom.Location = new System.Drawing.Point(631, 2);
            this.btnBuscaNom.Name = "btnBuscaNom";
            this.btnBuscaNom.Size = new System.Drawing.Size(102, 23);
            this.btnBuscaNom.TabIndex = 12;
            this.btnBuscaNom.Text = "Buscar Por Nome";
            this.btnBuscaNom.UseVisualStyleBackColor = true;
            this.btnBuscaNom.Click += new System.EventHandler(this.btnBuscarNmAbe_Click);
            // 
            // txtBuscaNom
            // 
            this.txtBuscaNom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscaNom.Location = new System.Drawing.Point(395, 3);
            this.txtBuscaNom.Name = "txtBuscaNom";
            this.txtBuscaNom.Size = new System.Drawing.Size(231, 20);
            this.txtBuscaNom.TabIndex = 11;
            // 
            // ctrListaPed
            // 
            this.ctrListaPed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrListaPed.Controls.Add(this.tbFin);
            this.ctrListaPed.Controls.Add(this.tbAbr);
            this.ctrListaPed.Location = new System.Drawing.Point(4, 29);
            this.ctrListaPed.Name = "ctrListaPed";
            this.ctrListaPed.SelectedIndex = 0;
            this.ctrListaPed.Size = new System.Drawing.Size(729, 381);
            this.ctrListaPed.TabIndex = 1;
            this.ctrListaPed.SelectedIndexChanged += new System.EventHandler(this.ctrListaPed_SelectedIndexChanged);
            // 
            // tbFin
            // 
            this.tbFin.Location = new System.Drawing.Point(4, 22);
            this.tbFin.Name = "tbFin";
            this.tbFin.Padding = new System.Windows.Forms.Padding(3);
            this.tbFin.Size = new System.Drawing.Size(721, 355);
            this.tbFin.TabIndex = 0;
            this.tbFin.Text = "Pedidos Finalizados";
            this.tbFin.UseVisualStyleBackColor = true;
            // 
            // tbAbr
            // 
            this.tbAbr.Controls.Add(this.lstVendas);
            this.tbAbr.Location = new System.Drawing.Point(4, 22);
            this.tbAbr.Name = "tbAbr";
            this.tbAbr.Padding = new System.Windows.Forms.Padding(3);
            this.tbAbr.Size = new System.Drawing.Size(721, 355);
            this.tbAbr.TabIndex = 1;
            this.tbAbr.Text = "Pedidos em Aberto";
            this.tbAbr.UseVisualStyleBackColor = true;
            // 
            // lstVendas
            // 
            this.lstVendas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstVendas.HideSelection = false;
            this.lstVendas.Location = new System.Drawing.Point(6, 6);
            this.lstVendas.Name = "lstVendas";
            this.lstVendas.Size = new System.Drawing.Size(709, 340);
            this.lstVendas.TabIndex = 1;
            this.lstVendas.UseCompatibleStateImageBehavior = false;
            this.lstVendas.SelectedIndexChanged += new System.EventHandler(this.lstVendas_SelectedIndexChanged_1);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(307, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Nome do Cliente";
            // 
            // btnExcluirVen
            // 
            this.btnExcluirVen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluirVen.Location = new System.Drawing.Point(673, 435);
            this.btnExcluirVen.Name = "btnExcluirVen";
            this.btnExcluirVen.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirVen.TabIndex = 11;
            this.btnExcluirVen.Text = "Excluir";
            this.btnExcluirVen.UseVisualStyleBackColor = true;
            this.btnExcluirVen.Click += new System.EventHandler(this.btnExcluirVen_Click);
            // 
            // btnVisualizarVen
            // 
            this.btnVisualizarVen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVisualizarVen.Location = new System.Drawing.Point(12, 435);
            this.btnVisualizarVen.Name = "btnVisualizarVen";
            this.btnVisualizarVen.Size = new System.Drawing.Size(75, 23);
            this.btnVisualizarVen.TabIndex = 10;
            this.btnVisualizarVen.Text = "Visualizar";
            this.btnVisualizarVen.UseVisualStyleBackColor = true;
            this.btnVisualizarVen.Click += new System.EventHandler(this.btnVisualizarVen_Click);
            // 
            // btnNovoPed
            // 
            this.btnNovoPed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNovoPed.Location = new System.Drawing.Point(93, 435);
            this.btnNovoPed.Name = "btnNovoPed";
            this.btnNovoPed.Size = new System.Drawing.Size(75, 23);
            this.btnNovoPed.TabIndex = 9;
            this.btnNovoPed.Text = "Novo";
            this.btnNovoPed.UseVisualStyleBackColor = true;
            this.btnNovoPed.Click += new System.EventHandler(this.btnNovoPed_Click);
            // 
            // frmPedidos
            // 
            this.AcceptButton = this.btnBuscaNom;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(760, 470);
            this.Controls.Add(this.btnExcluirVen);
            this.Controls.Add(this.btnVisualizarVen);
            this.Controls.Add(this.btnNovoPed);
            this.Controls.Add(this.venContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPedidos";
            this.Text = "frmVendas";
            this.Load += new System.EventHandler(this.frmPedidos_Load);
            this.venContainer.ResumeLayout(false);
            this.venContainer.PerformLayout();
            this.pnPag.ResumeLayout(false);
            this.pnPag.PerformLayout();
            this.ctrListaPed.ResumeLayout(false);
            this.tbAbr.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel venContainer;
        private System.Windows.Forms.Button btnExcluirVen;
        private System.Windows.Forms.Button btnVisualizarVen;
        private System.Windows.Forms.Button btnNovoPed;
        private System.Windows.Forms.TabControl ctrListaPed;
        private System.Windows.Forms.TabPage tbFin;
        private System.Windows.Forms.TabPage tbAbr;
        private System.Windows.Forms.Button btnBuscaNom;
        private System.Windows.Forms.TextBox txtBuscaNom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView lstVendas;
        private System.Windows.Forms.Button btnPagMenos;
        private System.Windows.Forms.Button btnPagMais;
        private System.Windows.Forms.Panel pnPag;
        private System.Windows.Forms.Label lblPage;
    }
}