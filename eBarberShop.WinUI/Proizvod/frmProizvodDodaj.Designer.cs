namespace eBarberShop.WinUI
{
    partial class frmProizvodDodaj
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDodajProizvod = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbVrstaProizvoda = new System.Windows.Forms.ComboBox();
            this.btnDodajSliku = new System.Windows.Forms.Button();
            this.pbSlika = new System.Windows.Forms.PictureBox();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDodajProizvod);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbVrstaProizvoda);
            this.groupBox1.Controls.Add(this.btnDodajSliku);
            this.groupBox1.Controls.Add(this.pbSlika);
            this.groupBox1.Controls.Add(this.txtCijena);
            this.groupBox1.Controls.Add(this.txtNaziv);
            this.groupBox1.Location = new System.Drawing.Point(124, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 362);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proizvod";
            // 
            // btnDodajProizvod
            // 
            this.btnDodajProizvod.Location = new System.Drawing.Point(180, 309);
            this.btnDodajProizvod.Name = "btnDodajProizvod";
            this.btnDodajProizvod.Size = new System.Drawing.Size(194, 29);
            this.btnDodajProizvod.TabIndex = 4;
            this.btnDodajProizvod.Text = "Dodaj proizvod";
            this.btnDodajProizvod.UseVisualStyleBackColor = true;
            this.btnDodajProizvod.Click += new System.EventHandler(this.btnDodajProizvod_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Vrsta proizvoda";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naziv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cijena";
            // 
            // cmbVrstaProizvoda
            // 
            this.cmbVrstaProizvoda.FormattingEnabled = true;
            this.cmbVrstaProizvoda.Location = new System.Drawing.Point(58, 173);
            this.cmbVrstaProizvoda.Name = "cmbVrstaProizvoda";
            this.cmbVrstaProizvoda.Size = new System.Drawing.Size(194, 28);
            this.cmbVrstaProizvoda.TabIndex = 1;
            this.cmbVrstaProizvoda.Validating += new System.ComponentModel.CancelEventHandler(this.cmbVrstaProizvoda_Validating);
            // 
            // btnDodajSliku
            // 
            this.btnDodajSliku.Location = new System.Drawing.Point(58, 237);
            this.btnDodajSliku.Name = "btnDodajSliku";
            this.btnDodajSliku.Size = new System.Drawing.Size(194, 29);
            this.btnDodajSliku.TabIndex = 1;
            this.btnDodajSliku.Text = "Dodaj sliku";
            this.btnDodajSliku.UseVisualStyleBackColor = true;
            this.btnDodajSliku.Click += new System.EventHandler(this.btnDodajSliku_Click);
            // 
            // pbSlika
            // 
            this.pbSlika.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSlika.Location = new System.Drawing.Point(312, 54);
            this.pbSlika.Name = "pbSlika";
            this.pbSlika.Size = new System.Drawing.Size(182, 212);
            this.pbSlika.TabIndex = 2;
            this.pbSlika.TabStop = false;
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(60, 113);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(192, 27);
            this.txtCijena.TabIndex = 1;
            this.txtCijena.TextChanged += new System.EventHandler(this.txtCijena_TextChanged);
            this.txtCijena.Validating += new System.ComponentModel.CancelEventHandler(this.txtCijena_Validating);
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(58, 54);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(194, 27);
            this.txtNaziv.TabIndex = 0;
            this.txtNaziv.Validating += new System.ComponentModel.CancelEventHandler(this.txtNaziv_Validating);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmProizvodDodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmProizvodDodaj";
            this.Text = "frmProizvodDodaj";
            this.Load += new System.EventHandler(this.frmProizvodDodaj_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtNaziv;
        private PictureBox pbSlika;
        private TextBox txtCijena;
        private Label label3;
        private Label label1;
        private Label label2;
        private ComboBox cmbVrstaProizvoda;
        private Button btnDodajSliku;
        private OpenFileDialog openFileDialog1;
        private Button btnDodajProizvod;
        private ErrorProvider errorProvider;
    }
}