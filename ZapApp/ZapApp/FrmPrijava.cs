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
    public partial class FrmPrijava : Form
    {
        bool korisnickoImePrviPut = true;
        bool lozinkaPrviPut = true;
        List<Zaposlenik> listaZaposlenika = new List<Zaposlenik>();
        public FrmPrijava()
        {
            InitializeComponent();
            this.ActiveControl = txtKorisnickoIme;
            Autofokus();
            PlaceHolder();
            listaZaposlenika = Zaposlenik.DohvatiZaposlenike();
        }
        
        // zatvaranje forme za prijavu i otvaranje početne forme
        private void FrmPrijava_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMain formaMain = new FrmMain();
            formaMain.Show();
        }

        // provjera unesenih podataka i otvaranje početne forme dok je korisnik prijavljen
        private void PrijaviSe()
        {
            foreach(Zaposlenik zap in listaZaposlenika)
            {
                if(zap.korIme == txtKorisnickoIme.Text && zap.Lozinka == txtLozinka.Text)
                {
                    FrmMain formaMain = new FrmMain(zap);
                    formaMain.Show();
                    this.Hide();
                    break;
                }
                else
                {
                    lblGreske.Text = "Netočni podaci za prijavu.";
                    txtKorisnickoIme.Text = "";
                    txtLozinka.Text = "";
                }
            }
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            PrijaviSe();
        }

        // provjera da li je fokusiran unos za korisničko ime
        private void Autofokus()
        {
            this.ActiveControl = txtKorisnickoIme;
            if (this.ActiveControl == txtKorisnickoIme)
            {
                panel4.BackColor = Color.DodgerBlue;
                panel2.BackColor = Color.LightGray;
            }
        }

        // postavljanje teksta "placeholdera"
        private void PlaceHolder()
        {

            if (String.IsNullOrWhiteSpace(txtKorisnickoIme.Text))
            {
                txtKorisnickoIme.Text = "korisničko ime";
                txtKorisnickoIme.ForeColor = Color.LightGray;
            }
            
            if (String.IsNullOrWhiteSpace(txtLozinka.Text))
            {
                txtLozinka.Text = "lozinka";
                txtLozinka.ForeColor = Color.LightGray;
            }
        }

        // provjera koji je unos fokusiran i promjena boje panela 
        private void ProvjeraFokusa()
        {
            if (txtKorisnickoIme.Focused == true)
            {
                panel4.BackColor = Color.DodgerBlue;
                panel2.BackColor = Color.LightGray;
            }
            else
            {
                panel4.BackColor = Color.White;
                panel2.BackColor = Color.White;
            }
            if (txtLozinka.Focused == true)
            {
                panel5.BackColor = Color.DodgerBlue;
                panel3.BackColor = Color.LightGray;
            }
            else
            {
                panel5.BackColor = Color.White;
                panel3.BackColor = Color.White;
            }
        }
        
        // klikom na unos za korisničko ime, provjerava se fokus, briše se tekst ako je prvi put kliknuto, mijenja se boja teksta
        private void txtKorisnickoIme_Click(object sender, EventArgs e)
        {
            ProvjeraFokusa();
            if (korisnickoImePrviPut)
            {
                txtKorisnickoIme.Clear();
                korisnickoImePrviPut = false;
                txtKorisnickoIme.ForeColor = Color.Black;
            }
        }

        // klikom na unos za lozinku, provjerava se fokus, briše se tekst ako je prvi put kliknuto, mijenja se boja teksta
        private void txtLozinka_Click(object sender, EventArgs e)
        {
            ProvjeraFokusa();
            if (lozinkaPrviPut)
            {
                lozinkaPrviPut = false;
                txtLozinka.Clear();
                txtLozinka.ForeColor = Color.Black;
                txtLozinka.PasswordChar = '*';
            }
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Cursor = Cursors.Hand;
        }

        private void panel2_MouseHover(object sender, EventArgs e)
        {
            panel2.BackColor = Color.WhiteSmoke;
        }

        private void panel3_MouseHover(object sender, EventArgs e)
        {
            panel3.BackColor = Color.WhiteSmoke;
        }

        // klikon na picturebox, odnosno sliku kuće, vraća nas na početnu formu
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmMain formaMain = new FrmMain();
            this.Close();
            formaMain.Show();
            
        }

        private void txtKorisnickoIme_Enter(object sender, EventArgs e)
        {
            ProvjeraFokusa();
            lblGreske.Text = "";
        }

        // ulaskom u textbox za lozinku, izbriši tekst, promijeni boju teksta i provjeri fokus
        private void txtLozinka_Enter(object sender, EventArgs e)
        {
            this.ActiveControl = txtLozinka;
            lozinkaPrviPut = false;
            txtLozinka.Clear();
            txtLozinka.ForeColor = Color.DodgerBlue;
            txtLozinka.PasswordChar = '*';
            ProvjeraFokusa();
        }

        // ulaskom u textbox za korisničko ime, promijeni boju teksta i provjeri fokus
        private void txtKorisnickoIme_TextChanged(object sender, EventArgs e)
        {
            ProvjeraFokusa();
            korisnickoImePrviPut = false;
            txtKorisnickoIme.ForeColor = Color.DodgerBlue;
        }
        //pritiskom entera, obavlja se prijava i provjeravaju se podaci
        private void txtLozinka_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                PrijaviSe();
            }
        }

        private void btnPrijava_MouseEnter(object sender, EventArgs e)
        {
            btnPrijava.BackColor = Color.LightSkyBlue;
        }

        private void btnPrijava_MouseLeave(object sender, EventArgs e)
        {
            btnPrijava.BackColor = Color.DodgerBlue;
        }
    }
}
