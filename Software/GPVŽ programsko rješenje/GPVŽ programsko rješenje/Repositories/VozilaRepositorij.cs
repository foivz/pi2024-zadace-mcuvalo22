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
    internal class VozilaRepositorij
    {
        public static List<Vozila> GetVozila()
        {
            List<Vozila> vozila = new List<Vozila>();
            string sql = "SELECT * FROM Vozila";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Vozila vozila1 = CreateObject(reader);
                vozila.Add(vozila1);
            }
            reader.Close();
            DB.CloseConnection();
            return vozila;
        }
        private static Vozila CreateObject(SqlDataReader reader)
        {
            int ID_Vozila = int.Parse(reader["ID_vozila"].ToString());
            string MarkaModel = reader["MarkaModel"].ToString();
            string GodinaProizvodnje = reader["GodinaProizvodnje"].ToString();
            string Registracija = reader["RegistarskaOznaka"].ToString();
            string Kapacitet = reader["Kapacitet"].ToString();
            string TipGoriva = reader["TipGoriva"].ToString();
            string Stanje = reader["Stanje"].ToString();
            string VrstaVozila = reader["VrstaVozila"].ToString();
            var vozila = new Vozila
            {
                ID_Vozila = ID_Vozila,
                MarkaModel = MarkaModel,
                GodinaProizvodnje = GodinaProizvodnje,
                Registracija = Registracija,
                Kapacitet = Kapacitet,
                TipGoriva = TipGoriva,
                Stanje = Stanje,
                VrstaVozila = VrstaVozila
            };
            return vozila;
        }

        public static void Delete(int ID_Vozila)
        {
            string sql = $"DELETE FROM Vozila WHERE ID_Vozila = {ID_Vozila}";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public static List<Vozila> Search(string searchText)
        {
            List<Vozila> vozila = new List<Vozila>();
            string sql = $"SELECT * FROM Vozila WHERE MarkaModel LIKE '%{searchText}%' OR Stanje LIKE '%{searchText}%'";
            DB.OpenConnection();
            SqlDataReader reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Vozila vozilo = new Vozila
                {
                    ID_Vozila = int.Parse(reader["ID_vozila"].ToString()),
                    MarkaModel = reader["MarkaModel"].ToString(),
                    GodinaProizvodnje =reader["GodinaProizvodnje"].ToString(),
                    Registracija = reader["RegistarskaOznaka"].ToString(),
                    Kapacitet =reader["Kapacitet"].ToString(),
                    TipGoriva = reader["TipGoriva"].ToString(),
                    Stanje = reader["Stanje"].ToString(),
                    VrstaVozila = reader["VrstaVozila"].ToString()
                };
                vozila.Add(vozilo);
            }
            reader.Close();
            DB.CloseConnection();
            return vozila;
        }

        public static void Insert(string marka, string godina, string registracija, string kapacitet, string tip, string stanje, string vrsta)
        {
            string sql = $"INSERT INTO Vozila (MarkaModel,GodinaProizvodnje,RegistarskaOznaka,Kapacitet,TipGoriva,Stanje,VrstaVozila) VALUES ('{marka}','{godina}','{registracija}', '{kapacitet}','{tip}','{stanje}','{vrsta}')";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection() ;
        }

        public static void Update(string marka, string godina, string registracija, string kapacitet, string tip, string stanje, string vrsta, int idvozila)
        {
            string sql = $"UPDATE Vozila SET MarkaModel = '{marka}', GodinaProizvodnje='{godina}',RegistarskaOznaka='{registracija}', Kapacitet ='{kapacitet}',TipGoriva='{tip}',Stanje='{stanje}',VrstaVozila='{vrsta}' WHERE ID_vozila ='{idvozila}'";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

    }

}
