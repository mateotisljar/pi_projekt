using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZapApp
{
    public partial class FrmRaspored : Form
    {
        private int trenutniDan;
        private int trenutniMjesec;
        private int trenutnaGodina;
        private int trenutnaSmjena;
        private string trenutniOIB;
        Zaposlenik zaposlenik = new Zaposlenik();
        //Prosljeđivanje podataka logiranog korisnika
        public FrmRaspored(Zaposlenik zap)
        {
            InitializeComponent();
            zaposlenik = zap;
        }

      
       private void btnPrikaziZahtjeve_Click(object sender, EventArgs e)
        {
            PrikazZahtjeva();           
        }

        //određivanje dana, mjeseca i godine izabranih u dateTimePickeru
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            trenutniDan = dateTimePicker1.Value.Day;
            trenutniMjesec = dateTimePicker1.Value.Month;
            trenutnaGodina = dateTimePicker1.Value.Year;      
        }

  

        private void FrmRaspored_Load(object sender, EventArgs e)
        {
            this.zaposleniciTableAdapter1.Fill(this._16011_DBDataSet1.Zaposlenici, zaposlenik.Odjeli.Id);
  

            lblPrva.Hide();
            lblDruga.Hide();
            lblTreca.Hide();

            trenutnaGodina = dateTimePicker1.Value.Year;
            trenutniMjesec = dateTimePicker1.Value.Month;
            trenutniDan = dateTimePicker1.Value.Day;

            BindingNavigator bindingNavigator1 = new BindingNavigator();
            bindingNavigator1.Show();
            bindingNavigator1.Enabled = true;

            //punjenje comboboxa prezimenima zaposlenika
            _16011_DBDataSet1 ds2 = new _16011_DBDataSet1();
            cmbDodajZaposlenika.DataSource = zaposleniciBindingSource2;
            cmbDodajZaposlenika.DisplayMember = "prezime";
            cmbDodajZaposlenika.ValueMember = "OIB";

            //ukoliko je prijavljen obični zaposlenik, on ne može vidjeti gumbe za izmjene rasporeda, odnosno prikaz zahtjeva za promjenama dok administrator ili oditelj odjela vide te gumbe
            if (zaposlenik.Status.Id != 3)
            {
                btnIzmjeni.Visible = true;
                btnPrikaziZahtjeve.Visible = true;
            }
            else
            {
                btnIzmjeni.Visible = false;
                btnPrikaziZahtjeve.Visible = false;
            }
            


        }

        

        private void btnDodajPrvu_Click(object sender, EventArgs e)
        {
            DodajPrvuSmjenu();
        }


        private void btnDodajDrugu_Click(object sender, EventArgs e)
        {
            DodajDruguSmjenu();
        }

        private void btnDodajTrecu_Click(object sender, EventArgs e)
        {
            DodajTrecuSmjenu();
        }

       

        private void btnIzmjeni_Click(object sender, EventArgs e)
        {
            OtvoriFunkcionalnostiAdministratora();         
         }


        // u varijablu trenutniOIB sprema OIB selektiranog zaposlenika u combobox-u
        private void cmbDodajZaposlenika_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbDodajZaposlenika.SelectedValue != null)
            {
                trenutniOIB = cmbDodajZaposlenika.SelectedValue.ToString();
            }
        }

        private void btnBrisi_Click(object sender, EventArgs e)
        {
            BrisiZaposlenika();

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DodajZaposlenika();           
        }

        //prosljeđuju se podaci korisnika kako bi korisnik ostao prijavljen
        private void FrmRaspored_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmMain glavnaForma = new FrmMain(zaposlenik);
            glavnaForma.ZatvoriPomocnuFormu();
        }

        // DataGrid se puni sa popisom zaposlenika u prvoj smjeni
        private void DodajPrvuSmjenu()
        {
            this.zaposleniciTableAdapter.FillByZaposleniciPrvaSmjena(this._16011_DBDataSet.Zaposlenici, trenutniDan, trenutniMjesec, trenutnaGodina, zaposlenik.Odjeli.Id);
            lblTreca.Hide();
            lblDruga.Hide();
            trenutnaSmjena = 1;
        }

        // DataGrid se puni sa popisom zaposlenika u drugoj smjeni
        private void DodajDruguSmjenu()
        {
            this.zaposleniciTableAdapter.FillByZaposleniciDrugaSmjena(this._16011_DBDataSet.Zaposlenici, trenutniDan, trenutniMjesec, trenutnaGodina, zaposlenik.Odjeli.Id);
            lblPrva.Hide();
            lblTreca.Hide();
            trenutnaSmjena = 2;
        }

        // DataGrid se puni sa popisom zaposlenika u trećoj smjeni
        private void DodajTrecuSmjenu() 
        {
            this.zaposleniciTableAdapter.FillByZaposleniciTrecaSmjena(this._16011_DBDataSet.Zaposlenici, trenutniDan, trenutniMjesec, trenutnaGodina, zaposlenik.Odjeli.Id);
            lblPrva.Hide();
            lblDruga.Hide();
            trenutnaSmjena = 3;
        }

        // brisanje selektiranog zaposlenika iz rasporeda
        private void BrisiZaposlenika() 
        {
            if (MessageBox.Show("Jeste li sigurni da želite maknuti ovog zaposlenika iz rasporeda?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                // dohvaća se id trenutnog rasporeda
                int trenutniRaspored = (this.rasporedTableAdapter1.ScalarQueryDohvatiRasporedId(trenutnaGodina, trenutniMjesec, trenutniDan, trenutnaSmjena)).GetValueOrDefault();

                // briše se zaposlenik iz rasporeda
                for (int i = 0; i < dgvPrikazRasporeda.Rows.Count; i++)
                {
                    this.zaposlenici_rasporedTableAdapter1.DeleteQueryBrišiZaposlenikaIzRasporeda(trenutniRaspored, this.dgvPrikazRasporeda.CurrentRow.Cells[0].Value.ToString());
                }

                this.zaposlenici_rasporedTableAdapter1.Update(this._16011_DBDataSet);
            }

            // nakon brisanja zaposlenika, osvježava se prikaz rasporeda u DataGrid-u
            switch (trenutnaSmjena)
            {
                case 1:
                    btnDodajPrvu.PerformClick();
                    break;
                case 2:
                    btnDodajDrugu.PerformClick();
                    break;
                case 3:
                    btnDodajTrecu.PerformClick();
                    break;

            }
        }

        // dodavanje zaposlenika u raspored
        private void DodajZaposlenika() 
        {
            if (cmbDodajZaposlenika.SelectedValue != null)
            {
                for (int i = 0; i < dgvPrikazRasporeda.Rows.Count; i++)
                {
                    // dohvaća se id trenutnog rasporeda
                    int trenutniRaspored = (this.rasporedTableAdapter1.ScalarQueryDohvatiRasporedId(trenutnaGodina, trenutniMjesec, trenutniDan, trenutnaSmjena)).GetValueOrDefault();
                    //dodaje se zaposlenik u raspored
                    try
                    {
                        this.zaposlenici_rasporedTableAdapter1.InsertQueryDodajZaposlenikaURaspored(trenutniOIB, trenutniRaspored);
                    }
                    catch { }
                }
            }

            // nakon dodavanja zaposlenika, osvježava se prikaz rasporeda u DataGrid-u
            switch (trenutnaSmjena)
            {
                case 1:
                    btnDodajPrvu.PerformClick();
                    break;
                case 2:
                    btnDodajDrugu.PerformClick();
                    break;
                case 3:
                    btnDodajTrecu.PerformClick();
                    break;

            }
        }

        // administratoru i voditelju odjela postaju dostuone opcije brisanja i dodavanja zaposlenika
        private void OtvoriFunkcionalnostiAdministratora() 
        {

            dgvPrikazRasporeda.AllowUserToAddRows = true;
            dgvPrikazRasporeda.AllowUserToDeleteRows = true;
            bindingNavigator1.Enabled = true;

            btnDodaj.Visible = true;
            btnBrisi.Visible = true;
            cmbDodajZaposlenika.Visible = true;

           
        }

        // prikaz forme zahtjevi
        private void PrikazZahtjeva()
         {
            FrmZahtjevi prikaziFormuZahtjevi = new FrmZahtjevi();
            prikaziFormuZahtjevi.MdiParent = this.MdiParent;
            prikaziFormuZahtjevi.Show();
        }

        //otvaranje help-a pritiskom tipke F1
        private void FrmRaspored_KeyDown(object sender, KeyEventArgs e)
        {
            {
                if (e.KeyData == Keys.F1)
                {
                    System.Diagnostics.Process.Start("https://github.com/foivz/r16011/blob/master/Slike/help.pdf");
                }
            }
        }
    }

}

