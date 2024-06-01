using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPVŽ_programsko_rješenje.Models
{
    public class Zaposlenik
    {
        public int ID_Zaposlenik { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string KorisnickoIme { get; set; }
        public string Lozinka {  get; set; }

        public override string ToString()
        {
            return Ime + " " + Prezime;
        }

    }
}
