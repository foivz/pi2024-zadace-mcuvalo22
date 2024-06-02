namespace GPVŽ_programsko_rješenje
{
    partial class FrmIzbornik
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
            this.dgvVozilo = new System.Windows.Forms.DataGridView();
            this.btnDodajVozilo = new System.Windows.Forms.Button();
            this.btnIzmjeniVozila = new System.Windows.Forms.Button();
            this.btnBrisiVozila = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPretrazivanje = new System.Windows.Forms.TextBox();
            this.lblPretrazivanje = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVozilo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVozilo
            // 
            this.dgvVozilo.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgvVozilo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVozilo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVozilo.GridColor = System.Drawing.Color.White;
            this.dgvVozilo.Location = new System.Drawing.Point(10, 53);
            this.dgvVozilo.Name = "dgvVozilo";
            this.dgvVozilo.Size = new System.Drawing.Size(852, 322);
            this.dgvVozilo.TabIndex = 0;
            // 
            // btnDodajVozilo
            // 
            this.btnDodajVozilo.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnDodajVozilo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDodajVozilo.ForeColor = System.Drawing.Color.Black;
            this.btnDodajVozilo.Location = new System.Drawing.Point(523, 381);
            this.btnDodajVozilo.Name = "btnDodajVozilo";
            this.btnDodajVozilo.Size = new System.Drawing.Size(109, 33);
            this.btnDodajVozilo.TabIndex = 1;
            this.btnDodajVozilo.Text = "Dodaj novo vozilo";
            this.btnDodajVozilo.UseVisualStyleBackColor = false;
            this.btnDodajVozilo.Click += new System.EventHandler(this.btnDodajVozilo_Click);
            // 
            // btnIzmjeniVozila
            // 
            this.btnIzmjeniVozila.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnIzmjeniVozila.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnIzmjeniVozila.ForeColor = System.Drawing.Color.Black;
            this.btnIzmjeniVozila.Location = new System.Drawing.Point(638, 381);
            this.btnIzmjeniVozila.Name = "btnIzmjeniVozila";
            this.btnIzmjeniVozila.Size = new System.Drawing.Size(109, 33);
            this.btnIzmjeniVozila.TabIndex = 2;
            this.btnIzmjeniVozila.Text = "Izmjeni vozila";
            this.btnIzmjeniVozila.UseVisualStyleBackColor = false;
            this.btnIzmjeniVozila.Click += new System.EventHandler(this.btnPretraziVozila_Click);
            // 
            // btnBrisiVozila
            // 
            this.btnBrisiVozila.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnBrisiVozila.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBrisiVozila.ForeColor = System.Drawing.Color.Black;
            this.btnBrisiVozila.Location = new System.Drawing.Point(753, 381);
            this.btnBrisiVozila.Name = "btnBrisiVozila";
            this.btnBrisiVozila.Size = new System.Drawing.Size(109, 33);
            this.btnBrisiVozila.TabIndex = 3;
            this.btnBrisiVozila.Text = "Briši vozila";
            this.btnBrisiVozila.UseVisualStyleBackColor = false;
            this.btnBrisiVozila.Click += new System.EventHandler(this.btnBrisiVozila_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 4;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtPretrazivanje
            // 
            this.txtPretrazivanje.Location = new System.Drawing.Point(205, 18);
            this.txtPretrazivanje.Name = "txtPretrazivanje";
            this.txtPretrazivanje.Size = new System.Drawing.Size(326, 22);
            this.txtPretrazivanje.TabIndex = 5;
            this.txtPretrazivanje.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblPretrazivanje
            // 
            this.lblPretrazivanje.AutoSize = true;
            this.lblPretrazivanje.BackColor = System.Drawing.Color.Transparent;
            this.lblPretrazivanje.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPretrazivanje.ForeColor = System.Drawing.Color.White;
            this.lblPretrazivanje.Location = new System.Drawing.Point(12, 18);
            this.lblPretrazivanje.Name = "lblPretrazivanje";
            this.lblPretrazivanje.Size = new System.Drawing.Size(187, 19);
            this.lblPretrazivanje.TabIndex = 6;
            this.lblPretrazivanje.Text = "Pretraživanje (marka i stanje):";
            // 
            // FrmIzbornik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = global::GPVŽ_programsko_rješenje.Properties.Resources.Frame_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(871, 426);
            this.Controls.Add(this.lblPretrazivanje);
            this.Controls.Add(this.txtPretrazivanje);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBrisiVozila);
            this.Controls.Add(this.btnIzmjeniVozila);
            this.Controls.Add(this.btnDodajVozilo);
            this.Controls.Add(this.dgvVozilo);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmIzbornik";
            this.Text = "FrmIzbornik";
            this.Load += new System.EventHandler(this.FrmIzbornik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVozilo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVozilo;
        private System.Windows.Forms.Button btnDodajVozilo;
        private System.Windows.Forms.Button btnIzmjeniVozila;
        private System.Windows.Forms.Button btnBrisiVozila;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPretrazivanje;
        private System.Windows.Forms.Label lblPretrazivanje;
    }
}