namespace GPVŽ_programsko_rješenje
{
    partial class FrmDodajVozilo
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
            this.lblMarkaModel = new System.Windows.Forms.Label();
            this.txtMarkaModel = new System.Windows.Forms.TextBox();
            this.lblGodinaProizvodnje = new System.Windows.Forms.Label();
            this.txtGodinaProizvodnje = new System.Windows.Forms.TextBox();
            this.lblRegistracija = new System.Windows.Forms.Label();
            this.txtRegistracija = new System.Windows.Forms.TextBox();
            this.lblKapacitet = new System.Windows.Forms.Label();
            this.txtKapacitet = new System.Windows.Forms.TextBox();
            this.lblTipGoriva = new System.Windows.Forms.Label();
            this.cboTipGoriva = new System.Windows.Forms.ComboBox();
            this.lblStanje = new System.Windows.Forms.Label();
            this.cboStanje = new System.Windows.Forms.ComboBox();
            this.lblVrstaVozila = new System.Windows.Forms.Label();
            this.cboVrstaVozila = new System.Windows.Forms.ComboBox();
            this.btnDodajVozilo = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMarkaModel
            // 
            this.lblMarkaModel.AutoSize = true;
            this.lblMarkaModel.BackColor = System.Drawing.Color.Transparent;
            this.lblMarkaModel.ForeColor = System.Drawing.Color.White;
            this.lblMarkaModel.Location = new System.Drawing.Point(27, 35);
            this.lblMarkaModel.Name = "lblMarkaModel";
            this.lblMarkaModel.Size = new System.Drawing.Size(83, 13);
            this.lblMarkaModel.TabIndex = 0;
            this.lblMarkaModel.Text = "Marka i model ";
            this.lblMarkaModel.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtMarkaModel
            // 
            this.txtMarkaModel.Location = new System.Drawing.Point(30, 52);
            this.txtMarkaModel.Name = "txtMarkaModel";
            this.txtMarkaModel.Size = new System.Drawing.Size(239, 22);
            this.txtMarkaModel.TabIndex = 1;
            // 
            // lblGodinaProizvodnje
            // 
            this.lblGodinaProizvodnje.AutoSize = true;
            this.lblGodinaProizvodnje.BackColor = System.Drawing.Color.Transparent;
            this.lblGodinaProizvodnje.ForeColor = System.Drawing.Color.White;
            this.lblGodinaProizvodnje.Location = new System.Drawing.Point(30, 89);
            this.lblGodinaProizvodnje.Name = "lblGodinaProizvodnje";
            this.lblGodinaProizvodnje.Size = new System.Drawing.Size(109, 13);
            this.lblGodinaProizvodnje.TabIndex = 2;
            this.lblGodinaProizvodnje.Text = "Godina proizvodnje";
            this.lblGodinaProizvodnje.Click += new System.EventHandler(this.lblGodinaProizvodnje_Click);
            // 
            // txtGodinaProizvodnje
            // 
            this.txtGodinaProizvodnje.Location = new System.Drawing.Point(30, 105);
            this.txtGodinaProizvodnje.Name = "txtGodinaProizvodnje";
            this.txtGodinaProizvodnje.Size = new System.Drawing.Size(237, 22);
            this.txtGodinaProizvodnje.TabIndex = 3;
            // 
            // lblRegistracija
            // 
            this.lblRegistracija.AutoSize = true;
            this.lblRegistracija.BackColor = System.Drawing.Color.Transparent;
            this.lblRegistracija.ForeColor = System.Drawing.Color.White;
            this.lblRegistracija.Location = new System.Drawing.Point(30, 143);
            this.lblRegistracija.Name = "lblRegistracija";
            this.lblRegistracija.Size = new System.Drawing.Size(106, 13);
            this.lblRegistracija.TabIndex = 4;
            this.lblRegistracija.Text = "Registarska oznaka";
            this.lblRegistracija.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtRegistracija
            // 
            this.txtRegistracija.Location = new System.Drawing.Point(31, 160);
            this.txtRegistracija.Name = "txtRegistracija";
            this.txtRegistracija.Size = new System.Drawing.Size(236, 22);
            this.txtRegistracija.TabIndex = 5;
            // 
            // lblKapacitet
            // 
            this.lblKapacitet.AutoSize = true;
            this.lblKapacitet.BackColor = System.Drawing.Color.Transparent;
            this.lblKapacitet.ForeColor = System.Drawing.Color.White;
            this.lblKapacitet.Location = new System.Drawing.Point(30, 198);
            this.lblKapacitet.Name = "lblKapacitet";
            this.lblKapacitet.Size = new System.Drawing.Size(54, 13);
            this.lblKapacitet.TabIndex = 6;
            this.lblKapacitet.Text = "Kapacitet";
            // 
            // txtKapacitet
            // 
            this.txtKapacitet.Location = new System.Drawing.Point(31, 215);
            this.txtKapacitet.Name = "txtKapacitet";
            this.txtKapacitet.Size = new System.Drawing.Size(236, 22);
            this.txtKapacitet.TabIndex = 7;
            // 
            // lblTipGoriva
            // 
            this.lblTipGoriva.AutoSize = true;
            this.lblTipGoriva.BackColor = System.Drawing.Color.Transparent;
            this.lblTipGoriva.ForeColor = System.Drawing.Color.White;
            this.lblTipGoriva.Location = new System.Drawing.Point(30, 252);
            this.lblTipGoriva.Name = "lblTipGoriva";
            this.lblTipGoriva.Size = new System.Drawing.Size(58, 13);
            this.lblTipGoriva.TabIndex = 8;
            this.lblTipGoriva.Text = "Tip goriva";
            // 
            // cboTipGoriva
            // 
            this.cboTipGoriva.FormattingEnabled = true;
            this.cboTipGoriva.Items.AddRange(new object[] {
            "Dizel",
            "Benzin",
            "Hibrid",
            "Električno vozilo"});
            this.cboTipGoriva.Location = new System.Drawing.Point(31, 269);
            this.cboTipGoriva.Name = "cboTipGoriva";
            this.cboTipGoriva.Size = new System.Drawing.Size(236, 21);
            this.cboTipGoriva.TabIndex = 9;
            // 
            // lblStanje
            // 
            this.lblStanje.AutoSize = true;
            this.lblStanje.BackColor = System.Drawing.Color.Transparent;
            this.lblStanje.ForeColor = System.Drawing.Color.White;
            this.lblStanje.Location = new System.Drawing.Point(33, 311);
            this.lblStanje.Name = "lblStanje";
            this.lblStanje.Size = new System.Drawing.Size(39, 13);
            this.lblStanje.TabIndex = 10;
            this.lblStanje.Text = "Stanje";
            // 
            // cboStanje
            // 
            this.cboStanje.FormattingEnabled = true;
            this.cboStanje.Items.AddRange(new object[] {
            "Servis",
            "U pogonu",
            "Skladište"});
            this.cboStanje.Location = new System.Drawing.Point(33, 327);
            this.cboStanje.Name = "cboStanje";
            this.cboStanje.Size = new System.Drawing.Size(236, 21);
            this.cboStanje.TabIndex = 11;
            // 
            // lblVrstaVozila
            // 
            this.lblVrstaVozila.AutoSize = true;
            this.lblVrstaVozila.BackColor = System.Drawing.Color.Transparent;
            this.lblVrstaVozila.ForeColor = System.Drawing.Color.White;
            this.lblVrstaVozila.Location = new System.Drawing.Point(33, 366);
            this.lblVrstaVozila.Name = "lblVrstaVozila";
            this.lblVrstaVozila.Size = new System.Drawing.Size(65, 13);
            this.lblVrstaVozila.TabIndex = 12;
            this.lblVrstaVozila.Text = "Vrsta vozila";
            // 
            // cboVrstaVozila
            // 
            this.cboVrstaVozila.FormattingEnabled = true;
            this.cboVrstaVozila.Items.AddRange(new object[] {
            "Autobus",
            "Kombi",
            "Automobil"});
            this.cboVrstaVozila.Location = new System.Drawing.Point(33, 383);
            this.cboVrstaVozila.Name = "cboVrstaVozila";
            this.cboVrstaVozila.Size = new System.Drawing.Size(236, 21);
            this.cboVrstaVozila.TabIndex = 13;
            // 
            // btnDodajVozilo
            // 
            this.btnDodajVozilo.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnDodajVozilo.Location = new System.Drawing.Point(97, 433);
            this.btnDodajVozilo.Name = "btnDodajVozilo";
            this.btnDodajVozilo.Size = new System.Drawing.Size(102, 45);
            this.btnDodajVozilo.TabIndex = 14;
            this.btnDodajVozilo.Text = "Dodaj";
            this.btnDodajVozilo.UseVisualStyleBackColor = true;
            this.btnDodajVozilo.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(111, 484);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 15;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // FrmDodajVozilo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GPVŽ_programsko_rješenje.Properties.Resources.Frame_1;
            this.ClientSize = new System.Drawing.Size(299, 538);
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
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmDodajVozilo";
            this.Text = "Dodaj vozilo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMarkaModel;
        private System.Windows.Forms.TextBox txtMarkaModel;
        private System.Windows.Forms.Label lblGodinaProizvodnje;
        private System.Windows.Forms.TextBox txtGodinaProizvodnje;
        private System.Windows.Forms.Label lblRegistracija;
        private System.Windows.Forms.TextBox txtRegistracija;
        private System.Windows.Forms.Label lblKapacitet;
        private System.Windows.Forms.TextBox txtKapacitet;
        private System.Windows.Forms.Label lblTipGoriva;
        private System.Windows.Forms.ComboBox cboTipGoriva;
        private System.Windows.Forms.Label lblStanje;
        private System.Windows.Forms.ComboBox cboStanje;
        private System.Windows.Forms.Label lblVrstaVozila;
        private System.Windows.Forms.ComboBox cboVrstaVozila;
        private System.Windows.Forms.Button btnDodajVozilo;
        private System.Windows.Forms.Button btnOdustani;
    }
}