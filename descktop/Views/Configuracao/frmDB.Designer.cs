namespace descktop.Views.Configuracao
{
    partial class frmDB
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnProp = new System.Windows.Forms.Button();
            this.btnBck = new System.Windows.Forms.Button();
            this.lstDB = new System.Windows.Forms.ListView();
            this.btnExecutarQuery = new System.Windows.Forms.Button();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnProp);
            this.panel1.Controls.Add(this.btnBck);
            this.panel1.Controls.Add(this.lstDB);
            this.panel1.Controls.Add(this.btnExecutarQuery);
            this.panel1.Controls.Add(this.txtQuery);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(735, 416);
            this.panel1.TabIndex = 0;
            // 
            // btnProp
            // 
            this.btnProp.Location = new System.Drawing.Point(537, 388);
            this.btnProp.Name = "btnProp";
            this.btnProp.Size = new System.Drawing.Size(96, 23);
            this.btnProp.TabIndex = 46;
            this.btnProp.Text = "Listar Tabelas";
            this.btnProp.UseVisualStyleBackColor = true;
            this.btnProp.Click += new System.EventHandler(this.btnProp_Click);
            // 
            // btnBck
            // 
            this.btnBck.Location = new System.Drawing.Point(3, 388);
            this.btnBck.Name = "btnBck";
            this.btnBck.Size = new System.Drawing.Size(75, 23);
            this.btnBck.TabIndex = 44;
            this.btnBck.Text = "BackUp";
            this.btnBck.UseVisualStyleBackColor = true;
            this.btnBck.Click += new System.EventHandler(this.btnBck_Click);
            // 
            // lstDB
            // 
            this.lstDB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstDB.HideSelection = false;
            this.lstDB.Location = new System.Drawing.Point(4, 26);
            this.lstDB.Name = "lstDB";
            this.lstDB.Size = new System.Drawing.Size(726, 192);
            this.lstDB.TabIndex = 43;
            this.lstDB.UseCompatibleStateImageBehavior = false;
            // 
            // btnExecutarQuery
            // 
            this.btnExecutarQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExecutarQuery.Location = new System.Drawing.Point(639, 388);
            this.btnExecutarQuery.Name = "btnExecutarQuery";
            this.btnExecutarQuery.Size = new System.Drawing.Size(91, 23);
            this.btnExecutarQuery.TabIndex = 41;
            this.btnExecutarQuery.Text = "Executar Query";
            this.btnExecutarQuery.UseVisualStyleBackColor = true;
            this.btnExecutarQuery.Click += new System.EventHandler(this.btnExecutarQuery_Click);
            // 
            // txtQuery
            // 
            this.txtQuery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuery.Location = new System.Drawing.Point(3, 224);
            this.txtQuery.Multiline = true;
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(727, 158);
            this.txtQuery.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Nome da Empresa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Empresa:";
            // 
            // btnvoltar
            // 
            this.btnvoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnvoltar.Location = new System.Drawing.Point(12, 435);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(75, 23);
            this.btnvoltar.TabIndex = 1;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            // 
            // btnAplicar
            // 
            this.btnAplicar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAplicar.Location = new System.Drawing.Point(673, 435);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(75, 23);
            this.btnAplicar.TabIndex = 2;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.UseVisualStyleBackColor = true;
            // 
            // frmDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(760, 470);
            this.Controls.Add(this.btnAplicar);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDB";
            this.Text = "frmDB";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExecutarQuery;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.ListView lstDB;
        private System.Windows.Forms.Button btnBck;
        private System.Windows.Forms.Button btnProp;
    }
}