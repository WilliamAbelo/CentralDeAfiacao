namespace descktop
{
    partial class frmFornecedores
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
            this.pnlFor = new System.Windows.Forms.Panel();
            this.btnExcluirfor = new System.Windows.Forms.Button();
            this.btnVisualizarFor = new System.Windows.Forms.Button();
            this.btnNovofor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlFor
            // 
            this.pnlFor.Location = new System.Drawing.Point(13, 13);
            this.pnlFor.Name = "pnlFor";
            this.pnlFor.Size = new System.Drawing.Size(736, 412);
            this.pnlFor.TabIndex = 0;
            // 
            // btnExcluirfor
            // 
            this.btnExcluirfor.Location = new System.Drawing.Point(673, 435);
            this.btnExcluirfor.Name = "btnExcluirfor";
            this.btnExcluirfor.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirfor.TabIndex = 11;
            this.btnExcluirfor.Text = "Excluir";
            this.btnExcluirfor.UseVisualStyleBackColor = true;
            // 
            // btnVisualizarFor
            // 
            this.btnVisualizarFor.Location = new System.Drawing.Point(12, 435);
            this.btnVisualizarFor.Name = "btnVisualizarFor";
            this.btnVisualizarFor.Size = new System.Drawing.Size(75, 23);
            this.btnVisualizarFor.TabIndex = 10;
            this.btnVisualizarFor.Text = "Visualizar";
            this.btnVisualizarFor.UseVisualStyleBackColor = true;
            // 
            // btnNovofor
            // 
            this.btnNovofor.Location = new System.Drawing.Point(93, 435);
            this.btnNovofor.Name = "btnNovofor";
            this.btnNovofor.Size = new System.Drawing.Size(75, 23);
            this.btnNovofor.TabIndex = 9;
            this.btnNovofor.Text = "Novo";
            this.btnNovofor.UseVisualStyleBackColor = true;
            // 
            // frmFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(760, 470);
            this.Controls.Add(this.btnExcluirfor);
            this.Controls.Add(this.pnlFor);
            this.Controls.Add(this.btnVisualizarFor);
            this.Controls.Add(this.btnNovofor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFornecedores";
            this.Text = "frmDornecedores";
            this.ResumeLayout(false);
            //this.frmInicio.Resize += new System.EventHandler(this.frmInicio_Resize);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFor;
        private System.Windows.Forms.Button btnExcluirfor;
        private System.Windows.Forms.Button btnVisualizarFor;
        private System.Windows.Forms.Button btnNovofor;
    }
}