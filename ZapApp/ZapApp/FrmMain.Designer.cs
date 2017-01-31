namespace ZapApp
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btnPrijava = new System.Windows.Forms.Button();
            this.btnDodavanjeZaposlenika = new System.Windows.Forms.Button();
            this.btnPopuniRaspored = new System.Windows.Forms.Button();
            this.btnEvidencijaDolazaka = new System.Windows.Forms.Button();
            this.lblPrijava = new System.Windows.Forms.Label();
            this.lblUloga = new System.Windows.Forms.Label();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_X = new System.Windows.Forms.Panel();
            this.lbl_X = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel_X.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPrijava
            // 
            this.btnPrijava.BackColor = System.Drawing.Color.White;
            this.btnPrijava.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrijava.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnPrijava.FlatAppearance.BorderSize = 2;
            this.btnPrijava.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrijava.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrijava.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnPrijava.Location = new System.Drawing.Point(758, 12);
            this.btnPrijava.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.Size = new System.Drawing.Size(122, 65);
            this.btnPrijava.TabIndex = 0;
            this.btnPrijava.Text = "PRIJAVA";
            this.btnPrijava.UseVisualStyleBackColor = false;
            this.btnPrijava.Click += new System.EventHandler(this.btnPrijava_Click);
            this.btnPrijava.MouseEnter += new System.EventHandler(this.btnPrijava_MouseEnter);
            this.btnPrijava.MouseLeave += new System.EventHandler(this.btnPrijava_MouseLeave);
            // 
            // btnDodavanjeZaposlenika
            // 
            this.btnDodavanjeZaposlenika.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDodavanjeZaposlenika.FlatAppearance.BorderSize = 0;
            this.btnDodavanjeZaposlenika.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnDodavanjeZaposlenika.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodavanjeZaposlenika.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodavanjeZaposlenika.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnDodavanjeZaposlenika.Location = new System.Drawing.Point(0, 111);
            this.btnDodavanjeZaposlenika.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDodavanjeZaposlenika.Name = "btnDodavanjeZaposlenika";
            this.btnDodavanjeZaposlenika.Size = new System.Drawing.Size(291, 75);
            this.btnDodavanjeZaposlenika.TabIndex = 1;
            this.btnDodavanjeZaposlenika.Text = "Dodavanje/brisanje/ažuriranje zaposlenika";
            this.btnDodavanjeZaposlenika.UseVisualStyleBackColor = true;
            this.btnDodavanjeZaposlenika.Click += new System.EventHandler(this.btnDodavanjeZaposlenika_Click);
            this.btnDodavanjeZaposlenika.MouseEnter += new System.EventHandler(this.btnDodavanjeZaposlenika_MouseEnter);
            this.btnDodavanjeZaposlenika.MouseLeave += new System.EventHandler(this.btnDodavanjeZaposlenika_MouseLeave);
            // 
            // btnPopuniRaspored
            // 
            this.btnPopuniRaspored.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPopuniRaspored.FlatAppearance.BorderSize = 0;
            this.btnPopuniRaspored.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnPopuniRaspored.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPopuniRaspored.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPopuniRaspored.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnPopuniRaspored.Location = new System.Drawing.Point(0, 195);
            this.btnPopuniRaspored.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPopuniRaspored.Name = "btnPopuniRaspored";
            this.btnPopuniRaspored.Size = new System.Drawing.Size(291, 77);
            this.btnPopuniRaspored.TabIndex = 2;
            this.btnPopuniRaspored.Text = "Pregled/popunjavanje rasporeda";
            this.btnPopuniRaspored.UseVisualStyleBackColor = true;
            this.btnPopuniRaspored.Click += new System.EventHandler(this.btnPopuniRaspored_Click);
            this.btnPopuniRaspored.MouseEnter += new System.EventHandler(this.btnPopuniRaspored_MouseEnter);
            this.btnPopuniRaspored.MouseLeave += new System.EventHandler(this.btnPopuniRaspored_MouseLeave);
            // 
            // btnEvidencijaDolazaka
            // 
            this.btnEvidencijaDolazaka.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEvidencijaDolazaka.FlatAppearance.BorderSize = 0;
            this.btnEvidencijaDolazaka.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnEvidencijaDolazaka.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEvidencijaDolazaka.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEvidencijaDolazaka.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnEvidencijaDolazaka.Location = new System.Drawing.Point(0, 282);
            this.btnEvidencijaDolazaka.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEvidencijaDolazaka.Name = "btnEvidencijaDolazaka";
            this.btnEvidencijaDolazaka.Size = new System.Drawing.Size(291, 77);
            this.btnEvidencijaDolazaka.TabIndex = 3;
            this.btnEvidencijaDolazaka.Text = "Evidencija dolazaka";
            this.btnEvidencijaDolazaka.UseVisualStyleBackColor = true;
            this.btnEvidencijaDolazaka.Click += new System.EventHandler(this.btnEvidencijaDolazaka_Click);
            this.btnEvidencijaDolazaka.MouseEnter += new System.EventHandler(this.btnEvidencijaDolazaka_MouseEnter);
            this.btnEvidencijaDolazaka.MouseLeave += new System.EventHandler(this.btnEvidencijaDolazaka_MouseLeave);
            // 
            // lblPrijava
            // 
            this.lblPrijava.AutoSize = true;
            this.lblPrijava.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPrijava.ForeColor = System.Drawing.Color.White;
            this.lblPrijava.Location = new System.Drawing.Point(18, 620);
            this.lblPrijava.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrijava.Name = "lblPrijava";
            this.lblPrijava.Size = new System.Drawing.Size(0, 18);
            this.lblPrijava.TabIndex = 5;
            // 
            // lblUloga
            // 
            this.lblUloga.AutoSize = true;
            this.lblUloga.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUloga.ForeColor = System.Drawing.Color.White;
            this.lblUloga.Location = new System.Drawing.Point(18, 665);
            this.lblUloga.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUloga.Name = "lblUloga";
            this.lblUloga.Size = new System.Drawing.Size(0, 18);
            this.lblUloga.TabIndex = 6;
            // 
            // btnOdjava
            // 
            this.btnOdjava.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOdjava.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOdjava.FlatAppearance.BorderSize = 2;
            this.btnOdjava.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnOdjava.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdjava.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdjava.ForeColor = System.Drawing.Color.White;
            this.btnOdjava.Location = new System.Drawing.Point(21, 705);
            this.btnOdjava.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(122, 49);
            this.btnOdjava.TabIndex = 7;
            this.btnOdjava.Text = "ODJAVA";
            this.btnOdjava.UseVisualStyleBackColor = true;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            this.btnOdjava.MouseEnter += new System.EventHandler(this.btnOdjava_MouseEnter);
            this.btnOdjava.MouseLeave += new System.EventHandler(this.btnOdjava_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.btnDodavanjeZaposlenika);
            this.panel1.Controls.Add(this.btnPopuniRaspored);
            this.panel1.Controls.Add(this.lblUloga);
            this.panel1.Controls.Add(this.btnEvidencijaDolazaka);
            this.panel1.Controls.Add(this.lblPrijava);
            this.panel1.Controls.Add(this.btnOdjava);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 834);
            this.panel1.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(0, 86);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(291, 8);
            this.panel4.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel_X);
            this.panel2.Controls.Add(this.btnPrijava);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(291, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(955, 77);
            this.panel2.TabIndex = 11;
            // 
            // panel_X
            // 
            this.panel_X.Controls.Add(this.lbl_X);
            this.panel_X.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel_X.Location = new System.Drawing.Point(888, 5);
            this.panel_X.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_X.Name = "panel_X";
            this.panel_X.Size = new System.Drawing.Size(50, 46);
            this.panel_X.TabIndex = 13;
            this.panel_X.Click += new System.EventHandler(this.panel_X_Click);
            this.panel_X.MouseEnter += new System.EventHandler(this.panel_X_MouseEnter);
            this.panel_X.MouseLeave += new System.EventHandler(this.panel_X_MouseLeave);
            // 
            // lbl_X
            // 
            this.lbl_X.AutoSize = true;
            this.lbl_X.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_X.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_X.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_X.Location = new System.Drawing.Point(9, 8);
            this.lbl_X.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_X.Name = "lbl_X";
            this.lbl_X.Size = new System.Drawing.Size(31, 29);
            this.lbl_X.TabIndex = 1;
            this.lbl_X.Text = "X";
            this.lbl_X.Click += new System.EventHandler(this.panel_X_Click);
            this.lbl_X.MouseEnter += new System.EventHandler(this.panel_X_MouseEnter);
            this.lbl_X.MouseLeave += new System.EventHandler(this.panel_X_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(209, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(465, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dobrodošli na aplikaciju ZapApp";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel3.Location = new System.Drawing.Point(291, 86);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(956, 8);
            this.panel3.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label2.Location = new System.Drawing.Point(324, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(872, 296);
            this.label2.TabIndex = 12;
            this.label2.Tag = "X";
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1246, 834);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZapApp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMain_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel_X.ResumeLayout(false);
            this.panel_X.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrijava;
        private System.Windows.Forms.Button btnDodavanjeZaposlenika;
        private System.Windows.Forms.Button btnPopuniRaspored;
        private System.Windows.Forms.Button btnEvidencijaDolazaka;
        private System.Windows.Forms.Label lblPrijava;
        private System.Windows.Forms.Label lblUloga;
        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel_X;
        private System.Windows.Forms.Label lbl_X;
    }
}

