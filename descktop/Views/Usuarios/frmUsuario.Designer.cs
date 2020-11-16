namespace descktop
{
    partial class frmUsuario
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
            this.pnlUsu = new System.Windows.Forms.Panel();
            this.btnExcluirUsu = new System.Windows.Forms.Button();
            this.btnVisualizarUsu = new System.Windows.Forms.Button();
            this.btnNovoUsu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlUsu
            // 
            this.pnlUsu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlUsu.Location = new System.Drawing.Point(13, 13);
            this.pnlUsu.Name = "pnlUsu";
            this.pnlUsu.Size = new System.Drawing.Size(736, 412);
            this.pnlUsu.TabIndex = 0;
            // 
            // btnExcluirUsu
            // 
            this.btnExcluirUsu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluirUsu.Location = new System.Drawing.Point(673, 435);
            this.btnExcluirUsu.Name = "btnExcluirUsu";
            this.btnExcluirUsu.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirUsu.TabIndex = 11;
            this.btnExcluirUsu.Text = "Excluir";
            this.btnExcluirUsu.UseVisualStyleBackColor = true;
            // 
            // btnVisualizarUsu
            // 
            this.btnVisualizarUsu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVisualizarUsu.Location = new System.Drawing.Point(12, 435);
            this.btnVisualizarUsu.Name = "btnVisualizarUsu";
            this.btnVisualizarUsu.Size = new System.Drawing.Size(75, 23);
            this.btnVisualizarUsu.TabIndex = 10;
            this.btnVisualizarUsu.Text = "Visualizar";
            this.btnVisualizarUsu.UseVisualStyleBackColor = true;
            // 
            // btnNovoUsu
            // 
            this.btnNovoUsu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNovoUsu.Location = new System.Drawing.Point(93, 435);
            this.btnNovoUsu.Name = "btnNovoUsu";
            this.btnNovoUsu.Size = new System.Drawing.Size(75, 23);
            this.btnNovoUsu.TabIndex = 9;
            this.btnNovoUsu.Text = "Novo";
            this.btnNovoUsu.UseVisualStyleBackColor = true;
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(760, 470);
            this.Controls.Add(this.btnExcluirUsu);
            this.Controls.Add(this.btnVisualizarUsu);
            this.Controls.Add(this.btnNovoUsu);
            this.Controls.Add(this.pnlUsu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUsuario";
            this.Text = "frmUsuario";
            this.ResumeLayout(false);
            //this.frmInicio.Resize += new System.EventHandler(this.frmInicio_Resize);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUsu;
        private System.Windows.Forms.Button btnExcluirUsu;
        private System.Windows.Forms.Button btnVisualizarUsu;
        private System.Windows.Forms.Button btnNovoUsu;
    }
}