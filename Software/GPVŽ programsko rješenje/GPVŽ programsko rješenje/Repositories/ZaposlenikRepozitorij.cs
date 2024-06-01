using DBLayer;
using GPVŽ_programsko_rješenje.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPVŽ_programsko_rješenje.Repositories
{
    internal class ZaposlenikRepozitorij
    {
        public static Zaposlenik GetZaposlenika(string korime)
        {
            string sql = $"SELECT * FROM Zaposlenik WHERE KorisnickoIme = '{korime}'";
            return FetchZaposlenika(sql);
        }
          
        public static Zaposlenik GetZaposlenika(int id)
        {
            string sql = $"SELECT * FROM Zaposlenik WHERE ID_Zaposlenik = {id}";
            return FetchZaposlenika(sql);
        }
        public static List<Zaposlenik> GetZaposlenika()
        {
            var zaposlenik = new List<Zaposlenik>();
            string sql = "SELECT * FROM Zaposlenik";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Zaposlenik zaposlenik1 = CreateObject(reader);
                zaposlenik.Add(zaposlenik1);
            }
            reader.Close();
            DB.CloseConnection();
            return zaposlenik;
        }

        private static Zaposlenik FetchZaposlenika(string sql)
        {
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            Zaposlenik zaposlenik = null;

            if (reader.HasRows == true)
            {
                reader.Read();
                zaposlenik = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();

            return zaposlenik;
        }

        private static Zaposlenik CreateObject(SqlDataReader reader)
        {
            int ID_Zaposlenik = int.Parse(reader["ID_Zaposlenik"].ToString());
            string Ime = reader["Ime"].ToString();
            string Prezime = reader["Prezime"].ToString();
            string KorisnickoIme = reader["KorisnickoIme"].ToString();
            string Lozinka = reader["Lozinka"].ToString();
            var zaposlenik = new Zaposlenik
            {
                ID_Zaposlenik = ID_Zaposlenik,
                Ime = Ime,
                Prezime = Prezime,
                KorisnickoIme = KorisnickoIme,
                Lozinka = Lozinka
            };
            return zaposlenik;
        }
    }
}
