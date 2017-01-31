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
    public partial class FrmEvidencijaDolazaka : Form
    {
        Zaposlenik zaposlenik = new Zaposlenik();
        //Prosljeđivanje podataka logiranog korisnika
        public FrmEvidencijaDolazaka(Zaposlenik zap)
        {
            InitializeComponent();
            zaposlenik = zap;
        }

        private bool dolazak, dolazakPauza;
        
        private int stanjeSati;

     

        private void btnPrijaviDolazak_Click(object sender, EventArgs e)
        {
            //provjera je li korisnik zadnje prijavio dolazak na posao ili pak odlazak sa posla
            
            if (dolazak==false)
            {
                PrijaviDolazakNaPosao();
            }
            else 
            {
                PrijaviOdlazakSPosla();
            }
            }

     

        private void FrmSatnica_Load(object sender, EventArgs e)
        {     
            // prikaz broja dolazaka na posao logiranog korisnika
            stanjeSati = this.satnicaTableAdapter1.ScalarQueryDohvatiBrojDolazakaNaPosao(zaposlenik.OIB).GetValueOrDefault();
            lblStanjeSati.Text = stanjeSati.ToString();

            btnPrijaviDolazak.BackColor = Color.Chocolate;
            btnPrijaviPauzu.BackColor = Color.Chocolate;
        }

        //prosljeđuju se podaci korisnika kako bi korisnik ostao prijavljen
        private void FrmSatnica_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmMain glavnaForma = new FrmMain(zaposlenik);
            glavnaForma.ZatvoriPomocnuFormu();
        }


        private void btnPrijaviPauzu_Click(object sender, EventArgs e)
        {
            // provjera je li korisnik zadnje prijavio odlazak na pauzu ili povratak sa pauze
            if (dolazakPauza == false)
            {
                PrijaviOdlazakNaPauzu();
            }
            else
            {
                PrijaviPovratakSPauze();
                }
        }

        //prijava dolaska na posao
        private void PrijaviDolazakNaPosao() 
        {
            
            if (MessageBox.Show("Jeste li sigurni da želite prijaviti dolazak na posao?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                btnPrijaviDolazak.BackColor = Color.GreenYellow;
                MessageBox.Show("Uspješno ste prijavili dolazak na posao!");
                btnPrijaviDolazak.Text = "Prijavi odlazak sa posla";
                dolazak = true;
                //u bazu se upisuju podaci vezani uz prijavu dolaska
                this.satnicaTableAdapter1.InsertQueryPrijavaDolaskaNaPosao(zaposlenik.OIB);
                // dohvaća se broj dolazaka na posao
                stanjeSati = this.satnicaTableAdapter1.ScalarQueryDohvatiBrojDolazakaNaPosao(zaposlenik.OIB).GetValueOrDefault();
                lblStanjeSati.Text = stanjeSati.ToString();
            }
        }

        //prijava odlaska s posla
        private void PrijaviOdlazakSPosla() 
        {
            
            if (MessageBox.Show("Jeste li sigurni da želite prijaviti odlazak s posla?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                btnPrijaviDolazak.BackColor = Color.Chocolate;
                MessageBox.Show("Uspješno ste prijavili odlazak sa posla!");
                btnPrijaviDolazak.Text = "Prijavi dolazak na posao!";
                dolazak = false;
                //u bazu se upisuju podaci vezani uz prijavu odlaska
                this.satnicaTableAdapter1.InsertQueryPrijavaOdlazakaSPosla(zaposlenik.OIB);
            }
        }

        //otvaranje help-a pritiskom tipke F1
        private void FrmSatnica_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F1)
            {
                System.Diagnostics.Process.Start("https://github.com/foivz/r16011/blob/master/Slike/help.pdf");
            }
        }

        //prijava odlaska na pauzu
        private void PrijaviOdlazakNaPauzu() 
        {
            
            if (MessageBox.Show("Jeste li sigurni da želite prijaviti odlazak na pauzu?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                btnPrijaviPauzu.BackColor = Color.GreenYellow;
                MessageBox.Show("Uspješno ste prijavili odlazak na pauzu!");
                btnPrijaviPauzu.Text = "Prijavi povratak sa pauze!";
                dolazakPauza = true;
                //u bazu se upisuju podaci vezani uz prijavu odlaska na pauzu
                this.satnicaTableAdapter1.InsertQueryPrijavaOdlaskaNaPauzu(zaposlenik.OIB);
            }
        }

        //prijava povratka s pauze
        private void PrijaviPovratakSPauze() 
        {
           
            if (MessageBox.Show("Jeste li sigurni da želite prijaviti povratak s pauze?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                btnPrijaviPauzu.BackColor = Color.Chocolate;
                MessageBox.Show("Uspješno ste prijavili povratak sa pauze!");
                btnPrijaviPauzu.Text = "Prijavi odlazak na pauzu!";
                dolazakPauza = false;
                //u bazu se upisuju podaci vezani uz prijavu povratka s pauze
                this.satnicaTableAdapter1.InsertQueryPrijavaPovratkaSPauze(zaposlenik.OIB);
            }
        }

    }
}
