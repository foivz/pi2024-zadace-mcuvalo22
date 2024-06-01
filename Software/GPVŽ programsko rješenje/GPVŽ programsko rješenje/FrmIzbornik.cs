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
    public partial class FrmIzbornik : Form
    {
        public FrmIzbornik()
        {
            InitializeComponent();
        }

        private void ShowVozila()
        {
            var vozila = VozilaRepositorij.GetVozila();
            dgvVozilo.DataSource = vozila;
        }
        private void FrmIzbornik_Load(object sender, EventArgs e)
        {
            ShowVozila();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPretraziVozila_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtPretrazivanje.Text.Trim();
            if (!string.IsNullOrWhiteSpace(searchText))
            {
                var vozilo = VozilaRepositorij.Search(searchText);
                dgvVozilo .DataSource = vozilo;
            }
            else
            {
                ShowVozila();
            }
        }

        private void btnBrisiVozila_Click(object sender, EventArgs e)
        {
            Vozila selectedvozilo =dgvVozilo.CurrentRow.DataBoundItem as Vozila;
            DialogResult result = MessageBox.Show("Želite li obrisati označeno vozilo?", "Brisanje autobusa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                VozilaRepositorij.Delete(selectedvozilo.ID_Vozila);
                MessageBox.Show("Autobus je uspješno obrisan!", "Uspješno brisanje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowVozila();
            }
        }

        private void btnDodajVozilo_Click(object sender, EventArgs e)
        {
            FrmDodajVozilo frmDodajVozilo = new FrmDodajVozilo();
            frmDodajVozilo.ShowDialog();
            ShowVozila();
        }
    }
}
