using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZapApp
{
    public partial class FrmDodavanjeZaposlenika : Form
    {
        private Zaposlenik zaposlenik = null;
        List<Odjel> listaOdjela = new List<Odjel>();
        List<Zaposlenik> listaZaposlenika = new List<Zaposlenik>();
        List<TipKorisnika> listaStatusa = new List<TipKorisnika>();
        bool postojiVoditelj = true;

        public FrmDodavanjeZaposlenika()
        {
            InitializeComponent();
            btnSpremi.Visible = false;
            DohvatiPodatke();
        }

        public FrmDodavanjeZaposlenika(Zaposlenik odabraniZaposlenik)
        {
            InitializeComponent();
            zaposlenik = odabraniZaposlenik;
            btnDodaj.Visible = false;
            DohvatiPodatke();
        }
        //Dohvacanje i osvjezavanje zaposlenika, odjela i tipova korisnika u bazi i listama
        private void DohvatiPodatke()
        {
            listaZaposlenika.Clear();
            listaZaposlenika = Zaposlenik.DohvatiZaposlenike();
            listaStatusa.Clear();
            listaStatusa = TipKorisnika.DohvatiSveTipove();
            listaOdjela.Clear();
            listaOdjela = Odjel.DohvatiSveOdjele();
        }

        //Dodavanje novoga zaposlenika, provjera ispravnosti unesenih podataka
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Zaposlenik zap = new Zaposlenik();
            zap = DodajAzurirajKorisnika();
            if (zap != null)
            {
                if (zap.Ime == null || zap.Prezime == null || zap.korIme == null || zap.Email == null || zap.Adresa == null || zap.OIB == null || zap.Lozinka == null)
                {
                    MessageBox.Show("Niste unijeli podatke zaposlenika.");
                }
                else
                {
                    zap.SpremiZaposlenika();
                    MessageBox.Show("Uspješno ste dodali novog zaposlenika.");
                }
            }
        }
        
        //ako je prenesen objekt zaposlenik, textboxi se popunjuju podacima zaposlenika
        private void FrmDodavanjeZaposlenika_Load(object sender, EventArgs e)
        {
            DohvatiPodatke();
            // TODO: This line of code loads data into the '_16011_DBDataSet.Odjeli' table. You can move, or remove it, as needed.
            this.odjeliTableAdapter.Fill(this._16011_DBDataSet.Odjeli);
            // TODO: This line of code loads data into the '_16011_DBDataSet.statusZaposlenika' table. You can move, or remove it, as needed.
            this.statusZaposlenikaTableAdapter.Fill(this._16011_DBDataSet.statusZaposlenika);

            if (zaposlenik != null)
            {
                txtIme.Text = zaposlenik.Ime.ToString();
                txtPrezime.Text = zaposlenik.Prezime.ToString();
                txtKorisnickoIme.Text = zaposlenik.korIme.ToString();
                txtOIB.Text = zaposlenik.OIB.ToString();
                cmbStatus.SelectedValue = zaposlenik.Status.Id;
                txtMobitel.Text = zaposlenik.Telefon.ToString();
                txtLozinka.Text = zaposlenik.Lozinka.ToString();
                txtAdresa.Text = zaposlenik.Adresa.ToString();
                txtEmail.Text = zaposlenik.Email.ToString();
                if(zaposlenik.Odjeli != null)
                {
                    cmbOdjel.SelectedValue = zaposlenik.Odjeli.Id;
                }
                
                if(cmbStatus.SelectedIndex != 2)
                {
                    cmbOdjel.Visible = true;
                    label1.Visible = true;
                }
            }
        }
        //dohvacanje podataka iz forme i spremanje zaposlenika u bazu
        private void btnSpremi_Click(object sender, EventArgs e)
        {
            Zaposlenik zap = DodajAzurirajKorisnika();
            if (zap != null)
            {
                if (zap.Ime == null || zap.Prezime == null || zap.korIme == null || zap.Email == null || zap.Adresa == null || zap.OIB == null || zap.Lozinka == null)
                {
                    MessageBox.Show("Niste unijeli podatke zaposlenika.");
                }
                else
                {
                    zap.AzurirajZaposlenika();
                }
            }
            DohvatiPodatke();
        }
        //metoda za dohvacanje podataka iz forme
        private Zaposlenik DodajAzurirajKorisnika()
        {
            DohvatiPodatke();
            if (zaposlenik == null)
            {
                zaposlenik = new Zaposlenik();
            }
            if (String.IsNullOrWhiteSpace(txtIme.Text) || String.IsNullOrWhiteSpace(txtPrezime.Text) || String.IsNullOrWhiteSpace(txtKorisnickoIme.Text) || String.IsNullOrWhiteSpace(txtMobitel.Text) || String.IsNullOrWhiteSpace(txtLozinka.Text) || String.IsNullOrWhiteSpace(txtAdresa.Text) || String.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Niste unijeli sve podatke.");
            }else
            {
                zaposlenik.Ime = txtIme.Text;
                zaposlenik.Prezime = txtPrezime.Text;
                zaposlenik.korIme = txtKorisnickoIme.Text;
                zaposlenik.OIB = txtOIB.Text;
                zaposlenik.Telefon = txtMobitel.Text;
                zaposlenik.Lozinka = txtLozinka.Text;
                zaposlenik.Adresa = txtAdresa.Text;
                zaposlenik.Email = txtEmail.Text;
                if (cmbOdjel.Visible)
                {
                    //provjera da li odjel vec ima voditelja
                    int idOdjela = cmbOdjel.SelectedIndex + 1;
                    foreach (Zaposlenik z in listaZaposlenika)
                    {
                        if (z.Odjeli != null)
                        {
                            if (z.Odjeli.Id == idOdjela)
                            {
                                postojiVoditelj = true;
                                break;
                            }
                            else
                            {
                                postojiVoditelj = false;
                            }
                        }
                    }
                    if (!postojiVoditelj)
                    {
                        foreach(Odjel o in listaOdjela)
                        {
                            if(o.Id == idOdjela)
                            {
                                zaposlenik.Odjeli = o;
                                break;
                            }
                        }
                        foreach (TipKorisnika tip in listaStatusa)
                        {
                            if (tip.Id == int.Parse(cmbStatus.SelectedValue.ToString()))
                            {
                                zaposlenik.Status = tip;
                                break;
                            }
                        }
                        this.Close();
                        listaZaposlenika.Add(zaposlenik);
                    }else
                    {
                        MessageBox.Show("Odabrani odjel već ima voditelja.");
                        zaposlenik = null;
                    }
                }else
                {
                    //ako je combobox za odjele skriven, tada je zaposlenik obicni korisnik
                    zaposlenik.Odjeli = null;
                    foreach(TipKorisnika tip in listaStatusa)
                    {
                        if (tip.Naziv == "Zaposlenik")
                        {
                            zaposlenik.Status = tip;
                            break;
                        }
                    }
                    this.Close();
                }
            }
            return zaposlenik;
        }
        //provjera i prikazivanje comboboxa s odjelima ovisno o tipu zaposlenika koji ce biti
        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbStatus.SelectedIndex == 0 || cmbStatus.SelectedIndex == 1)
            {
                label1.Visible = true;
                cmbOdjel.Visible = true;
            }else
            {
                label1.Visible = false;
                cmbOdjel.Visible = false;
            }
        }
    }
}
