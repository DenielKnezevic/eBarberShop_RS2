namespace eBarberShop.WinUI.Termin
{
    partial class frmTerminDodaj
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.txtVrijeme = new System.Windows.Forms.TextBox();
            this.cmbUposlenici = new System.Windows.Forms.ComboBox();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnDodaj);
            this.groupBox1.Controls.Add(this.txtVrijeme);
            this.groupBox1.Controls.Add(this.cmbUposlenici);
            this.groupBox1.Controls.Add(this.dtpDatum);
            this.groupBox1.Location = new System.Drawing.Point(165, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Termin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Datum termina";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(179, 320);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(94, 29);
            this.btnDodaj.TabIndex = 3;
            this.btnDodaj.Text = "Dodaj termin";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // txtVrijeme
            // 
            this.txtVrijeme.Location = new System.Drawing.Point(106, 229);
            this.txtVrijeme.Name = "txtVrijeme";
            this.txtVrijeme.Size = new System.Drawing.Size(250, 27);
            this.txtVrijeme.TabIndex = 2;
            this.txtVrijeme.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cmbUposlenici
            // 
            this.cmbUposlenici.FormattingEnabled = true;
            this.cmbUposlenici.Location = new System.Drawing.Point(106, 152);
            this.cmbUposlenici.Name = "cmbUposlenici";
            this.cmbUposlenici.Size = new System.Drawing.Size(250, 28);
            this.cmbUposlenici.TabIndex = 1;
            this.cmbUposlenici.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(106, 85);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(250, 27);
            this.dtpDatum.TabIndex = 0;
            this.dtpDatum.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Uposlenik";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Vrijeme termina";
            // 
            // frmTerminDodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTerminDodaj";
            this.Text = "frmTerminDodaj";
            this.Load += new System.EventHandler(this.frmTerminDodaj_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Button btnDodaj;
        private TextBox txtVrijeme;
        private ComboBox cmbUposlenici;
        private DateTimePicker dtpDatum;
        private Label label3;
        private Label label2;
    }
}