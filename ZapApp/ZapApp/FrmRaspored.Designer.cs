namespace ZapApp
{
    partial class FrmRaspored
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRaspored));
            this.lblPrva = new System.Windows.Forms.Label();
            this.lblDruga = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnPrikaziZahtjeve = new System.Windows.Forms.Button();
            this.btnDodajPrvu = new System.Windows.Forms.Button();
            this.btnDodajDrugu = new System.Windows.Forms.Button();
            this.btnDodajTrecu = new System.Windows.Forms.Button();
            this.dgvPrikazRasporeda = new System.Windows.Forms.DataGridView();
            this.oIBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korImeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lozinkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odjeliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zaposleniciBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this._16011_DBDataSet = new ZapApp._16011_DBDataSet();
            this.lblTreca = new System.Windows.Forms.Label();
            this.btnIzmjeni = new System.Windows.Forms.Button();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.zaposleniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbDodajZaposlenika = new System.Windows.Forms.ComboBox();
            this.zaposleniciBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dBDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._16011_DBDataSet1 = new ZapApp._16011_DBDataSet1();
            this.zaposleniciTableAdapter = new ZapApp._16011_DBDataSetTableAdapters.ZaposleniciTableAdapter();
            this.tableAdapterManager = new ZapApp._16011_DBDataSetTableAdapters.TableAdapterManager();
            this.rasporedTableAdapter1 = new ZapApp._16011_DBDataSetTableAdapters.RasporedTableAdapter();
            this.zaposlenici_rasporedTableAdapter1 = new ZapApp._16011_DBDataSetTableAdapters.Zaposlenici_rasporedTableAdapter();
            this.zaposleniciTableAdapter1 = new ZapApp._16011_DBDataSet1TableAdapters.ZaposleniciTableAdapter();
            this.btnBrisi = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikazRasporeda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposleniciBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._16011_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zaposleniciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposleniciBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._16011_DBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPrva
            // 
            this.lblPrva.AutoSize = true;
            this.lblPrva.Location = new System.Drawing.Point(437, 9);
            this.lblPrva.Name = "lblPrva";
            this.lblPrva.Size = new System.Drawing.Size(71, 13);
            this.lblPrva.TabIndex = 3;
            this.lblPrva.Text = "Prva smjena: ";
            // 
            // lblDruga
            // 
            this.lblDruga.AutoSize = true;
            this.lblDruga.Location = new System.Drawing.Point(437, 9);
            this.lblDruga.Name = "lblDruga";
            this.lblDruga.Size = new System.Drawing.Size(78, 13);
            this.lblDruga.TabIndex = 4;
            this.lblDruga.Text = "Druga smjena: ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(73, 109);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(244, 20);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnPrikaziZahtjeve
            // 
            this.btnPrikaziZahtjeve.Location = new System.Drawing.Point(102, 26);
            this.btnPrikaziZahtjeve.Name = "btnPrikaziZahtjeve";
            this.btnPrikaziZahtjeve.Size = new System.Drawing.Size(177, 62);
            this.btnPrikaziZahtjeve.TabIndex = 7;
            this.btnPrikaziZahtjeve.Text = "Prikazati zahtjeve za promjenama";
            this.btnPrikaziZahtjeve.UseVisualStyleBackColor = true;
            this.btnPrikaziZahtjeve.Click += new System.EventHandler(this.btnPrikaziZahtjeve_Click);
            // 
            // btnDodajPrvu
            // 
            this.btnDodajPrvu.Location = new System.Drawing.Point(73, 174);
            this.btnDodajPrvu.Name = "btnDodajPrvu";
            this.btnDodajPrvu.Size = new System.Drawing.Size(244, 40);
            this.btnDodajPrvu.TabIndex = 11;
            this.btnDodajPrvu.Text = "Prikaži prvu smjenu";
            this.btnDodajPrvu.UseVisualStyleBackColor = true;
            this.btnDodajPrvu.Click += new System.EventHandler(this.btnDodajPrvu_Click);
            // 
            // btnDodajDrugu
            // 
            this.btnDodajDrugu.Location = new System.Drawing.Point(73, 238);
            this.btnDodajDrugu.Name = "btnDodajDrugu";
            this.btnDodajDrugu.Size = new System.Drawing.Size(244, 37);
            this.btnDodajDrugu.TabIndex = 12;
            this.btnDodajDrugu.Text = "Prikaži drugu smjenu";
            this.btnDodajDrugu.UseVisualStyleBackColor = true;
            this.btnDodajDrugu.Click += new System.EventHandler(this.btnDodajDrugu_Click);
            // 
            // btnDodajTrecu
            // 
            this.btnDodajTrecu.Location = new System.Drawing.Point(73, 303);
            this.btnDodajTrecu.Name = "btnDodajTrecu";
            this.btnDodajTrecu.Size = new System.Drawing.Size(244, 37);
            this.btnDodajTrecu.TabIndex = 13;
            this.btnDodajTrecu.Text = "Prikaži treću smjenu";
            this.btnDodajTrecu.UseVisualStyleBackColor = true;
            this.btnDodajTrecu.Click += new System.EventHandler(this.btnDodajTrecu_Click);
            // 
            // dgvPrikazRasporeda
            // 
            this.dgvPrikazRasporeda.AllowUserToAddRows = false;
            this.dgvPrikazRasporeda.AllowUserToDeleteRows = false;
            this.dgvPrikazRasporeda.AutoGenerateColumns = false;
            this.dgvPrikazRasporeda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrikazRasporeda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oIBDataGridViewTextBoxColumn,
            this.korImeDataGridViewTextBoxColumn,
            this.lozinkaDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.adresaDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.odjeliDataGridViewTextBoxColumn});
            this.dgvPrikazRasporeda.DataSource = this.zaposleniciBindingSource1;
            this.dgvPrikazRasporeda.Location = new System.Drawing.Point(357, 26);
            this.dgvPrikazRasporeda.MultiSelect = false;
            this.dgvPrikazRasporeda.Name = "dgvPrikazRasporeda";
            this.dgvPrikazRasporeda.Size = new System.Drawing.Size(241, 406);
            this.dgvPrikazRasporeda.TabIndex = 15;
            // 
            // oIBDataGridViewTextBoxColumn
            // 
            this.oIBDataGridViewTextBoxColumn.DataPropertyName = "OIB";
            this.oIBDataGridViewTextBoxColumn.HeaderText = "OIB";
            this.oIBDataGridViewTextBoxColumn.Name = "oIBDataGridViewTextBoxColumn";
            this.oIBDataGridViewTextBoxColumn.Visible = false;
            // 
            // korImeDataGridViewTextBoxColumn
            // 
            this.korImeDataGridViewTextBoxColumn.DataPropertyName = "korIme";
            this.korImeDataGridViewTextBoxColumn.HeaderText = "korIme";
            this.korImeDataGridViewTextBoxColumn.Name = "korImeDataGridViewTextBoxColumn";
            this.korImeDataGridViewTextBoxColumn.Visible = false;
            // 
            // lozinkaDataGridViewTextBoxColumn
            // 
            this.lozinkaDataGridViewTextBoxColumn.DataPropertyName = "lozinka";
            this.lozinkaDataGridViewTextBoxColumn.HeaderText = "lozinka";
            this.lozinkaDataGridViewTextBoxColumn.Name = "lozinkaDataGridViewTextBoxColumn";
            this.lozinkaDataGridViewTextBoxColumn.Visible = false;
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            // 
            // adresaDataGridViewTextBoxColumn
            // 
            this.adresaDataGridViewTextBoxColumn.DataPropertyName = "adresa";
            this.adresaDataGridViewTextBoxColumn.HeaderText = "adresa";
            this.adresaDataGridViewTextBoxColumn.Name = "adresaDataGridViewTextBoxColumn";
            this.adresaDataGridViewTextBoxColumn.Visible = false;
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            this.telefonDataGridViewTextBoxColumn.Visible = false;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Visible = false;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Visible = false;
            // 
            // odjeliDataGridViewTextBoxColumn
            // 
            this.odjeliDataGridViewTextBoxColumn.DataPropertyName = "odjeli";
            this.odjeliDataGridViewTextBoxColumn.HeaderText = "odjeli";
            this.odjeliDataGridViewTextBoxColumn.Name = "odjeliDataGridViewTextBoxColumn";
            this.odjeliDataGridViewTextBoxColumn.Visible = false;
            // 
            // zaposleniciBindingSource1
            // 
            this.zaposleniciBindingSource1.DataMember = "Zaposlenici";
            this.zaposleniciBindingSource1.DataSource = this._16011_DBDataSet;
            // 
            // _16011_DBDataSet
            // 
            this._16011_DBDataSet.DataSetName = "_16011_DBDataSet";
            this._16011_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblTreca
            // 
            this.lblTreca.AutoSize = true;
            this.lblTreca.Location = new System.Drawing.Point(438, 9);
            this.lblTreca.Name = "lblTreca";
            this.lblTreca.Size = new System.Drawing.Size(77, 13);
            this.lblTreca.TabIndex = 5;
            this.lblTreca.Text = "Treća smjena: ";
            // 
            // btnIzmjeni
            // 
            this.btnIzmjeni.Location = new System.Drawing.Point(73, 387);
            this.btnIzmjeni.Name = "btnIzmjeni";
            this.btnIzmjeni.Size = new System.Drawing.Size(244, 23);
            this.btnIzmjeni.TabIndex = 16;
            this.btnIzmjeni.Text = "Izmjeni";
            this.btnIzmjeni.UseVisualStyleBackColor = true;
            this.btnIzmjeni.Click += new System.EventHandler(this.btnIzmjeni_Click);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.zaposleniciBindingSource1;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(631, 25);
            this.bindingNavigator1.TabIndex = 17;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Visible = false;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // cmbDodajZaposlenika
            // 
            this.cmbDodajZaposlenika.FormattingEnabled = true;
            this.cmbDodajZaposlenika.Location = new System.Drawing.Point(357, 456);
            this.cmbDodajZaposlenika.Name = "cmbDodajZaposlenika";
            this.cmbDodajZaposlenika.Size = new System.Drawing.Size(241, 21);
            this.cmbDodajZaposlenika.TabIndex = 18;
            this.cmbDodajZaposlenika.Visible = false;
            this.cmbDodajZaposlenika.SelectedValueChanged += new System.EventHandler(this.cmbDodajZaposlenika_SelectedValueChanged);
            // 
            // zaposleniciBindingSource2
            // 
            this.zaposleniciBindingSource2.DataMember = "Zaposlenici";
            this.zaposleniciBindingSource2.DataSource = this.dBDataSet1BindingSource;
            // 
            // dBDataSet1BindingSource
            // 
            this.dBDataSet1BindingSource.DataSource = this._16011_DBDataSet1;
            this.dBDataSet1BindingSource.Position = 0;
            // 
            // _16011_DBDataSet1
            // 
            this._16011_DBDataSet1.DataSetName = "_16011_DBDataSet1";
            this._16011_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zaposleniciTableAdapter
            // 
            this.zaposleniciTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.OdjeliTableAdapter = null;
            this.tableAdapterManager.RasporedTableAdapter = null;
            this.tableAdapterManager.SatnicaTableAdapter = null;
            this.tableAdapterManager.SmjenaTableAdapter = null;
            this.tableAdapterManager.statusZaposlenikaTableAdapter = null;
            this.tableAdapterManager.TipoviTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ZapApp._16011_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ZahtjeviTableAdapter = null;
            this.tableAdapterManager.Zaposlenici_rasporedTableAdapter = null;
            this.tableAdapterManager.Zaposlenici_satnicaTableAdapter = null;
            this.tableAdapterManager.ZaposleniciTableAdapter = this.zaposleniciTableAdapter;
            // 
            // rasporedTableAdapter1
            // 
            this.rasporedTableAdapter1.ClearBeforeFill = true;
            // 
            // zaposlenici_rasporedTableAdapter1
            // 
            this.zaposlenici_rasporedTableAdapter1.ClearBeforeFill = true;
            // 
            // zaposleniciTableAdapter1
            // 
            this.zaposleniciTableAdapter1.ClearBeforeFill = true;
            // 
            // btnBrisi
            // 
            this.btnBrisi.Location = new System.Drawing.Point(73, 454);
            this.btnBrisi.Name = "btnBrisi";
            this.btnBrisi.Size = new System.Drawing.Size(120, 23);
            this.btnBrisi.TabIndex = 19;
            this.btnBrisi.Text = "Briši";
            this.btnBrisi.UseVisualStyleBackColor = true;
            this.btnBrisi.Visible = false;
            this.btnBrisi.Click += new System.EventHandler(this.btnBrisi_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(197, 453);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(120, 23);
            this.btnDodaj.TabIndex = 20;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Visible = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // FrmRaspored
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 522);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnBrisi);
            this.Controls.Add(this.cmbDodajZaposlenika);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.btnIzmjeni);
            this.Controls.Add(this.dgvPrikazRasporeda);
            this.Controls.Add(this.btnDodajTrecu);
            this.Controls.Add(this.btnDodajDrugu);
            this.Controls.Add(this.btnDodajPrvu);
            this.Controls.Add(this.btnPrikaziZahtjeve);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblTreca);
            this.Controls.Add(this.lblDruga);
            this.Controls.Add(this.lblPrva);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmRaspored";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rapored";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmRaspored_FormClosing);
            this.Load += new System.EventHandler(this.FrmRaspored_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmRaspored_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikazRasporeda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposleniciBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._16011_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zaposleniciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposleniciBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._16011_DBDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPrva;
        private System.Windows.Forms.Label lblDruga;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnPrikaziZahtjeve;
        private System.Windows.Forms.Button btnDodajPrvu;
        private System.Windows.Forms.Button btnDodajDrugu;
        private System.Windows.Forms.Button btnDodajTrecu;
        private _16011_DBDataSet _16011_DBDataSet;
        private System.Windows.Forms.BindingSource zaposleniciBindingSource1;
        private _16011_DBDataSetTableAdapters.ZaposleniciTableAdapter zaposleniciTableAdapter;
        private _16011_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dgvPrikazRasporeda;
        private System.Windows.Forms.DataGridViewTextBoxColumn oIBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korImeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lozinkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odjeliDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblTreca;
        private System.Windows.Forms.Button btnIzmjeni;
        private System.Windows.Forms.BindingSource zaposleniciBindingSource;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private _16011_DBDataSetTableAdapters.RasporedTableAdapter rasporedTableAdapter1;
        private _16011_DBDataSetTableAdapters.Zaposlenici_rasporedTableAdapter zaposlenici_rasporedTableAdapter1;
        private System.Windows.Forms.ComboBox cmbDodajZaposlenika;
        private System.Windows.Forms.BindingSource dBDataSet1BindingSource;
        private _16011_DBDataSet1 _16011_DBDataSet1;
        private System.Windows.Forms.BindingSource zaposleniciBindingSource2;
        private _16011_DBDataSet1TableAdapters.ZaposleniciTableAdapter zaposleniciTableAdapter1;
        private System.Windows.Forms.Button btnBrisi;
        private System.Windows.Forms.Button btnDodaj;
    }
}