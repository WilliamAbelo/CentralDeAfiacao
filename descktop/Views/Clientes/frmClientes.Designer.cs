namespace descktop
{
    partial class frmClientes
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
            this.btnNovoCli = new System.Windows.Forms.Button();
            this.btnExcluirCli = new System.Windows.Forms.Button();
            this.btnVisualizarCli = new System.Windows.Forms.Button();
            this.pnlCli = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscaNom = new System.Windows.Forms.TextBox();
            this.btnBuscNom = new System.Windows.Forms.Button();
            this.ctrListaCli = new System.Windows.Forms.TabControl();
            this.tbSP = new System.Windows.Forms.TabPage();
            this.lstCli = new System.Windows.Forms.ListView();
            this.tbMG = new System.Windows.Forms.TabPage();
            this.tbPR = new System.Windows.Forms.TabPage();
            this.tbGO = new System.Windows.Forms.TabPage();
            this.tbMS = new System.Windows.Forms.TabPage();
            this.tbPA = new System.Windows.Forms.TabPage();
            this.tbTO = new System.Windows.Forms.TabPage();
            this.tbRJ = new System.Windows.Forms.TabPage();
            this.tbAC = new System.Windows.Forms.TabPage();
            this.tbAL = new System.Windows.Forms.TabPage();
            this.tbAP = new System.Windows.Forms.TabPage();
            this.tbAM = new System.Windows.Forms.TabPage();
            this.tbBA = new System.Windows.Forms.TabPage();
            this.tbCE = new System.Windows.Forms.TabPage();
            this.tbES = new System.Windows.Forms.TabPage();
            this.tbMA = new System.Windows.Forms.TabPage();
            this.tbMT = new System.Windows.Forms.TabPage();
            this.tbPB = new System.Windows.Forms.TabPage();
            this.tbPE = new System.Windows.Forms.TabPage();
            this.tbPI = new System.Windows.Forms.TabPage();
            this.tbRN = new System.Windows.Forms.TabPage();
            this.tbRS = new System.Windows.Forms.TabPage();
            this.tbRO = new System.Windows.Forms.TabPage();
            this.tbRR = new System.Windows.Forms.TabPage();
            this.tbSC = new System.Windows.Forms.TabPage();
            this.tbSE = new System.Windows.Forms.TabPage();
            this.tbDF = new System.Windows.Forms.TabPage();
            this.pnlCli.SuspendLayout();
            this.ctrListaCli.SuspendLayout();
            this.tbSP.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNovoCli
            // 
            this.btnNovoCli.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNovoCli.Location = new System.Drawing.Point(93, 435);
            this.btnNovoCli.Name = "btnNovoCli";
            this.btnNovoCli.Size = new System.Drawing.Size(75, 23);
            this.btnNovoCli.TabIndex = 2;
            this.btnNovoCli.Text = "Novo";
            this.btnNovoCli.UseVisualStyleBackColor = true;
            this.btnNovoCli.Click += new System.EventHandler(this.btnNovoCli_Click);
            // 
            // btnExcluirCli
            // 
            this.btnExcluirCli.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluirCli.Location = new System.Drawing.Point(673, 435);
            this.btnExcluirCli.Name = "btnExcluirCli";
            this.btnExcluirCli.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirCli.TabIndex = 4;
            this.btnExcluirCli.Text = "Excluir";
            this.btnExcluirCli.UseVisualStyleBackColor = true;
            this.btnExcluirCli.Click += new System.EventHandler(this.btnExcluirCli_Click);
            // 
            // btnVisualizarCli
            // 
            this.btnVisualizarCli.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVisualizarCli.Location = new System.Drawing.Point(12, 435);
            this.btnVisualizarCli.Name = "btnVisualizarCli";
            this.btnVisualizarCli.Size = new System.Drawing.Size(75, 23);
            this.btnVisualizarCli.TabIndex = 5;
            this.btnVisualizarCli.Text = "Visualizar";
            this.btnVisualizarCli.UseVisualStyleBackColor = true;
            this.btnVisualizarCli.Click += new System.EventHandler(this.btnVisualizarCli_Click);
            // 
            // pnlCli
            // 
            this.pnlCli.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCli.Controls.Add(this.label1);
            this.pnlCli.Controls.Add(this.txtBuscaNom);
            this.pnlCli.Controls.Add(this.btnBuscNom);
            this.pnlCli.Controls.Add(this.ctrListaCli);
            this.pnlCli.Location = new System.Drawing.Point(13, 12);
            this.pnlCli.Name = "pnlCli";
            this.pnlCli.Size = new System.Drawing.Size(736, 412);
            this.pnlCli.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(307, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome do Cliente";
            // 
            // txtBuscaNom
            // 
            this.txtBuscaNom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscaNom.Location = new System.Drawing.Point(395, 3);
            this.txtBuscaNom.Name = "txtBuscaNom";
            this.txtBuscaNom.Size = new System.Drawing.Size(231, 20);
            this.txtBuscaNom.TabIndex = 3;
            // 
            // btnBuscNom
            // 
            this.btnBuscNom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscNom.Location = new System.Drawing.Point(631, 2);
            this.btnBuscNom.Name = "btnBuscNom";
            this.btnBuscNom.Size = new System.Drawing.Size(101, 23);
            this.btnBuscNom.TabIndex = 2;
            this.btnBuscNom.Text = "Buscar Por Nome";
            this.btnBuscNom.UseVisualStyleBackColor = true;
            this.btnBuscNom.Click += new System.EventHandler(this.btnBuscNom_Click);
            // 
            // ctrListaCli
            // 
            this.ctrListaCli.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrListaCli.Controls.Add(this.tbAC);
            this.ctrListaCli.Controls.Add(this.tbAL);
            this.ctrListaCli.Controls.Add(this.tbAP);
            this.ctrListaCli.Controls.Add(this.tbAM);
            this.ctrListaCli.Controls.Add(this.tbBA);
            this.ctrListaCli.Controls.Add(this.tbCE);
            this.ctrListaCli.Controls.Add(this.tbES);
            this.ctrListaCli.Controls.Add(this.tbGO);
            this.ctrListaCli.Controls.Add(this.tbMA);
            this.ctrListaCli.Controls.Add(this.tbMT);
            this.ctrListaCli.Controls.Add(this.tbMS);
            this.ctrListaCli.Controls.Add(this.tbMG);
            this.ctrListaCli.Controls.Add(this.tbPA);
            this.ctrListaCli.Controls.Add(this.tbPB);
            this.ctrListaCli.Controls.Add(this.tbPR);
            this.ctrListaCli.Controls.Add(this.tbPE);
            this.ctrListaCli.Controls.Add(this.tbPI);
            this.ctrListaCli.Controls.Add(this.tbRJ);
            this.ctrListaCli.Controls.Add(this.tbRN);
            this.ctrListaCli.Controls.Add(this.tbRS);
            this.ctrListaCli.Controls.Add(this.tbRO);
            this.ctrListaCli.Controls.Add(this.tbRR);
            this.ctrListaCli.Controls.Add(this.tbSC);
            this.ctrListaCli.Controls.Add(this.tbSP);
            this.ctrListaCli.Controls.Add(this.tbSE);
            this.ctrListaCli.Controls.Add(this.tbTO);
            this.ctrListaCli.Controls.Add(this.tbDF);
            this.ctrListaCli.Location = new System.Drawing.Point(4, 31);
            this.ctrListaCli.Name = "ctrListaCli";
            this.ctrListaCli.SelectedIndex = 0;
            this.ctrListaCli.Size = new System.Drawing.Size(729, 378);
            this.ctrListaCli.TabIndex = 1;
            this.ctrListaCli.SelectedIndexChanged += new System.EventHandler(this.ctrListaCli_SelectedIndexChanged);
            // 
            // tbSP
            // 
            this.tbSP.Controls.Add(this.lstCli);
            this.tbSP.Location = new System.Drawing.Point(4, 22);
            this.tbSP.Name = "tbSP";
            this.tbSP.Padding = new System.Windows.Forms.Padding(3);
            this.tbSP.Size = new System.Drawing.Size(721, 352);
            this.tbSP.TabIndex = 0;
            this.tbSP.Text = "SP";
            this.tbSP.UseVisualStyleBackColor = true;
            // 
            // lstCli
            // 
            this.lstCli.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstCli.HideSelection = false;
            this.lstCli.Location = new System.Drawing.Point(6, 6);
            this.lstCli.Name = "lstCli";
            this.lstCli.Size = new System.Drawing.Size(709, 340);
            this.lstCli.TabIndex = 0;
            this.lstCli.UseCompatibleStateImageBehavior = false;
            // 
            // tbMG
            // 
            this.tbMG.Location = new System.Drawing.Point(4, 22);
            this.tbMG.Name = "tbMG";
            this.tbMG.Padding = new System.Windows.Forms.Padding(3);
            this.tbMG.Size = new System.Drawing.Size(721, 352);
            this.tbMG.TabIndex = 1;
            this.tbMG.Text = "MG";
            this.tbMG.UseVisualStyleBackColor = true;
            // 
            // tbPR
            // 
            this.tbPR.Location = new System.Drawing.Point(4, 22);
            this.tbPR.Name = "tbPR";
            this.tbPR.Size = new System.Drawing.Size(721, 352);
            this.tbPR.TabIndex = 2;
            this.tbPR.Text = "PR";
            this.tbPR.UseVisualStyleBackColor = true;
            // 
            // tbGO
            // 
            this.tbGO.Location = new System.Drawing.Point(4, 22);
            this.tbGO.Name = "tbGO";
            this.tbGO.Size = new System.Drawing.Size(721, 352);
            this.tbGO.TabIndex = 3;
            this.tbGO.Text = "GO";
            this.tbGO.UseVisualStyleBackColor = true;
            // 
            // tbMS
            // 
            this.tbMS.Location = new System.Drawing.Point(4, 22);
            this.tbMS.Name = "tbMS";
            this.tbMS.Size = new System.Drawing.Size(721, 352);
            this.tbMS.TabIndex = 4;
            this.tbMS.Text = "MS";
            this.tbMS.UseVisualStyleBackColor = true;
            // 
            // tbPA
            // 
            this.tbPA.Location = new System.Drawing.Point(4, 22);
            this.tbPA.Name = "tbPA";
            this.tbPA.Size = new System.Drawing.Size(721, 352);
            this.tbPA.TabIndex = 5;
            this.tbPA.Text = "PA";
            this.tbPA.UseVisualStyleBackColor = true;
            // 
            // tbTO
            // 
            this.tbTO.Location = new System.Drawing.Point(4, 22);
            this.tbTO.Name = "tbTO";
            this.tbTO.Size = new System.Drawing.Size(721, 352);
            this.tbTO.TabIndex = 6;
            this.tbTO.Text = "TO";
            this.tbTO.UseVisualStyleBackColor = true;
            // 
            // tbRJ
            // 
            this.tbRJ.Location = new System.Drawing.Point(4, 22);
            this.tbRJ.Name = "tbRJ";
            this.tbRJ.Size = new System.Drawing.Size(721, 352);
            this.tbRJ.TabIndex = 7;
            this.tbRJ.Text = "RJ";
            this.tbRJ.UseVisualStyleBackColor = true;
            // 
            // tbAC
            // 
            this.tbAC.Location = new System.Drawing.Point(4, 22);
            this.tbAC.Name = "tbAC";
            this.tbAC.Size = new System.Drawing.Size(721, 352);
            this.tbAC.TabIndex = 8;
            this.tbAC.Text = "AC";
            this.tbAC.UseVisualStyleBackColor = true;
            // 
            // tbAL
            // 
            this.tbAL.Location = new System.Drawing.Point(4, 22);
            this.tbAL.Name = "tbAL";
            this.tbAL.Size = new System.Drawing.Size(721, 352);
            this.tbAL.TabIndex = 9;
            this.tbAL.Text = "AL";
            this.tbAL.UseVisualStyleBackColor = true;
            // 
            // tbAP
            // 
            this.tbAP.Location = new System.Drawing.Point(4, 22);
            this.tbAP.Name = "tbAP";
            this.tbAP.Size = new System.Drawing.Size(721, 352);
            this.tbAP.TabIndex = 10;
            this.tbAP.Text = "AP";
            this.tbAP.UseVisualStyleBackColor = true;
            // 
            // tbAM
            // 
            this.tbAM.Location = new System.Drawing.Point(4, 22);
            this.tbAM.Name = "tbAM";
            this.tbAM.Size = new System.Drawing.Size(721, 352);
            this.tbAM.TabIndex = 11;
            this.tbAM.Text = "AM";
            this.tbAM.UseVisualStyleBackColor = true;
            // 
            // tbBA
            // 
            this.tbBA.Location = new System.Drawing.Point(4, 22);
            this.tbBA.Name = "tbBA";
            this.tbBA.Size = new System.Drawing.Size(721, 352);
            this.tbBA.TabIndex = 12;
            this.tbBA.Text = "BA";
            this.tbBA.UseVisualStyleBackColor = true;
            // 
            // tbCE
            // 
            this.tbCE.Location = new System.Drawing.Point(4, 22);
            this.tbCE.Name = "tbCE";
            this.tbCE.Size = new System.Drawing.Size(721, 352);
            this.tbCE.TabIndex = 13;
            this.tbCE.Text = "CE";
            this.tbCE.UseVisualStyleBackColor = true;
            // 
            // tbES
            // 
            this.tbES.Location = new System.Drawing.Point(4, 22);
            this.tbES.Name = "tbES";
            this.tbES.Size = new System.Drawing.Size(721, 352);
            this.tbES.TabIndex = 14;
            this.tbES.Text = "ES";
            this.tbES.UseVisualStyleBackColor = true;
            // 
            // tbMA
            // 
            this.tbMA.Location = new System.Drawing.Point(4, 22);
            this.tbMA.Name = "tbMA";
            this.tbMA.Size = new System.Drawing.Size(721, 352);
            this.tbMA.TabIndex = 15;
            this.tbMA.Text = "MA";
            this.tbMA.UseVisualStyleBackColor = true;
            // 
            // tbMT
            // 
            this.tbMT.Location = new System.Drawing.Point(4, 22);
            this.tbMT.Name = "tbMT";
            this.tbMT.Size = new System.Drawing.Size(721, 352);
            this.tbMT.TabIndex = 16;
            this.tbMT.Text = "MT";
            this.tbMT.UseVisualStyleBackColor = true;
            // 
            // tbPB
            // 
            this.tbPB.Location = new System.Drawing.Point(4, 22);
            this.tbPB.Name = "tbPB";
            this.tbPB.Size = new System.Drawing.Size(721, 352);
            this.tbPB.TabIndex = 17;
            this.tbPB.Text = "PB";
            this.tbPB.UseVisualStyleBackColor = true;
            // 
            // tbPE
            // 
            this.tbPE.Location = new System.Drawing.Point(4, 22);
            this.tbPE.Name = "tbPE";
            this.tbPE.Size = new System.Drawing.Size(721, 352);
            this.tbPE.TabIndex = 18;
            this.tbPE.Text = "PE";
            this.tbPE.UseVisualStyleBackColor = true;
            // 
            // tbPI
            // 
            this.tbPI.Location = new System.Drawing.Point(4, 22);
            this.tbPI.Name = "tbPI";
            this.tbPI.Size = new System.Drawing.Size(721, 352);
            this.tbPI.TabIndex = 19;
            this.tbPI.Text = "PI";
            this.tbPI.UseVisualStyleBackColor = true;
            // 
            // tbRN
            // 
            this.tbRN.Location = new System.Drawing.Point(4, 22);
            this.tbRN.Name = "tbRN";
            this.tbRN.Size = new System.Drawing.Size(721, 352);
            this.tbRN.TabIndex = 20;
            this.tbRN.Text = "RN";
            this.tbRN.UseVisualStyleBackColor = true;
            // 
            // tbRS
            // 
            this.tbRS.Location = new System.Drawing.Point(4, 22);
            this.tbRS.Name = "tbRS";
            this.tbRS.Size = new System.Drawing.Size(721, 352);
            this.tbRS.TabIndex = 21;
            this.tbRS.Text = "RS";
            this.tbRS.UseVisualStyleBackColor = true;
            // 
            // tbRO
            // 
            this.tbRO.Location = new System.Drawing.Point(4, 22);
            this.tbRO.Name = "tbRO";
            this.tbRO.Size = new System.Drawing.Size(721, 352);
            this.tbRO.TabIndex = 22;
            this.tbRO.Text = "RO";
            this.tbRO.UseVisualStyleBackColor = true;
            // 
            // tbRR
            // 
            this.tbRR.Location = new System.Drawing.Point(4, 22);
            this.tbRR.Name = "tbRR";
            this.tbRR.Size = new System.Drawing.Size(721, 352);
            this.tbRR.TabIndex = 23;
            this.tbRR.Text = "RR";
            this.tbRR.UseVisualStyleBackColor = true;
            // 
            // tbSC
            // 
            this.tbSC.Location = new System.Drawing.Point(4, 22);
            this.tbSC.Name = "tbSC";
            this.tbSC.Size = new System.Drawing.Size(721, 352);
            this.tbSC.TabIndex = 24;
            this.tbSC.Text = "SC";
            this.tbSC.UseVisualStyleBackColor = true;
            // 
            // tbSE
            // 
            this.tbSE.Location = new System.Drawing.Point(4, 22);
            this.tbSE.Name = "tbSE";
            this.tbSE.Size = new System.Drawing.Size(721, 352);
            this.tbSE.TabIndex = 25;
            this.tbSE.Text = "SE";
            this.tbSE.UseVisualStyleBackColor = true;
            // 
            // tbDF
            // 
            this.tbDF.Location = new System.Drawing.Point(4, 22);
            this.tbDF.Name = "tbDF";
            this.tbDF.Size = new System.Drawing.Size(721, 352);
            this.tbDF.TabIndex = 26;
            this.tbDF.Text = "DF";
            this.tbDF.UseVisualStyleBackColor = true;
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(760, 470);
            this.Controls.Add(this.btnExcluirCli);
            this.Controls.Add(this.btnVisualizarCli);
            this.Controls.Add(this.btnNovoCli);
            this.Controls.Add(this.pnlCli);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmClientes";
            this.Text = "frmClientes";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            this.pnlCli.ResumeLayout(false);
            this.pnlCli.PerformLayout();
            this.ctrListaCli.ResumeLayout(false);
            this.tbSP.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnNovoCli;
        private System.Windows.Forms.Button btnExcluirCli;
        private System.Windows.Forms.Button btnVisualizarCli;
        private System.Windows.Forms.Panel pnlCli;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscaNom;
        private System.Windows.Forms.Button btnBuscNom;
        private System.Windows.Forms.TabControl ctrListaCli;
        private System.Windows.Forms.TabPage tbSP;
        private System.Windows.Forms.ListView lstCli;
        private System.Windows.Forms.TabPage tbMG;
        private System.Windows.Forms.TabPage tbPR;
        private System.Windows.Forms.TabPage tbGO;
        private System.Windows.Forms.TabPage tbMS;
        private System.Windows.Forms.TabPage tbPA;
        private System.Windows.Forms.TabPage tbTO;
        private System.Windows.Forms.TabPage tbRJ;
        private System.Windows.Forms.TabPage tbAC;
        private System.Windows.Forms.TabPage tbAL;
        private System.Windows.Forms.TabPage tbAP;
        private System.Windows.Forms.TabPage tbAM;
        private System.Windows.Forms.TabPage tbBA;
        private System.Windows.Forms.TabPage tbCE;
        private System.Windows.Forms.TabPage tbES;
        private System.Windows.Forms.TabPage tbMA;
        private System.Windows.Forms.TabPage tbMT;
        private System.Windows.Forms.TabPage tbPB;
        private System.Windows.Forms.TabPage tbPE;
        private System.Windows.Forms.TabPage tbPI;
        private System.Windows.Forms.TabPage tbRN;
        private System.Windows.Forms.TabPage tbRS;
        private System.Windows.Forms.TabPage tbRO;
        private System.Windows.Forms.TabPage tbRR;
        private System.Windows.Forms.TabPage tbSC;
        private System.Windows.Forms.TabPage tbSE;
        private System.Windows.Forms.TabPage tbDF;
    }
}