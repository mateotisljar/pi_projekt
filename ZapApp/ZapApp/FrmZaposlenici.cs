using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZapApp
{
    public partial class FrmZaposlenici : Form
    {
        SqlDataAdapter adapter;
        DataTable dt;
        Zaposlenik zaposlenik = new Zaposlenik();
        List<Zaposlenik> listaZaposlenika = new List<Zaposlenik>();
        List<Odjel> listaOdjela = new List<Odjel>();
        List<TipKorisnika> listaStatusa = new List<TipKorisnika>();
        bool postojiVoditelj = true;

        public FrmZaposlenici()
        {
            InitializeComponent();
        }

        //Prosljeđivanje podataka logiranog korisnika
        public FrmZaposlenici(Zaposlenik zap)
        {
            InitializeComponent();
            zaposlenik = zap;
            DohvatiPodatke();
        }

        private void DohvatiPodatke()
        {
            listaZaposlenika.Clear();
            listaZaposlenika = Zaposlenik.DohvatiZaposlenike();
            listaStatusa.Clear();
            listaStatusa = TipKorisnika.DohvatiSveTipove();
            listaOdjela.Clear();
            listaOdjela = Odjel.DohvatiSveOdjele();
        }
        //vračanje na glavnu formu putem ToolStripMenu-a
        private void pocetnaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMain glavnaForma = new FrmMain(zaposlenik);
            glavnaForma.Show();
            this.Close();
        }
        //Ispis zaposlenika i odjela pritiskom na gumb
        private void btnLista_Click(object sender, EventArgs e)
        {
            OsvjeziZaposlenike();
        }
        /// <summary>
        /// Metoda za osvježavanje svih zaposlenika
        /// </summary>
        private void OsvjeziZaposlenike()
        {
            DohvatiPodatke();
            adapter = new SqlDataAdapter("select z.OIB as 'OIB', z.korIme as 'Korisnicko ime', z.lozinka as 'Lozinka', z.ime as 'Ime', z.prezime as 'Prezime', z.adresa as 'Adresa', z.telefon as 'Telefon', z.email as 'Email', s.naziv as Status, o.naziv as Odjel from Zaposlenici z LEFT JOIN odjeli o ON z.odjeli=o.id JOIN statusZaposlenika s ON z.status = s.id", BazaPodataka.Instance.Connection);
            dt = new DataTable();
            adapter.Fill(dt);
            BindingSource bs = new BindingSource(dt, null);
            bs.ResetBindings(false);
            dgvZaposlenici.DataSource = bs;
            btnPostavi.Visible = true;
            btnAzurirajTrenutnog.Visible = true;
            btnObrisi.Visible = true;
            btnMakniVoditelja.Visible = true;
            comboBox1.Visible = true;
        }
        
        //Zatvaranjem forme zaposlenici, prekida se veza sa bazom, te se otvara glavna forma
        //prosljeđuju se podaci korisnika kako bi korisnik ostao prijavljen
        private void FrmZaposlenici_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMain glavnaForma = new FrmMain(zaposlenik);
            glavnaForma.ZatvoriPomocnuFormu();
        }
        //otvaranje forme za dodavanje novoga zaposlenika
        private void btnDodajNovog_Click(object sender, EventArgs e)
        {
            FrmDodavanjeZaposlenika noviZaposlenik = new FrmDodavanjeZaposlenika();
            noviZaposlenik.ShowDialog();
            OsvjeziZaposlenike();
        }
        //ažuriranje podataka korisnika 
        private void btnAzurirajTrenutnog_Click(object sender, EventArgs e)
        {
            DohvatiPodatke();
            if (dgvZaposlenici.SelectedRows.Count > 0)
            {
                Zaposlenik odabrani = new Zaposlenik();
                //dohvacanje OIB-a korisnika iz tablice
                DataGridViewRow row = dgvZaposlenici.Rows[dgvZaposlenici.SelectedCells[0].RowIndex];
                odabrani.OIB = Convert.ToString(row.Cells["OIB"].Value.ToString());
                foreach (Zaposlenik zap in listaZaposlenika)
                {
                    if(zap.OIB == odabrani.OIB)
                    {
                        odabrani = zap;
                        break;
                    }
                }
                FrmDodavanjeZaposlenika formaDodavanjeZaposlenika = new FrmDodavanjeZaposlenika(odabrani);
                formaDodavanjeZaposlenika.Show();
            }
            OsvjeziZaposlenike();
        }

        //brisanje zaposlenika iz tablice Zaposlenici
        private void btnObrisi_Click(object sender, EventArgs e)
        {
            DohvatiPodatke();
            if (dgvZaposlenici.SelectedRows.Count > 0)
            {
                Zaposlenik odabrani = new Zaposlenik();
                DataGridViewRow row = dgvZaposlenici.Rows[dgvZaposlenici.SelectedCells[0].RowIndex];
                odabrani.OIB = Convert.ToString(row.Cells["OIB"].Value.ToString());
                foreach (Zaposlenik zap in listaZaposlenika)
                {
                    if (zap.OIB == odabrani.OIB)
                    {
                        odabrani = zap;
                        break;
                    }
                }
                if (odabrani.ObrisiZaposlenika() == 1)
                {
                    MessageBox.Show("Uspješno ste obrisali zaposlenika.");
                    listaZaposlenika.Remove(odabrani);
                }
                OsvjeziZaposlenike();
            }
        }
        //makivanje zaposlenika s mjesta pozicije voditelja odjela
        private void btnMakniVoditelja_Click(object sender, EventArgs e)
        {
            DohvatiPodatke();
            DataGridViewRow row = dgvZaposlenici.Rows[dgvZaposlenici.SelectedCells[0].RowIndex];
            string oib = Convert.ToString(row.Cells["OIB"].Value.ToString());
            foreach (Zaposlenik zap in listaZaposlenika)
            {
                if (zap.OIB == oib)
                {
                    zap.Odjeli = null;
                    foreach (TipKorisnika tip in listaStatusa)
                    {
                        //zaposlenik prestaje biti voditelj i postaje opet obicni zaposlenik
                        if (tip.Naziv == "Zaposlenik")
                        {
                            zap.Status = tip;
                        }
                    }
                    zap.AzurirajZaposlenika();
                    break;
                }
            }
            OsvjeziZaposlenike();
        }
        //postavljanje odabranog zaposlenika kao voditelja odjela(combobox)
        private void btnPostavi_Click(object sender, EventArgs e)
        {
            DohvatiPodatke();
            if (comboBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Niste odabrali dobrog odjela.");
            }else
            {
                int idOdjela = comboBox1.SelectedIndex + 1;

                foreach(Zaposlenik z in listaZaposlenika)
                {
                    //provjera da li odjel vec ima voditelja
                    if(z.Odjeli != null)
                    {
                        if(z.Odjeli.Id == idOdjela)
                        {
                            postojiVoditelj = true;
                            break;
                        }else
                        {
                            postojiVoditelj = false;
                        }
                    }
                }
                if (postojiVoditelj==false)
                {
                    foreach (Zaposlenik zap in listaZaposlenika)
                    {
                        DataGridViewRow row = dgvZaposlenici.Rows[dgvZaposlenici.SelectedCells[0].RowIndex];
                        string oib = Convert.ToString(row.Cells["OIB"].Value.ToString());
                        if (zap.OIB == oib)
                        {
                            foreach (Odjel o in listaOdjela)
                            {
                                //dodjeljivanje odjela
                                if (idOdjela == o.Id)
                                {
                                    zap.Odjeli = o;
                                    break;
                                }
                            }
                            //promjena statusa zaposlenika u voditelja
                            foreach (TipKorisnika tip in listaStatusa)
                            {
                                if (tip.Id == 2)
                                {
                                    zap.Status = tip;
                                    break;
                                }
                            }
                        }
                        zap.AzurirajZaposlenika();
                        MessageBox.Show("uspješno ste postavili odabranog zaposlenika kao voditelja odjela.");
                    }
                }else
                {
                    MessageBox.Show("Odabrani odjel već ima voditelja.");
                }
                OsvjeziZaposlenike();
            }
        }

        //trazenje zaposlenika prema korisnickome imenu
        private void btnTrazi_Click(object sender, EventArgs e)
        {
            DohvatiPodatke();
            if (String.IsNullOrWhiteSpace(txtID_zaposlenika_Trazi.Text))
            {
                MessageBox.Show("Niste unijeli korisničko ime.");
            }else
            {
                adapter = new SqlDataAdapter("select z.OIB as 'OIB', z.korIme as 'Korisnicko ime', z.lozinka as 'Lozinka', z.ime as 'Ime', z.prezime as 'Prezime', z.adresa as 'Adresa', z.telefon as 'Telefon', z.email as 'Email', s.naziv as Status, o.naziv as Odjel from Zaposlenici z LEFT JOIN odjeli o ON z.odjeli = o.id JOIN statusZaposlenika s ON z.status = s.id where z.korIme like '%" + txtID_zaposlenika_Trazi.Text + "%'", BazaPodataka.Instance.Connection);
                dt = new DataTable();
                adapter.Fill(dt);
                dgvZaposlenici.DataSource = dt;
            }
        }

        //dohvacanje oib-a odabranog zaposlenika u dgv-u
        private string DohvatiOdabranogZaposlenika()
        {
            int selectedIndex = dgvZaposlenici.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvZaposlenici.Rows[selectedIndex];
            string zaposlenik = Convert.ToString(selectedRow.Cells["OIB"].Value.ToString());
            return zaposlenik;
        }

        //otvaranje help-a pritiskom tipke F1
        private void FrmZaposlenici_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F1)
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/r16011/blob/master/Slike/help.pdf");
            }
        }

        //popunjavanje combobox-a odjelima
        private void FrmZaposlenici_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_16011_DBDataSet.Odjeli' table. You can move, or remove it, as needed.
            this.odjeliTableAdapter.Fill(this._16011_DBDataSet.Odjeli);
        }

        //sljedeci event handleri su za mouse hoover dogadjaje
        private void btnDodajNovog_MouseEnter(object sender, EventArgs e)
        {
            panel9.BackColor = Color.White;
            lblInfo.Text = "Dodavanje novog zaposlenika.";
        }

        private void btnDodajNovog_MouseLeave(object sender, EventArgs e)
        {
            panel9.BackColor = Color.FromArgb(64, 64, 64);
            lblInfo.Text = "";
        }

        private void btnLista_MouseEnter(object sender, EventArgs e)
        {
            panel8.BackColor = Color.White;
            lblInfo.Text = "Prikaz liste svih zaposlenika.";
        }

        private void btnLista_MouseLeave(object sender, EventArgs e)
        {
            panel8.BackColor = Color.FromArgb(64, 64, 64);
            lblInfo.Text = "";
        }

        private void btnObrisi_MouseEnter(object sender, EventArgs e)
        {
            panel7.BackColor = Color.White;
            lblInfo.Text = "Brisanje odabranog zaposlenika.";
        }

        private void btnObrisi_MouseLeave(object sender, EventArgs e)
        {
            panel7.BackColor = Color.FromArgb(64, 64, 64);
            lblInfo.Text = "";
        }

        private void btnAzurirajTrenutnog_MouseEnter(object sender, EventArgs e)
        {
            panel6.BackColor = Color.White;
            lblInfo.Text = "Ažuriranje podataka odabranog zaposlenika.";
        }

        private void btnAzurirajTrenutnog_MouseLeave(object sender, EventArgs e)
        {
            panel6.BackColor = Color.FromArgb(64, 64, 64);
            lblInfo.Text = "";
        }

        //zatvaranje trenutne forme i otvaranje glavne forme
        private void lbl_X_Click(object sender, EventArgs e)
        {
            FrmMain glavnaForma = new FrmMain(zaposlenik);
            glavnaForma.Show();
            this.Close();
        }

        private void btnMakniVoditelja_MouseEnter(object sender, EventArgs e)
        {
            panel5.BackColor = Color.White;
            lblInfo.Text = "Makivanje zaposlenika s pozicije voditelja odjela.";
        }

        private void btnMakniVoditelja_MouseLeave(object sender, EventArgs e)
        {
            panel5.BackColor = Color.FromArgb(64, 64, 64);
            lblInfo.Text = "";
        }

        private void panel_X_MouseEnter(object sender, EventArgs e)
        {
            panel_X.BackColor = Color.Red;
            lbl_X.ForeColor = Color.White;
            lblInfo.Text = "Zatvaranje prozora.";
        }

        private void panel_X_MouseLeave(object sender, EventArgs e)
        {
            panel_X.BackColor = Color.DodgerBlue;
            lbl_X.ForeColor = Color.Red;
            lblInfo.Text = "";
        }
        
    }
}
