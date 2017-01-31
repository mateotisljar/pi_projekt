using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZapApp
{
    public class Odjel
    {
        public int Id { get; set; }
        public string Naziv { get; set; }

        public Odjel() { }

        public Odjel(DbDataReader drOdjeli)
        {
            if (drOdjeli != null)
            {
                Id = Convert.ToInt32(drOdjeli["id"]);
                Naziv = drOdjeli["naziv"].ToString();
            }
        }

        public static List<Odjel> DohvatiSveOdjele()
        {
            List<Odjel> lista = new List<Odjel>();
            string sqlUpit = "select * from Odjeli";
            DbDataReader drOdjeli = BazaPodataka.Instance.DohvatiDataReader(sqlUpit);
            while (drOdjeli.Read())
            {
                Odjel odjel = new Odjel(drOdjeli);
                lista.Add(odjel);
            }
            drOdjeli.Close();
            return lista;
        }
    }
}
