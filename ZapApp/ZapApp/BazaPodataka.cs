/*using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZapApp
{
    class BazaPodataka
    {
        private static BazaPodataka instance;
        private string sqlConnectionString;
        private SqlConnection connection;
        public static BazaPodataka Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BazaPodataka();
                }
                return instance;
            }
        }

        public string SqlConnectionString
        {
            get { return sqlConnectionString; }
            private set { sqlConnectionString = value; }
        }

        public SqlConnection Connection
        {
            get { return connection; }
            set { connection = value; }
        }

        private BazaPodataka()
        {
            sqlConnectionString = "server=31.147.204.119; uid=16011_User; pwd=EJsRauDq;database=16011_DB";
            Connection = new SqlConnection(sqlConnectionString);
            Connection.Open();
        }
        ~BazaPodataka()
        {
            
            Connection = null;
        }

        
        public object DohvatiVrijednost(string sqlUpit)
        {
            SqlCommand command = new SqlCommand(sqlUpit, Connection);
            return command.ExecuteScalar();
        }
        public int IzvrsiUpit(string sqlUpit)
        {
            SqlCommand command = new SqlCommand(sqlUpit, Connection);
            return command.ExecuteNonQuery();
        }
    }
}
*/