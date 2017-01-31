using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZapApp
{
    public class TipKorisnika
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        
        public TipKorisnika(DbDataReader drStatus)
        {
            if (drStatus != null)
            {
                Id = Convert.ToInt32(drStatus["id"]);
                Naziv = drStatus["naziv"].ToString();
            }
        }
        public TipKorisnika() { }

        public static List<TipKorisnika> DohvatiSveTipove()
        {
            List<TipKorisnika> lista = new List<TipKorisnika>();
            string sqlUpit = "Select * from statusZaposlenika";
            DbDataReader drStatus = BazaPodataka.Instance.DohvatiDataReader(sqlUpit);
            while (drStatus.Read())
            {
                TipKorisnika tip = new TipKorisnika(drStatus);
                lista.Add(tip);
            }
            drStatus.Close();
            return lista;
        }
    }
}
