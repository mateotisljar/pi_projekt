namespace ZapApp
{
    partial class FrmEvidencijaDolazaka
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEvidencijaDolazaka));
            this.btnPrijaviDolazak = new System.Windows.Forms.Button();
            this.btnPrijaviPauzu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.satnicaTableAdapter1 = new ZapApp._16011_DBDataSetTableAdapters.SatnicaTableAdapter();
            this.lblStanjeSati = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPrijaviDolazak
            // 
            this.btnPrijaviDolazak.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrijaviDolazak.Location = new System.Drawing.Point(12, 135);
            this.btnPrijaviDolazak.Name = "btnPrijaviDolazak";
            this.btnPrijaviDolazak.Size = new System.Drawing.Size(97, 92);
            this.btnPrijaviDolazak.TabIndex = 0;
            this.btnPrijaviDolazak.Text = "Prijavi dolazak na posao";
            this.btnPrijaviDolazak.UseVisualStyleBackColor = true;
            this.btnPrijaviDolazak.Click += new System.EventHandler(this.btnPrijaviDolazak_Click);
            // 
            // btnPrijaviPauzu
            // 
            this.btnPrijaviPauzu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrijaviPauzu.Location = new System.Drawing.Point(288, 135);
            this.btnPrijaviPauzu.Name = "btnPrijaviPauzu";
            this.btnPrijaviPauzu.Size = new System.Drawing.Size(97, 92);
            this.btnPrijaviPauzu.TabIndex = 1;
            this.btnPrijaviPauzu.Text = "Prijavi odlazak na pauzu";
            this.btnPrijaviPauzu.UseVisualStyleBackColor = true;
            this.btnPrijaviPauzu.Click += new System.EventHandler(this.btnPrijaviPauzu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Broj dolazaka na posao:";
            // 
            // satnicaTableAdapter1
            // 
            this.satnicaTableAdapter1.ClearBeforeFill = true;
            // 
            // lblStanjeSati
            // 
            this.lblStanjeSati.AutoSize = true;
            this.lblStanjeSati.Location = new System.Drawing.Point(247, 175);
            this.lblStanjeSati.Name = "lblStanjeSati";
            this.lblStanjeSati.Size = new System.Drawing.Size(35, 13);
            this.lblStanjeSati.TabIndex = 13;
            this.lblStanjeSati.Text = "label3";
            // 
            // FrmEvidencijaDolazaka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ZapApp.Properties.Resources.zaposlenici2;
            this.ClientSize = new System.Drawing.Size(392, 234);
            this.Controls.Add(this.lblStanjeSati);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPrijaviPauzu);
            this.Controls.Add(this.btnPrijaviDolazak);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmEvidencijaDolazaka";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Evidencija dolazaka";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSatnica_FormClosing);
            this.Load += new System.EventHandler(this.FrmSatnica_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmSatnica_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrijaviDolazak;
        private System.Windows.Forms.Button btnPrijaviPauzu;
        private System.Windows.Forms.Label label1;
        private _16011_DBDataSetTableAdapters.SatnicaTableAdapter satnicaTableAdapter1;
        private System.Windows.Forms.Label lblStanjeSati;
        
    }
}