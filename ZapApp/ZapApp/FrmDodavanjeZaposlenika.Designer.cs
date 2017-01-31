namespace ZapApp
{
    partial class FrmDodavanjeZaposlenika
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
            this.components = new System.ComponentModel.Container();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cmbOdjel = new System.Windows.Forms.ComboBox();
            this.odjeliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._16011_DBDataSet = new ZapApp._16011_DBDataSet();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.statusZaposlenikaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtOIB = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtMobitel = new System.Windows.Forms.TextBox();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.statusZaposlenikaTableAdapter = new ZapApp._16011_DBDataSetTableAdapters.statusZaposlenikaTableAdapter();
            this.odjeliTableAdapter = new ZapApp._16011_DBDataSetTableAdapters.OdjeliTableAdapter();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.odjeliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._16011_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusZaposlenikaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cmbOdjel);
            this.groupBox5.Controls.Add(this.cmbStatus);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.txtEmail);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.txtOIB);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.txtMobitel);
            this.groupBox5.Controls.Add(this.txtAdresa);
            this.groupBox5.Controls.Add(this.txtLozinka);
            this.groupBox5.Controls.Add(this.txtKorisnickoIme);
            this.groupBox5.Controls.Add(this.txtPrezime);
            this.groupBox5.Controls.Add(this.txtIme);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Location = new System.Drawing.Point(20, 20);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(284, 311);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Dodavanje/ažuriranje zaposlenika";
            // 
            // cmbOdjel
            // 
            this.cmbOdjel.DataSource = this.odjeliBindingSource;
            this.cmbOdjel.DisplayMember = "naziv";
            this.cmbOdjel.FormattingEnabled = true;
            this.cmbOdjel.Location = new System.Drawing.Point(141, 259);
            this.cmbOdjel.Name = "cmbOdjel";
            this.cmbOdjel.Size = new System.Drawing.Size(100, 21);
            this.cmbOdjel.TabIndex = 28;
            this.cmbOdjel.ValueMember = "id";
            this.cmbOdjel.Visible = false;
            // 
            // odjeliBindingSource
            // 
            this.odjeliBindingSource.DataMember = "Odjeli";
            this.odjeliBindingSource.DataSource = this._16011_DBDataSet;
            // 
            // _16011_DBDataSet
            // 
            this._16011_DBDataSet.DataSetName = "_16011_DBDataSet";
            this._16011_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbStatus
            // 
            this.cmbStatus.DataSource = this.statusZaposlenikaBindingSource;
            this.cmbStatus.DisplayMember = "naziv";
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(141, 232);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(100, 21);
            this.cmbStatus.TabIndex = 27;
            this.cmbStatus.ValueMember = "id";
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
            // 
            // statusZaposlenikaBindingSource
            // 
            this.statusZaposlenikaBindingSource.DataMember = "statusZaposlenika";
            this.statusZaposlenikaBindingSource.DataSource = this._16011_DBDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Odjel";
            this.label1.Visible = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(141, 209);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 24;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(19, 209);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 13);
            this.label16.TabIndex = 23;
            this.label16.Text = "E-mail: ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(19, 235);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 13);
            this.label15.TabIndex = 22;
            this.label15.Text = "Status: ";
            // 
            // txtOIB
            // 
            this.txtOIB.Location = new System.Drawing.Point(141, 183);
            this.txtOIB.Name = "txtOIB";
            this.txtOIB.Size = new System.Drawing.Size(100, 20);
            this.txtOIB.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 183);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 13);
            this.label14.TabIndex = 20;
            this.label14.Text = "OIB: ";
            // 
            // txtMobitel
            // 
            this.txtMobitel.Location = new System.Drawing.Point(141, 157);
            this.txtMobitel.Name = "txtMobitel";
            this.txtMobitel.Size = new System.Drawing.Size(100, 20);
            this.txtMobitel.TabIndex = 17;
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(141, 131);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(100, 20);
            this.txtAdresa.TabIndex = 16;
            // 
            // txtLozinka
            // 
            this.txtLozinka.Location = new System.Drawing.Point(141, 104);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.Size = new System.Drawing.Size(100, 20);
            this.txtLozinka.TabIndex = 12;
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Location = new System.Drawing.Point(141, 78);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(100, 20);
            this.txtKorisnickoIme.TabIndex = 11;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(141, 52);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(100, 20);
            this.txtPrezime.TabIndex = 10;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(141, 26);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(100, 20);
            this.txtIme.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 157);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Mobitel: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Adresa: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Lozinka: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Korisničko ime: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Prezime: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ime: ";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(204, 337);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(100, 48);
            this.btnDodaj.TabIndex = 7;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(98, 337);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(100, 48);
            this.btnSpremi.TabIndex = 8;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // statusZaposlenikaTableAdapter
            // 
            this.statusZaposlenikaTableAdapter.ClearBeforeFill = true;
            // 
            // odjeliTableAdapter
            // 
            this.odjeliTableAdapter.ClearBeforeFill = true;
            // 
            // FrmDodavanjeZaposlenika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 403);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.groupBox5);
            this.Name = "FrmDodavanjeZaposlenika";
            this.Text = "Dodavanje zaposlenika";
            this.Load += new System.EventHandler(this.FrmDodavanjeZaposlenika_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.odjeliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._16011_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusZaposlenikaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtOIB;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtMobitel;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.TextBox txtKorisnickoIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.ComboBox cmbOdjel;
        private System.Windows.Forms.ComboBox cmbStatus;
        private _16011_DBDataSet _16011_DBDataSet;
        private System.Windows.Forms.BindingSource statusZaposlenikaBindingSource;
        private _16011_DBDataSetTableAdapters.statusZaposlenikaTableAdapter statusZaposlenikaTableAdapter;
        private System.Windows.Forms.BindingSource odjeliBindingSource;
        private _16011_DBDataSetTableAdapters.OdjeliTableAdapter odjeliTableAdapter;
    }
}