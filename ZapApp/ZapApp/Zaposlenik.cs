using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZapApp
{
    public class Zaposlenik
    {
        public Zaposlenik()
        {
                
        }
        /// <summary>
        /// kreiranje zaposlenika sa podacima iz DataReader-a
        /// </summary>
        /// <param name="dr">DataReader objekt sa podacima zaposlenika</param>
        public Zaposlenik(DbDataReader dr)
        {
            if (dr != null)
            {
                OIB = dr["OIB"].ToString();
                korIme = dr["korIme"].ToString();
                Lozinka = dr["lozinka"].ToString();
                Ime = dr["ime"].ToString();
                Prezime = dr["prezime"].ToString();
                Adresa = dr["adresa"].ToString();
                Telefon = dr["telefon"].ToString();
                Email = dr["email"].ToString();
                Status.Id = int.Parse(dr["status"].ToString());
                if (!String.IsNullOrEmpty(dr["odjeli"].ToString()))
                {
                    Odjeli.Id = Convert.ToInt32(dr["odjeli"]);
                }
                else
                {
                    Odjeli =null;
                }
            }
        }

        public string OIB { get; set; }
        public string korIme { get; set; }
        public string Lozinka { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Adresa { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public TipKorisnika Status = new TipKorisnika();
        public Odjel Odjeli = new Odjel();
        
        //dohvaćanje svih zaposlenika iz baze i spremanje u listu
        public static List<Zaposlenik> DohvatiSveZaposlenikeIzTablice()
        {
            List<Zaposlenik> lista = new List<Zaposlenik>();
            string sqlUpit = "select * from Zaposlenici";
            DbDataReader dr = BazaPodataka.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Zaposlenik zaposlenici = new Zaposlenik(dr);
                lista.Add(zaposlenici);
            }
            dr.Close();
            return lista;
        }
        
        //spremanje zaposlenika u bazu
        public int SpremiZaposlenika()
        {
            string sqlUpit = "";
            if(Odjeli == null)
            {
                sqlUpit = "insert into Zaposlenici(OIB, korIme, lozinka, ime, prezime, adresa, telefon, email, status) values('"
                   + OIB + "', '"
                   + korIme + "', '"
                   + Lozinka + "', '"
                   + Ime + "', '"
                   + Prezime + "', '"
                   + Adresa + "', '"
                   + Telefon + "', '"
                   + Email + "', '"
                   + Status.Id + "')";
            }
            else
            {
                sqlUpit = "insert into Zaposlenici(OIB, korIme, lozinka, ime, prezime, adresa, telefon, email, status, odjeli) values('"
                   + OIB + "', '"
                   + korIme + "', '"
                   + Lozinka + "', '"
                   + Ime + "', '"
                   + Prezime + "', '"
                   + Adresa + "', '"
                   + Telefon + "', '"
                   + Email + "', '"
                   + Status.Id + "', '"
                   + Odjeli.Id + "')";
            }
            return BazaPodataka.Instance.IzvrsiUpit(sqlUpit);
        }

        //azuriranje podataka o zaposleniku i spremanje u bazu
        public int AzurirajZaposlenika()
        {
            string sqlUpit = "";
            if(Odjeli == null)
            {
                sqlUpit = "update Zaposlenici set korIme = '" + korIme + "', lozinka = '" + Lozinka + "', ime = '" + Ime + "', prezime = '" + Prezime + "', adresa = '" + Adresa + "', telefon = '" + Telefon + "', email = '" + Email + "', odjeli = null, status ='" + Status.Id + "' where OIB = '" + OIB + "'";
            }
            else
            {
                sqlUpit = "update Zaposlenici set korIme = '" + korIme + "', lozinka = '" + Lozinka + "', ime = '" + Ime + "', prezime = '" + Prezime + "', adresa = '" + Adresa + "', telefon = '" + Telefon + "', email = '" + Email + "', odjeli = '" + Odjeli.Id + "', status ='" + Status.Id + "' where OIB = '" + OIB + "'";

            }
            return BazaPodataka.Instance.IzvrsiUpit(sqlUpit);
        }

        //brisanje zaposlenika iz tablica
        public int ObrisiZaposlenika()
        {
            string obrisi = "delete from Satnica where zaposlenik = '" + OIB + "'";
            BazaPodataka.Instance.IzvrsiUpit(obrisi);
            obrisi = "delete from Zahtjevi where zaposlenik = '" + OIB + "'";
            BazaPodataka.Instance.IzvrsiUpit(obrisi);
            string sqlDelete = "delete from Zaposlenici_raspored where zaposlenik = '" + OIB + "'";
            BazaPodataka.Instance.IzvrsiUpit(sqlDelete);
            string sqlUpit = "delete from Zaposlenici where OIB = '" + OIB + "'";
            return BazaPodataka.Instance.IzvrsiUpit(sqlUpit);

        }
        //metoda za dohvacanje svih zaposlenika, odjela i tipova korisnika 
        public static List<Zaposlenik> DohvatiZaposlenike()
        {
            List<Zaposlenik> listaZaposlenika = new List<Zaposlenik>();
            List<Zaposlenik> privremenaListaZaposlenika = Zaposlenik.DohvatiSveZaposlenikeIzTablice();
            List<TipKorisnika> listaStatusa = TipKorisnika.DohvatiSveTipove();
            List<Odjel> listaOdjela = Odjel.DohvatiSveOdjele();
            foreach (Zaposlenik zap in privremenaListaZaposlenika)
            {
                foreach (TipKorisnika tip in listaStatusa)
                {
                    if (zap.Status.Id == tip.Id)
                    {
                        zap.Status = tip;
                    }
                }
                foreach (Odjel odj in listaOdjela)
                {
                    if (zap.Odjeli != null)
                    {
                        if (zap.Odjeli.Id == odj.Id)
                        {
                            zap.Odjeli = odj;
                        }
                    }
                    else
                    {
                        zap.Odjeli = null;
                    }
                }
                listaZaposlenika.Add(zap);
            }
            return listaZaposlenika;
        }
    }
}
