using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPVŽ_programsko_rješenje.Models
{
    public class Vozila
    {
        public int ID_Vozila { get; set; }
        public string MarkaModel { get; set; }
        public string GodinaProizvodnje { get; set; }
        public string Registracija { get; set; }
        public string Kapacitet { get; set; }
        public string TipGoriva { get; set; }
        public string Stanje { get; set; }
        public string VrstaVozila { get; set; }
        public override string ToString()
        {
            return MarkaModel;
        }
    }
}
