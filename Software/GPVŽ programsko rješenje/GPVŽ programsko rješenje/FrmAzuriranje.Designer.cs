namespace GPVŽ_programsko_rješenje
{
    partial class FrmAzuriranje
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnDodajVozilo = new System.Windows.Forms.Button();
            this.cboVrstaVozila = new System.Windows.Forms.ComboBox();
            this.lblVrstaVozila = new System.Windows.Forms.Label();
            this.cboStanje = new System.Windows.Forms.ComboBox();
            this.lblStanje = new System.Windows.Forms.Label();
            this.cboTipGoriva = new System.Windows.Forms.ComboBox();
            this.lblTipGoriva = new System.Windows.Forms.Label();
            this.txtKapacitet = new System.Windows.Forms.TextBox();
            this.lblKapacitet = new System.Windows.Forms.Label();
            this.txtRegistracija = new System.Windows.Forms.TextBox();
            this.lblRegistracija = new System.Windows.Forms.Label();
            this.txtGodinaProizvodnje = new System.Windows.Forms.TextBox();
            this.lblGodinaProizvodnje = new System.Windows.Forms.Label();
            this.txtMarkaModel = new System.Windows.Forms.TextBox();
            this.lblMarkaModel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(122, 494);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 31;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnDodajVozilo
            // 
            this.btnDodajVozilo.Location = new System.Drawing.Point(108, 443);
            this.btnDodajVozilo.Name = "btnDodajVozilo";
            this.btnDodajVozilo.Size = new System.Drawing.Size(102, 45);
            this.btnDodajVozilo.TabIndex = 30;
            this.btnDodajVozilo.Text = "DODAJ";
            this.btnDodajVozilo.UseVisualStyleBackColor = true;
            this.btnDodajVozilo.Click += new System.EventHandler(this.btnDodajVozilo_Click);
            // 
            // cboVrstaVozila
            // 
            this.cboVrstaVozila.FormattingEnabled = true;
            this.cboVrstaVozila.Items.AddRange(new object[] {
            "Autobus",
            "Kombi",
            "Automobil"});
            this.cboVrstaVozila.Location = new System.Drawing.Point(44, 393);
            this.cboVrstaVozila.Name = "cboVrstaVozila";
            this.cboVrstaVozila.Size = new System.Drawing.Size(121, 21);
            this.cboVrstaVozila.TabIndex = 29;
            // 
            // lblVrstaVozila
            // 
            this.lblVrstaVozila.AutoSize = true;
            this.lblVrstaVozila.Location = new System.Drawing.Point(44, 376);
            this.lblVrstaVozila.Name = "lblVrstaVozila";
            this.lblVrstaVozila.Size = new System.Drawing.Size(61, 13);
            this.lblVrstaVozila.TabIndex = 28;
            this.lblVrstaVozila.Text = "Vrsta vozila";
            // 
            // cboStanje
            // 
            this.cboStanje.FormattingEnabled = true;
            this.cboStanje.Items.AddRange(new object[] {
            "Servis",
            "U pogonu",
            "Skladište"});
            this.cboStanje.Location = new System.Drawing.Point(44, 337);
            this.cboStanje.Name = "cboStanje";
            this.cboStanje.Size = new System.Drawing.Size(121, 21);
            this.cboStanje.TabIndex = 27;
            // 
            // lblStanje
            // 
            this.lblStanje.AutoSize = true;
            this.lblStanje.Location = new System.Drawing.Point(44, 321);
            this.lblStanje.Name = "lblStanje";
            this.lblStanje.Size = new System.Drawing.Size(37, 13);
            this.lblStanje.TabIndex = 26;
            this.lblStanje.Text = "Stanje";
            // 
            // cboTipGoriva
            // 
            this.cboTipGoriva.FormattingEnabled = true;
            this.cboTipGoriva.Items.AddRange(new object[] {
            "Dizel",
            "Benzin",
            "Hibrid",
            "Električno vozilo"});
            this.cboTipGoriva.Location = new System.Drawing.Point(42, 279);
            this.cboTipGoriva.Name = "cboTipGoriva";
            this.cboTipGoriva.Size = new System.Drawing.Size(121, 21);
            this.cboTipGoriva.TabIndex = 25;
            this.cboTipGoriva.SelectedIndexChanged += new System.EventHandler(this.cboTipGoriva_SelectedIndexChanged);
            // 
            // lblTipGoriva
            // 
            this.lblTipGoriva.AutoSize = true;
            this.lblTipGoriva.Location = new System.Drawing.Point(41, 262);
            this.lblTipGoriva.Name = "lblTipGoriva";
            this.lblTipGoriva.Size = new System.Drawing.Size(54, 13);
            this.lblTipGoriva.TabIndex = 24;
            this.lblTipGoriva.Text = "Tip goriva";
            // 
            // txtKapacitet
            // 
            this.txtKapacitet.Location = new System.Drawing.Point(42, 225);
            this.txtKapacitet.Name = "txtKapacitet";
            this.txtKapacitet.Size = new System.Drawing.Size(121, 20);
            this.txtKapacitet.TabIndex = 23;
            // 
            // lblKapacitet
            // 
            this.lblKapacitet.AutoSize = true;
            this.lblKapacitet.Location = new System.Drawing.Point(41, 208);
            this.lblKapacitet.Name = "lblKapacitet";
            this.lblKapacitet.Size = new System.Drawing.Size(52, 13);
            this.lblKapacitet.TabIndex = 22;
            this.lblKapacitet.Text = "Kapacitet";
            // 
            // txtRegistracija
            // 
            this.txtRegistracija.Location = new System.Drawing.Point(42, 170);
            this.txtRegistracija.Name = "txtRegistracija";
            this.txtRegistracija.Size = new System.Drawing.Size(121, 20);
            this.txtRegistracija.TabIndex = 21;
            // 
            // lblRegistracija
            // 
            this.lblRegistracija.AutoSize = true;
            this.lblRegistracija.Location = new System.Drawing.Point(41, 153);
            this.lblRegistracija.Name = "lblRegistracija";
            this.lblRegistracija.Size = new System.Drawing.Size(101, 13);
            this.lblRegistracija.TabIndex = 20;
            this.lblRegistracija.Text = "Registarska oznaka";
            // 
            // txtGodinaProizvodnje
            // 
            this.txtGodinaProizvodnje.Location = new System.Drawing.Point(41, 115);
            this.txtGodinaProizvodnje.Name = "txtGodinaProizvodnje";
            this.txtGodinaProizvodnje.Size = new System.Drawing.Size(122, 20);
            this.txtGodinaProizvodnje.TabIndex = 19;
            // 
            // lblGodinaProizvodnje
            // 
            this.lblGodinaProizvodnje.AutoSize = true;
            this.lblGodinaProizvodnje.Location = new System.Drawing.Point(41, 99);
            this.lblGodinaProizvodnje.Name = "lblGodinaProizvodnje";
            this.lblGodinaProizvodnje.Size = new System.Drawing.Size(98, 13);
            this.lblGodinaProizvodnje.TabIndex = 18;
            this.lblGodinaProizvodnje.Text = "Godina proizvodnje";
            // 
            // txtMarkaModel
            // 
            this.txtMarkaModel.Location = new System.Drawing.Point(41, 62);
            this.txtMarkaModel.Name = "txtMarkaModel";
            this.txtMarkaModel.Size = new System.Drawing.Size(239, 20);
            this.txtMarkaModel.TabIndex = 17;
            // 
            // lblMarkaModel
            // 
            this.lblMarkaModel.AutoSize = true;
            this.lblMarkaModel.Location = new System.Drawing.Point(38, 45);
            this.lblMarkaModel.Name = "lblMarkaModel";
            this.lblMarkaModel.Size = new System.Drawing.Size(76, 13);
            this.lblMarkaModel.TabIndex = 16;
            this.lblMarkaModel.Text = "Marka i model ";
            // 
            // FrmAzuriranje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 562);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnDodajVozilo);
            this.Controls.Add(this.cboVrstaVozila);
            this.Controls.Add(this.lblVrstaVozila);
            this.Controls.Add(this.cboStanje);
            this.Controls.Add(this.lblStanje);
            this.Controls.Add(this.cboTipGoriva);
            this.Controls.Add(this.lblTipGoriva);
            this.Controls.Add(this.txtKapacitet);
            this.Controls.Add(this.lblKapacitet);
            this.Controls.Add(this.txtRegistracija);
            this.Controls.Add(this.lblRegistracija);
            this.Controls.Add(this.txtGodinaProizvodnje);
            this.Controls.Add(this.lblGodinaProizvodnje);
            this.Controls.Add(this.txtMarkaModel);
            this.Controls.Add(this.lblMarkaModel);
            this.Name = "FrmAzuriranje";
            this.Text = "FrmAzuriranje";
            this.Load += new System.EventHandler(this.FrmAzuriranje_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnDodajVozilo;
        private System.Windows.Forms.ComboBox cboVrstaVozila;
        private System.Windows.Forms.Label lblVrstaVozila;
        private System.Windows.Forms.ComboBox cboStanje;
        private System.Windows.Forms.Label lblStanje;
        private System.Windows.Forms.ComboBox cboTipGoriva;
        private System.Windows.Forms.Label lblTipGoriva;
        private System.Windows.Forms.TextBox txtKapacitet;
        private System.Windows.Forms.Label lblKapacitet;
        private System.Windows.Forms.TextBox txtRegistracija;
        private System.Windows.Forms.Label lblRegistracija;
        private System.Windows.Forms.TextBox txtGodinaProizvodnje;
        private System.Windows.Forms.Label lblGodinaProizvodnje;
        private System.Windows.Forms.TextBox txtMarkaModel;
        private System.Windows.Forms.Label lblMarkaModel;
    }
}