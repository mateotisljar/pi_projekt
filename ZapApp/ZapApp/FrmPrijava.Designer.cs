namespace ZapApp
{
    partial class FrmPrijava
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrijava));
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.btnPrijava = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblGreske = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLozinka
            // 
            this.txtLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtLozinka.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtLozinka.Location = new System.Drawing.Point(93, 40);
            this.txtLozinka.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLozinka.Multiline = true;
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.Size = new System.Drawing.Size(391, 52);
            this.txtLozinka.TabIndex = 8;
            this.txtLozinka.Click += new System.EventHandler(this.txtLozinka_Click);
            this.txtLozinka.Enter += new System.EventHandler(this.txtLozinka_Enter);
            this.txtLozinka.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLozinka_KeyDown);
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtKorisnickoIme.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtKorisnickoIme.Location = new System.Drawing.Point(93, 37);
            this.txtKorisnickoIme.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtKorisnickoIme.Multiline = true;
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(391, 52);
            this.txtKorisnickoIme.TabIndex = 0;
            this.txtKorisnickoIme.Click += new System.EventHandler(this.txtKorisnickoIme_Click);
            this.txtKorisnickoIme.TextChanged += new System.EventHandler(this.txtKorisnickoIme_TextChanged);
            this.txtKorisnickoIme.Enter += new System.EventHandler(this.txtKorisnickoIme_Enter);
            this.txtKorisnickoIme.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLozinka_KeyDown);
            // 
            // btnPrijava
            // 
            this.btnPrijava.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPrijava.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrijava.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPrijava.FlatAppearance.BorderSize = 0;
            this.btnPrijava.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrijava.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrijava.ForeColor = System.Drawing.SystemColors.Window;
            this.btnPrijava.Location = new System.Drawing.Point(462, 557);
            this.btnPrijava.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.Size = new System.Drawing.Size(195, 48);
            this.btnPrijava.TabIndex = 2;
            this.btnPrijava.Text = "Prijavi se";
            this.btnPrijava.UseVisualStyleBackColor = false;
            this.btnPrijava.Click += new System.EventHandler(this.btnPrijava_Click);
            this.btnPrijava.MouseEnter += new System.EventHandler(this.btnPrijava_MouseEnter);
            this.btnPrijava.MouseLeave += new System.EventHandler(this.btnPrijava_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Location = new System.Drawing.Point(48, 162);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(578, 3);
            this.panel1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Banner", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(38, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(451, 59);
            this.label3.TabIndex = 0;
            this.label3.Text = "Prijava u korisnički račun";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtKorisnickoIme);
            this.panel2.Location = new System.Drawing.Point(0, 202);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(676, 131);
            this.panel2.TabIndex = 9;
            this.panel2.MouseHover += new System.EventHandler(this.panel2_MouseHover);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.txtLozinka);
            this.panel3.Location = new System.Drawing.Point(0, 342);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(676, 131);
            this.panel3.TabIndex = 10;
            this.panel3.MouseHover += new System.EventHandler(this.panel3_MouseHover);
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(18, 131);
            this.panel5.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(0, 202);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(18, 131);
            this.panel4.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(616, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(20, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "ZapApp";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel6.Location = new System.Drawing.Point(48, 512);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(578, 3);
            this.panel6.TabIndex = 4;
            // 
            // lblGreske
            // 
            this.lblGreske.AutoSize = true;
            this.lblGreske.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblGreske.ForeColor = System.Drawing.Color.Maroon;
            this.lblGreske.Location = new System.Drawing.Point(93, 483);
            this.lblGreske.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGreske.Name = "lblGreske";
            this.lblGreske.Size = new System.Drawing.Size(0, 25);
            this.lblGreske.TabIndex = 13;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblInfo.Location = new System.Drawing.Point(20, 623);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 25);
            this.lblInfo.TabIndex = 14;
            // 
            // FrmPrijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(675, 657);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblGreske);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnPrijava);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmPrijava";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prijava";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPrijava_FormClosed);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.TextBox txtKorisnickoIme;
        private System.Windows.Forms.Button btnPrijava;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblGreske;
        private System.Windows.Forms.Label lblInfo;
    }
}