namespace descktop
{
    partial class frmPaga
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
            this.pnlPag = new System.Windows.Forms.Panel();
            this.ctrDividas = new System.Windows.Forms.TabControl();
            this.tbJaPagos = new System.Windows.Forms.TabPage();
            this.tbAPagar = new System.Windows.Forms.TabPage();
            this.lstDividas = new System.Windows.Forms.ListView();
            this.btnNovoPag = new System.Windows.Forms.Button();
            this.btnDetalhes = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.pnlPag.SuspendLayout();
            this.ctrDividas.SuspendLayout();
            this.tbAPagar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPag
            // 
            this.pnlPag.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPag.Controls.Add(this.ctrDividas);
            this.pnlPag.Location = new System.Drawing.Point(12, 12);
            this.pnlPag.Name = "pnlPag";
            this.pnlPag.Size = new System.Drawing.Size(712, 364);
            this.pnlPag.TabIndex = 0;
            // 
            // ctrDividas
            // 
            this.ctrDividas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrDividas.Controls.Add(this.tbJaPagos);
            this.ctrDividas.Controls.Add(this.tbAPagar);
            this.ctrDividas.Location = new System.Drawing.Point(4, 3);
            this.ctrDividas.Name = "ctrDividas";
            this.ctrDividas.SelectedIndex = 0;
            this.ctrDividas.Size = new System.Drawing.Size(705, 358);
            this.ctrDividas.TabIndex = 1;
            this.ctrDividas.SelectedIndexChanged += new System.EventHandler(this.ctrDividas_SelectedIndexChanged);
            // 
            // tbJaPagos
            // 
            this.tbJaPagos.Location = new System.Drawing.Point(4, 22);
            this.tbJaPagos.Name = "tbJaPagos";
            this.tbJaPagos.Padding = new System.Windows.Forms.Padding(3);
            this.tbJaPagos.Size = new System.Drawing.Size(697, 332);
            this.tbJaPagos.TabIndex = 0;
            this.tbJaPagos.Text = "Ja Pagos";
            this.tbJaPagos.UseVisualStyleBackColor = true;
            // 
            // tbAPagar
            // 
            this.tbAPagar.Controls.Add(this.lstDividas);
            this.tbAPagar.Location = new System.Drawing.Point(4, 22);
            this.tbAPagar.Name = "tbAPagar";
            this.tbAPagar.Padding = new System.Windows.Forms.Padding(3);
            this.tbAPagar.Size = new System.Drawing.Size(697, 332);
            this.tbAPagar.TabIndex = 1;
            this.tbAPagar.Text = "A pagar";
            this.tbAPagar.UseVisualStyleBackColor = true;
            // 
            // lstDividas
            // 
            this.lstDividas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstDividas.HideSelection = false;
            this.lstDividas.Location = new System.Drawing.Point(6, 6);
            this.lstDividas.Name = "lstDividas";
            this.lstDividas.Size = new System.Drawing.Size(684, 320);
            this.lstDividas.TabIndex = 1;
            this.lstDividas.UseCompatibleStateImageBehavior = false;
            this.lstDividas.SelectedIndexChanged += new System.EventHandler(this.lstDividas_SelectedIndexChanged);
            // 
            // btnNovoPag
            // 
            this.btnNovoPag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNovoPag.Location = new System.Drawing.Point(93, 382);
            this.btnNovoPag.Name = "btnNovoPag";
            this.btnNovoPag.Size = new System.Drawing.Size(75, 23);
            this.btnNovoPag.TabIndex = 1;
            this.btnNovoPag.Text = "Novo";
            this.btnNovoPag.UseVisualStyleBackColor = true;
            this.btnNovoPag.Click += new System.EventHandler(this.btnNovoPag_Click);
            // 
            // btnDetalhes
            // 
            this.btnDetalhes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDetalhes.Location = new System.Drawing.Point(12, 382);
            this.btnDetalhes.Name = "btnDetalhes";
            this.btnDetalhes.Size = new System.Drawing.Size(75, 23);
            this.btnDetalhes.TabIndex = 2;
            this.btnDetalhes.Text = "Visualizar";
            this.btnDetalhes.UseVisualStyleBackColor = true;
            this.btnDetalhes.Click += new System.EventHandler(this.btnDetalhes_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluir.Location = new System.Drawing.Point(649, 382);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // frmPaga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(736, 417);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnDetalhes);
            this.Controls.Add(this.btnNovoPag);
            this.Controls.Add(this.pnlPag);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPaga";
            this.Text = "frmPaga";
            this.pnlPag.ResumeLayout(false);
            this.ctrDividas.ResumeLayout(false);
            this.tbAPagar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPag;
        private System.Windows.Forms.Button btnNovoPag;
        private System.Windows.Forms.Button btnDetalhes;
        private System.Windows.Forms.TabControl ctrDividas;
        private System.Windows.Forms.TabPage tbJaPagos;
        private System.Windows.Forms.TabPage tbAPagar;
        private System.Windows.Forms.ListView lstDividas;
        private System.Windows.Forms.Button btnExcluir;
    }
}