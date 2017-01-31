namespace ZapApp
{
    partial class FrmZaposlenici
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTrazi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID_zaposlenika_Trazi = new System.Windows.Forms.TextBox();
            this.dgvZaposlenici = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.odjeliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._16011_DBDataSet = new ZapApp._16011_DBDataSet();
            this.btnPostavi = new System.Windows.Forms.Button();
            this.btnLista = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnDodajNovog = new System.Windows.Forms.Button();
            this.btnAzurirajTrenutnog = new System.Windows.Forms.Button();
            this.odjeliTableAdapter = new ZapApp._16011_DBDataSetTableAdapters.OdjeliTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnMakniVoditelja = new System.Windows.Forms.Button();
            this.lbl_X = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_X = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposlenici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odjeliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._16011_DBDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel_X.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTrazi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtID_zaposlenika_Trazi);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(709, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 70);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pretraga zaposlenika";
            // 
            // btnTrazi
            // 
            this.btnTrazi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTrazi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrazi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrazi.ForeColor = System.Drawing.Color.White;
            this.btnTrazi.Location = new System.Drawing.Point(321, 20);
            this.btnTrazi.Name = "btnTrazi";
            this.btnTrazi.Size = new System.Drawing.Size(75, 44);
            this.btnTrazi.TabIndex = 2;
            this.btnTrazi.Text = "Traži";
            this.btnTrazi.UseVisualStyleBackColor = false;
            this.btnTrazi.Click += new System.EventHandler(this.btnTrazi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Korisničko ime: ";
            // 
            // txtID_zaposlenika_Trazi
            // 
            this.txtID_zaposlenika_Trazi.Location = new System.Drawing.Point(128, 35);
            this.txtID_zaposlenika_Trazi.Name = "txtID_zaposlenika_Trazi";
            this.txtID_zaposlenika_Trazi.Size = new System.Drawing.Size(187, 28);
            this.txtID_zaposlenika_Trazi.TabIndex = 0;
            // 
            // dgvZaposlenici
            // 
            this.dgvZaposlenici.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvZaposlenici.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvZaposlenici.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvZaposlenici.BackgroundColor = System.Drawing.Color.White;
            this.dgvZaposlenici.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvZaposlenici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvZaposlenici.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvZaposlenici.Location = new System.Drawing.Point(252, 106);
            this.dgvZaposlenici.Name = "dgvZaposlenici";
            this.dgvZaposlenici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvZaposlenici.Size = new System.Drawing.Size(971, 365);
            this.dgvZaposlenici.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.odjeliBindingSource;
            this.comboBox1.DisplayMember = "naziv";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(51, 383);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(137, 21);
            this.comboBox1.TabIndex = 22;
            this.comboBox1.ValueMember = "id";
            this.comboBox1.Visible = false;
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
            // btnPostavi
            // 
            this.btnPostavi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPostavi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPostavi.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPostavi.ForeColor = System.Drawing.Color.White;
            this.btnPostavi.Location = new System.Drawing.Point(50, 408);
            this.btnPostavi.Name = "btnPostavi";
            this.btnPostavi.Size = new System.Drawing.Size(137, 59);
            this.btnPostavi.TabIndex = 21;
            this.btnPostavi.Text = "Postavi za voditelja";
            this.btnPostavi.UseVisualStyleBackColor = true;
            this.btnPostavi.Visible = false;
            this.btnPostavi.Click += new System.EventHandler(this.btnPostavi_Click);
            // 
            // btnLista
            // 
            this.btnLista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLista.FlatAppearance.BorderSize = 0;
            this.btnLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLista.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLista.ForeColor = System.Drawing.Color.White;
            this.btnLista.Location = new System.Drawing.Point(0, 162);
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(246, 49);
            this.btnLista.TabIndex = 20;
            this.btnLista.Text = "Lista zaposlenika";
            this.btnLista.UseCompatibleTextRendering = true;
            this.btnLista.UseVisualStyleBackColor = true;
            this.btnLista.Click += new System.EventHandler(this.btnLista_Click);
            this.btnLista.MouseEnter += new System.EventHandler(this.btnLista_MouseEnter);
            this.btnLista.MouseLeave += new System.EventHandler(this.btnLista_MouseLeave);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnObrisi.FlatAppearance.BorderSize = 0;
            this.btnObrisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObrisi.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnObrisi.ForeColor = System.Drawing.Color.White;
            this.btnObrisi.Location = new System.Drawing.Point(0, 218);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(246, 49);
            this.btnObrisi.TabIndex = 2;
            this.btnObrisi.Text = "Obriši odabranog zaposlenika";
            this.btnObrisi.UseCompatibleTextRendering = true;
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Visible = false;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            this.btnObrisi.MouseEnter += new System.EventHandler(this.btnObrisi_MouseEnter);
            this.btnObrisi.MouseLeave += new System.EventHandler(this.btnObrisi_MouseLeave);
            // 
            // btnDodajNovog
            // 
            this.btnDodajNovog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDodajNovog.FlatAppearance.BorderSize = 0;
            this.btnDodajNovog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajNovog.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajNovog.ForeColor = System.Drawing.Color.White;
            this.btnDodajNovog.Location = new System.Drawing.Point(0, 107);
            this.btnDodajNovog.Name = "btnDodajNovog";
            this.btnDodajNovog.Size = new System.Drawing.Size(246, 49);
            this.btnDodajNovog.TabIndex = 1;
            this.btnDodajNovog.Text = "Dodaj novog zaposlenika";
            this.btnDodajNovog.UseCompatibleTextRendering = true;
            this.btnDodajNovog.UseVisualStyleBackColor = true;
            this.btnDodajNovog.Click += new System.EventHandler(this.btnDodajNovog_Click);
            this.btnDodajNovog.MouseEnter += new System.EventHandler(this.btnDodajNovog_MouseEnter);
            this.btnDodajNovog.MouseLeave += new System.EventHandler(this.btnDodajNovog_MouseLeave);
            // 
            // btnAzurirajTrenutnog
            // 
            this.btnAzurirajTrenutnog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAzurirajTrenutnog.FlatAppearance.BorderSize = 0;
            this.btnAzurirajTrenutnog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAzurirajTrenutnog.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAzurirajTrenutnog.ForeColor = System.Drawing.Color.White;
            this.btnAzurirajTrenutnog.Location = new System.Drawing.Point(1, 273);
            this.btnAzurirajTrenutnog.Name = "btnAzurirajTrenutnog";
            this.btnAzurirajTrenutnog.Size = new System.Drawing.Size(246, 49);
            this.btnAzurirajTrenutnog.TabIndex = 0;
            this.btnAzurirajTrenutnog.Text = "Profil zaposlenika";
            this.btnAzurirajTrenutnog.UseCompatibleTextRendering = true;
            this.btnAzurirajTrenutnog.UseVisualStyleBackColor = true;
            this.btnAzurirajTrenutnog.Visible = false;
            this.btnAzurirajTrenutnog.Click += new System.EventHandler(this.btnAzurirajTrenutnog_Click);
            this.btnAzurirajTrenutnog.MouseEnter += new System.EventHandler(this.btnAzurirajTrenutnog_MouseEnter);
            this.btnAzurirajTrenutnog.MouseLeave += new System.EventHandler(this.btnAzurirajTrenutnog_MouseLeave);
            // 
            // odjeliTableAdapter
            // 
            this.odjeliTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.btnMakniVoditelja);
            this.panel1.Controls.Add(this.btnAzurirajTrenutnog);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.btnObrisi);
            this.panel1.Controls.Add(this.btnPostavi);
            this.panel1.Controls.Add(this.btnDodajNovog);
            this.panel1.Controls.Add(this.btnLista);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 678);
            this.panel1.TabIndex = 9;
            // 
            // panel9
            // 
            this.panel9.Location = new System.Drawing.Point(0, 107);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(11, 49);
            this.panel9.TabIndex = 25;
            // 
            // panel8
            // 
            this.panel8.Location = new System.Drawing.Point(0, 162);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(11, 49);
            this.panel8.TabIndex = 25;
            // 
            // panel7
            // 
            this.panel7.Location = new System.Drawing.Point(0, 218);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(11, 49);
            this.panel7.TabIndex = 25;
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(0, 273);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(11, 49);
            this.panel6.TabIndex = 25;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(0, 328);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(11, 49);
            this.panel5.TabIndex = 24;
            // 
            // btnMakniVoditelja
            // 
            this.btnMakniVoditelja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMakniVoditelja.FlatAppearance.BorderSize = 0;
            this.btnMakniVoditelja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMakniVoditelja.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMakniVoditelja.ForeColor = System.Drawing.Color.White;
            this.btnMakniVoditelja.Location = new System.Drawing.Point(1, 328);
            this.btnMakniVoditelja.Name = "btnMakniVoditelja";
            this.btnMakniVoditelja.Size = new System.Drawing.Size(246, 49);
            this.btnMakniVoditelja.TabIndex = 23;
            this.btnMakniVoditelja.Text = "Makni poziciju voditelja";
            this.btnMakniVoditelja.UseCompatibleTextRendering = true;
            this.btnMakniVoditelja.UseVisualStyleBackColor = false;
            this.btnMakniVoditelja.Visible = false;
            this.btnMakniVoditelja.Click += new System.EventHandler(this.btnMakniVoditelja_Click);
            this.btnMakniVoditelja.MouseEnter += new System.EventHandler(this.btnMakniVoditelja_MouseEnter);
            this.btnMakniVoditelja.MouseLeave += new System.EventHandler(this.btnMakniVoditelja_MouseLeave);
            // 
            // lbl_X
            // 
            this.lbl_X.AutoSize = true;
            this.lbl_X.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_X.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_X.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_X.Location = new System.Drawing.Point(6, 5);
            this.lbl_X.Name = "lbl_X";
            this.lbl_X.Size = new System.Drawing.Size(21, 20);
            this.lbl_X.TabIndex = 1;
            this.lbl_X.Text = "X";
            this.lbl_X.Click += new System.EventHandler(this.lbl_X_Click);
            this.lbl_X.MouseEnter += new System.EventHandler(this.panel_X_MouseEnter);
            this.lbl_X.MouseLeave += new System.EventHandler(this.panel_X_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(374, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 47);
            this.label2.TabIndex = 0;
            this.label2.Text = "Zaposlenici";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel_X);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1233, 100);
            this.panel2.TabIndex = 10;
            // 
            // panel_X
            // 
            this.panel_X.Controls.Add(this.lbl_X);
            this.panel_X.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel_X.Location = new System.Drawing.Point(1189, 8);
            this.panel_X.Name = "panel_X";
            this.panel_X.Size = new System.Drawing.Size(33, 30);
            this.panel_X.TabIndex = 12;
            this.panel_X.Click += new System.EventHandler(this.lbl_X_Click);
            this.panel_X.MouseEnter += new System.EventHandler(this.panel_X_MouseEnter);
            this.panel_X.MouseLeave += new System.EventHandler(this.panel_X_MouseLeave);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(0, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(245, 99);
            this.panel4.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Banner", 28F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(48, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 55);
            this.label3.TabIndex = 2;
            this.label3.Text = "ZapApp";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel3.Controls.Add(this.lblInfo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 477);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1233, 30);
            this.panel3.TabIndex = 11;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblInfo.ForeColor = System.Drawing.Color.White;
            this.lblInfo.Location = new System.Drawing.Point(12, 8);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 16);
            this.lblInfo.TabIndex = 0;
            // 
            // FrmZaposlenici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1233, 507);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvZaposlenici);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmZaposlenici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zaposlenici";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmZaposlenici_FormClosed);
            this.Load += new System.EventHandler(this.FrmZaposlenici_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmZaposlenici_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposlenici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odjeliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._16011_DBDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel_X.ResumeLayout(false);
            this.panel_X.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTrazi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID_zaposlenika_Trazi;
        private System.Windows.Forms.DataGridView dgvZaposlenici;
        private System.Windows.Forms.Button btnPostavi;
        private System.Windows.Forms.Button btnLista;
        private _16011_DBDataSet _16011_DBDataSet;
        private System.Windows.Forms.Button btnDodajNovog;
        private System.Windows.Forms.Button btnAzurirajTrenutnog;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource odjeliBindingSource;
        private _16011_DBDataSetTableAdapters.OdjeliTableAdapter odjeliTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_X;
        private System.Windows.Forms.Button btnMakniVoditelja;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel_X;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
    }
}