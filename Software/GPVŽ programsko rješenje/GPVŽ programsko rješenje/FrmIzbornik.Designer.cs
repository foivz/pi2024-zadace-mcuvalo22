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
            ((System.ComponentModel.ISupportInitialize)(this.dgvVozilo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVozilo
            // 
            this.dgvVozilo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVozilo.Location = new System.Drawing.Point(57, 73);
            this.dgvVozilo.Name = "dgvVozilo";
            this.dgvVozilo.Size = new System.Drawing.Size(580, 322);
            this.dgvVozilo.TabIndex = 0;
            // 
            // btnDodajVozilo
            // 
            this.btnDodajVozilo.Location = new System.Drawing.Point(57, 428);
            this.btnDodajVozilo.Name = "btnDodajVozilo";
            this.btnDodajVozilo.Size = new System.Drawing.Size(130, 55);
            this.btnDodajVozilo.TabIndex = 1;
            this.btnDodajVozilo.Text = "Dodaj novo vozilo";
            this.btnDodajVozilo.UseVisualStyleBackColor = true;
            this.btnDodajVozilo.Click += new System.EventHandler(this.btnDodajVozilo_Click);
            // 
            // btnIzmjeniVozila
            // 
            this.btnIzmjeniVozila.Location = new System.Drawing.Point(281, 428);
            this.btnIzmjeniVozila.Name = "btnIzmjeniVozila";
            this.btnIzmjeniVozila.Size = new System.Drawing.Size(130, 55);
            this.btnIzmjeniVozila.TabIndex = 2;
            this.btnIzmjeniVozila.Text = "Izmjeni vozila";
            this.btnIzmjeniVozila.UseVisualStyleBackColor = true;
            this.btnIzmjeniVozila.Click += new System.EventHandler(this.btnPretraziVozila_Click);
            // 
            // btnBrisiVozila
            // 
            this.btnBrisiVozila.Location = new System.Drawing.Point(507, 428);
            this.btnBrisiVozila.Name = "btnBrisiVozila";
            this.btnBrisiVozila.Size = new System.Drawing.Size(130, 55);
            this.btnBrisiVozila.TabIndex = 3;
            this.btnBrisiVozila.Text = "Briši vozila";
            this.btnBrisiVozila.UseVisualStyleBackColor = true;
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
            this.txtPretrazivanje.Location = new System.Drawing.Point(57, 37);
            this.txtPretrazivanje.Name = "txtPretrazivanje";
            this.txtPretrazivanje.Size = new System.Drawing.Size(100, 20);
            this.txtPretrazivanje.TabIndex = 5;
            this.txtPretrazivanje.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FrmIzbornik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 507);
            this.Controls.Add(this.txtPretrazivanje);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBrisiVozila);
            this.Controls.Add(this.btnIzmjeniVozila);
            this.Controls.Add(this.btnDodajVozilo);
            this.Controls.Add(this.dgvVozilo);
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
    }
}