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
    public partial class FrmMain : Form
    {
        Zaposlenik zaposlenik = new Zaposlenik();
        public FrmMain()
        {
            InitializeComponent();
            ProvjeriPrijavu();
        }

        /// <summary>
        /// konstruktor kojemu su prosljeđeni podaci prijavljenog korisnika
        /// 
        /// </summary>
        /// <param name="zap">preneseni objekt zaposlenika</param>
        public FrmMain(Zaposlenik zap)
        {
            InitializeComponent();
            zaposlenik = zap;
            lblPrijava.Text = "Prijavljeni ste kao: " + zaposlenik.korIme;

            //provjera uloge(tipa) zaposlenika
            if (zaposlenik.Status.Id == 3)
            {
                lblUloga.Text = "Uloga: " + zaposlenik.Status.Naziv;
                btnDodavanjeZaposlenika.Visible = false;
            }
            else if (zaposlenik.Status.Id == 2)
            {
                lblUloga.Text = "Uloga: " + zaposlenik.Status.Naziv;
                btnDodavanjeZaposlenika.Visible = false;
            }
            else if (zaposlenik.Status.Id == 1)
            {
                lblUloga.Text = "Uloga: " + zaposlenik.Status.Naziv;
            }
            ProvjeriPrijavu();
        }
                
        //metoda za provjeru da li je zaposlenik prijavljen i ovisno o tome koji su gumbi vidljivi
        private void ProvjeriPrijavu()
        {
            if (lblPrijava.Text != "")
            {
                btnPrijava.Visible = false;
                btnOdjava.Visible = true;
            }
            else
            {
                btnOdjava.Visible = false;
            }
        }
        //provjera da li smo prijavljeni, i ako jesmo, otvara se nova forma za popunjavanje rasporeda
        private void btnPopuniRaspored_Click(object sender, EventArgs e)
        {
            if (lblPrijava.Text == "")
            {
                MessageBox.Show("Niste prijavljeni!");
            }
            else
            {
                FrmRaspored formaRaspored = new FrmRaspored(zaposlenik);
                formaRaspored.MdiParent = this.MdiParent;
                formaRaspored.Show();
                this.Hide();
            }
        }

        //provjerava se da li smo prijavljeni i ako jesmo, otvara se nova forma za evidenciju dolazaka
        private void btnEvidencijaDolazaka_Click(object sender, EventArgs e)
        {
            if (lblPrijava.Text == "")
            {
                MessageBox.Show("Niste prijavljeni!");
            }else
            {
                FrmEvidencijaDolazaka formaEvidencijaDolazaka = new FrmEvidencijaDolazaka(zaposlenik);
                formaEvidencijaDolazaka.MdiParent = this.MdiParent;
                this.Hide();
                formaEvidencijaDolazaka.Show();
            }
        }
        //provjera da li smo prijavljeni i ako jesmo, otvara se forma za dodavanje, azuriranje i brisanje korisnika
        private void btnDodavanjeZaposlenika_Click(object sender, EventArgs e)
        {
            if (lblPrijava.Text == "")
            {
                MessageBox.Show("Niste prijavljeni!");
            }
            else {
                FrmZaposlenici formaZaposlenici = new FrmZaposlenici(zaposlenik);
                formaZaposlenici.MdiParent = this.MdiParent;
                this.Hide();
                formaZaposlenici.Show();
            }
        }
        
        //osigurava zaustavljanje aplikacije nakon zaustavljanja glavne forme
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            ZatvaranjeAplikacije();
        }
        //funkcija za zatvaranje aplikacije, prekida vezu prema bazi i zatvara aplikaciju
        private void ZatvaranjeAplikacije()
        {
            BazaPodataka.Instance.Connection.Close();
            Application.Exit();
        }
        public void ZatvoriPomocnuFormu()
        {
            FrmMain glavnaForma = new FrmMain(zaposlenik);
            glavnaForma.Show();
            this.Hide();
        }
        
        private void FrmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F1)
            {
               System.Diagnostics.Process.Start("https://github.com/foivz/r16011/blob/master/Slike/help.pdf");
            }
        }

        //klikom na gumb za prijavu, otvara nam se forma za prijavu
        private void btnPrijava_Click(object sender, EventArgs e)
        {
            FrmPrijava formaPrijava = new FrmPrijava();
            formaPrijava.MdiParent = this.MdiParent;
            this.Hide();
            formaPrijava.Show();
        }

        //klikom na gumb za odjavu, odjavljujemo se sa sustava
        private void btnOdjava_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uspješno ste se odjavili sa aplikacije!");
            FrmMain main = new FrmMain();
            main.Show();
            this.Hide();
        }

        //pritiskom na X, poziva se funkcija za gašenje aplikacije i prekid veze s bazom
        private void X_Click(object sender, EventArgs e)
        {
            ZatvaranjeAplikacije();
        }
        
        private void panel_X_Click(object sender, EventArgs e)
        {
            Application.Exit();
            BazaPodataka.Instance.Connection.Close();
        }

        private void panel_X_MouseEnter(object sender, EventArgs e)
        {
            panel_X.BackColor = Color.Red;
            lbl_X.ForeColor = Color.White;
        }

        private void panel_X_MouseLeave(object sender, EventArgs e)
        {
            panel_X.BackColor = Color.White;
            lbl_X.ForeColor = Color.Red;
        }

        private void btnPrijava_MouseEnter(object sender, EventArgs e)
        {
            btnPrijava.BackColor = Color.DodgerBlue;
            btnPrijava.ForeColor = Color.White;
        }

        private void btnPrijava_MouseLeave(object sender, EventArgs e)
        {
            btnPrijava.BackColor = Color.White;
            btnPrijava.ForeColor = Color.DodgerBlue;
        }

        private void btnDodavanjeZaposlenika_MouseEnter(object sender, EventArgs e)
        {
            btnDodavanjeZaposlenika.ForeColor = Color.DodgerBlue;
            btnDodavanjeZaposlenika.BackColor = Color.White;
        }

        private void btnPopuniRaspored_MouseEnter(object sender, EventArgs e)
        {
            btnPopuniRaspored.ForeColor = Color.DodgerBlue;
            btnPopuniRaspored.BackColor = Color.White;
        }

        private void btnEvidencijaDolazaka_MouseEnter(object sender, EventArgs e)
        {
            btnEvidencijaDolazaka.ForeColor = Color.DodgerBlue;
            btnEvidencijaDolazaka.BackColor = Color.White;
        }

        private void btnDodavanjeZaposlenika_MouseLeave(object sender, EventArgs e)
        {
            btnDodavanjeZaposlenika.ForeColor = Color.White;
            btnDodavanjeZaposlenika.BackColor = Color.DodgerBlue;
        }

        private void btnPopuniRaspored_MouseLeave(object sender, EventArgs e)
        {
            btnPopuniRaspored.ForeColor = Color.White;
            btnPopuniRaspored.BackColor = Color.DodgerBlue;
        }

        private void btnEvidencijaDolazaka_MouseLeave(object sender, EventArgs e)
        {
            btnEvidencijaDolazaka.ForeColor = Color.White;
            btnEvidencijaDolazaka.BackColor = Color.DodgerBlue;
        }

        private void btnOdjava_MouseEnter(object sender, EventArgs e)
        {
            btnOdjava.BackColor = Color.White;
            btnOdjava.ForeColor = Color.DodgerBlue;
        }

        private void btnOdjava_MouseLeave(object sender, EventArgs e)
        {
            btnOdjava.BackColor = Color.DodgerBlue;
            btnOdjava.ForeColor = Color.White;
        }
    }
}
