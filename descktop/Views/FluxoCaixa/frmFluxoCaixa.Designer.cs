namespace descktop.Views.FluxoCaixa
{
    partial class frmFluxoCaixa
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
            this.btnReceb = new System.Windows.Forms.Button();
            this.btnPaga = new System.Windows.Forms.Button();
            this.pcFluxo = new System.Windows.Forms.Panel();
            this.lstPag = new System.Windows.Forms.ListView();
            this.lstReceb = new System.Windows.Forms.ListView();
            this.pcFluxo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReceb
            // 
            this.btnReceb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReceb.Location = new System.Drawing.Point(608, 12);
            this.btnReceb.Name = "btnReceb";
            this.btnReceb.Size = new System.Drawing.Size(72, 23);
            this.btnReceb.TabIndex = 19;
            this.btnReceb.Text = "A Receber";
            this.btnReceb.UseVisualStyleBackColor = true;
            this.btnReceb.Click += new System.EventHandler(this.btnReceb_Click_1);
            // 
            // btnPaga
            // 
            this.btnPaga.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPaga.Location = new System.Drawing.Point(686, 12);
            this.btnPaga.Name = "btnPaga";
            this.btnPaga.Size = new System.Drawing.Size(62, 23);
            this.btnPaga.TabIndex = 18;
            this.btnPaga.Text = "A Pagar";
            this.btnPaga.UseVisualStyleBackColor = true;
            this.btnPaga.Click += new System.EventHandler(this.btnPaga_Click_1);
            // 
            // pcFluxo
            // 
            this.pcFluxo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pcFluxo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcFluxo.Controls.Add(this.lstPag);
            this.pcFluxo.Controls.Add(this.lstReceb);
            this.pcFluxo.Location = new System.Drawing.Point(12, 41);
            this.pcFluxo.Name = "pcFluxo";
            this.pcFluxo.Size = new System.Drawing.Size(736, 417);
            this.pcFluxo.TabIndex = 20;
            // 
            // lstPag
            // 
            this.lstPag.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstPag.HideSelection = false;
            this.lstPag.Location = new System.Drawing.Point(4, 236);
            this.lstPag.Name = "lstPag";
            this.lstPag.Size = new System.Drawing.Size(727, 176);
            this.lstPag.TabIndex = 1;
            this.lstPag.UseCompatibleStateImageBehavior = false;
            // 
            // lstReceb
            // 
            this.lstReceb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstReceb.HideSelection = false;
            this.lstReceb.Location = new System.Drawing.Point(4, 4);
            this.lstReceb.Name = "lstReceb";
            this.lstReceb.Size = new System.Drawing.Size(727, 197);
            this.lstReceb.TabIndex = 0;
            this.lstReceb.UseCompatibleStateImageBehavior = false;
            // 
            // frmFluxoCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(760, 470);
            this.Controls.Add(this.pcFluxo);
            this.Controls.Add(this.btnReceb);
            this.Controls.Add(this.btnPaga);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFluxoCaixa";
            this.Text = "frmFluxoCaixa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pcFluxo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReceb;
        private System.Windows.Forms.Button btnPaga;
        private System.Windows.Forms.ListView lstReceb;
        private System.Windows.Forms.ListView lstPag;
        public System.Windows.Forms.Panel pcFluxo;
    }
}