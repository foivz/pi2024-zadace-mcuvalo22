using GPVŽ_programsko_rješenje.Models;
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
    public partial class FrmAzuriranje : Form
    {
        private Vozila selectedvozilo;
        public FrmAzuriranje(Vozila selectedvozilo)
        {
            InitializeComponent();
            this.selectedvozilo = selectedvozilo;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmAzuriranje_Load(object sender, EventArgs e)
        {
            txtMarkaModel.Text=selectedvozilo.MarkaModel;
            txtGodinaProizvodnje.Text = selectedvozilo.GodinaProizvodnje.ToString();
            txtRegistracija.Text = selectedvozilo.Registracija;
            txtKapacitet.Text=selectedvozilo.Kapacitet.ToString();
            cboTipGoriva.SelectedItem=selectedvozilo.TipGoriva.ToString();
            cboStanje.SelectedItem=selectedvozilo.Stanje.ToString();
            cboVrstaVozila.SelectedItem=selectedvozilo.VrstaVozila.ToString();

        }

        private void btnDodajVozilo_Click(object sender, EventArgs e)
        {
            VozilaRepositorij.Update(txtMarkaModel.Text,txtGodinaProizvodnje.Text,txtRegistracija.Text,txtKapacitet.Text,cboTipGoriva.SelectedItem.ToString(),cboStanje.SelectedItem.ToString(),cboVrstaVozila.SelectedItem.ToString(),selectedvozilo.ID_Vozila);
            Close();
        }

        private void cboTipGoriva_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
