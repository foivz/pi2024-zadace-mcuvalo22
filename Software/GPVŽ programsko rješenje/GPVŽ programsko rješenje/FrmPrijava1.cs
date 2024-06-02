using DBLayer;
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
    public partial class FrmLogin : Form
    {
        public static Zaposlenik LoggedZaposlenik { get; set; }

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void lblKorime_Click(object sender, EventArgs e)
        {

        }

        private void txtKorime_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblLozinka_Click(object sender, EventArgs e)
        {

        }

        private void txtLozinka_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            string username = txtKorime.Text;
            string password = txtLozinka.Text.Trim();
            Zaposlenik zaposlenik = ZaposlenikRepozitorij.GetZaposlenika(username);

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Nista nista upisali", "Pogreška!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (zaposlenik != null && zaposlenik.Lozinka.Trim() == password)
            {
                this.Hide();
                FrmIzbornik frmIzbornik = new FrmIzbornik();
                frmIzbornik.Closed += (s, args) => this.Close();
                frmIzbornik.Show();
            }
            else
            {
                MessageBox.Show("Unijeli ste krivo korisničko ime ili lozinku", "Neuspješna prijava", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            DB.SetConfiguration("PI2324_mcuvalo22_DB", "PI2324_mcuvalo22_User", "c-)%{Gwl");
            
        }
    }
}
