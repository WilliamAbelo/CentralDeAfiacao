namespace descktop.Views.Fornecedores
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
            this.SuspendLayout();
            // 
            // btnDetVoltar
            // 
            this.btnDetVoltar.Location = new System.Drawing.Point(12, 435);
            this.btnDetVoltar.Name = "btnDetVoltar";
            this.btnDetVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnDetVoltar.TabIndex = 3;
            this.btnDetVoltar.Text = "<- Voltar";
            this.btnDetVoltar.UseVisualStyleBackColor = true;
            // 
            // frmDetalhes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(760, 470);
            this.Controls.Add(this.btnDetVoltar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDetalhes";
            this.Text = "frmDetalhes";
            this.ResumeLayout(false);
            //this.frmInicio.Resize += new System.EventHandler(this.frmInicio_Resize);

        }

        #endregion

        private System.Windows.Forms.Button btnDetVoltar;
    }
}