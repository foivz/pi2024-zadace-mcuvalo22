using GPVŽ_programsko_rješenje.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPVŽ_programsko_rješenje
{
    public partial class FrmDodajVozilo : Form
    {
        public FrmDodajVozilo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblGodinaProizvodnje_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            VozilaRepositorij.Insert(txtMarkaModel.Text,txtGodinaProizvodnje.Text,txtRegistracija.Text,txtKapacitet.Text,cboTipGoriva.SelectedItem.ToString(),cboStanje.SelectedItem.ToString(),cboVrstaVozila.SelectedItem.ToString());
            Close();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
