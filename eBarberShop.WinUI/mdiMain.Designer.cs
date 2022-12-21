namespace eBarberShop.WinUI
{
    partial class mdiMain
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.Uposlenici = new System.Windows.Forms.ToolStripMenuItem();
            this.UposlenikPregled = new System.Windows.Forms.ToolStripMenuItem();
            this.UposlenikDodaj = new System.Windows.Forms.ToolStripMenuItem();
            this.Proizvodi = new System.Windows.Forms.ToolStripMenuItem();
            this.PregledProizvoda = new System.Windows.Forms.ToolStripMenuItem();
            this.DodajProizvod = new System.Windows.Forms.ToolStripMenuItem();
            this.Rezervacije = new System.Windows.Forms.ToolStripMenuItem();
            this.RezervacijaPregled = new System.Windows.Forms.ToolStripMenuItem();
            this.Termini = new System.Windows.Forms.ToolStripMenuItem();
            this.PregledTermina = new System.Windows.Forms.ToolStripMenuItem();
            this.DodajTermin = new System.Windows.Forms.ToolStripMenuItem();
            this.Novosti = new System.Windows.Forms.ToolStripMenuItem();
            this.NovostiPregled = new System.Windows.Forms.ToolStripMenuItem();
            this.NovostiDodaj = new System.Windows.Forms.ToolStripMenuItem();
            this.Slike = new System.Windows.Forms.ToolStripMenuItem();
            this.SlikaPregled = new System.Windows.Forms.ToolStripMenuItem();
            this.SlikaDodaj = new System.Windows.Forms.ToolStripMenuItem();
            this.Arhiva = new System.Windows.Forms.ToolStripMenuItem();
            this.ArhivaPregled = new System.Windows.Forms.ToolStripMenuItem();
            this.Narudzba = new System.Windows.Forms.ToolStripMenuItem();
            this.NarudzbaPregled = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Uposlenici,
            this.Proizvodi,
            this.Rezervacije,
            this.Narudzba,
            this.Termini,
            this.Novosti,
            this.Slike,
            this.Arhiva});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip.Size = new System.Drawing.Size(843, 30);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // Uposlenici
            // 
            this.Uposlenici.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UposlenikPregled,
            this.UposlenikDodaj});
            this.Uposlenici.Name = "Uposlenici";
            this.Uposlenici.Size = new System.Drawing.Size(92, 24);
            this.Uposlenici.Text = "Uposlenici";
            this.Uposlenici.Visible = false;
            this.Uposlenici.Click += new System.EventHandler(this.Uposlenici_Click_1);
            // 
            // UposlenikPregled
            // 
            this.UposlenikPregled.Name = "UposlenikPregled";
            this.UposlenikPregled.Size = new System.Drawing.Size(218, 26);
            this.UposlenikPregled.Text = "Pregled uposlenika";
            this.UposlenikPregled.Click += new System.EventHandler(this.UposlenikPregled_Click);
            // 
            // UposlenikDodaj
            // 
            this.UposlenikDodaj.Name = "UposlenikDodaj";
            this.UposlenikDodaj.Size = new System.Drawing.Size(218, 26);
            this.UposlenikDodaj.Text = "Dodaj uposlenika";
            this.UposlenikDodaj.Click += new System.EventHandler(this.UposlenikDodaj_Click);
            // 
            // Proizvodi
            // 
            this.Proizvodi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PregledProizvoda,
            this.DodajProizvod});
            this.Proizvodi.Name = "Proizvodi";
            this.Proizvodi.Size = new System.Drawing.Size(85, 24);
            this.Proizvodi.Text = "Proizvodi";
            this.Proizvodi.Visible = false;
            this.Proizvodi.Click += new System.EventHandler(this.Proizvodi_Click);
            // 
            // PregledProizvoda
            // 
            this.PregledProizvoda.Name = "PregledProizvoda";
            this.PregledProizvoda.Size = new System.Drawing.Size(214, 26);
            this.PregledProizvoda.Text = "Pregled proizvoda";
            this.PregledProizvoda.Click += new System.EventHandler(this.PregledProizvoda_Click);
            // 
            // DodajProizvod
            // 
            this.DodajProizvod.Name = "DodajProizvod";
            this.DodajProizvod.Size = new System.Drawing.Size(214, 26);
            this.DodajProizvod.Text = "Dodaj proizvod";
            this.DodajProizvod.Click += new System.EventHandler(this.DodajProizvod_Click);
            // 
            // Rezervacije
            // 
            this.Rezervacije.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RezervacijaPregled});
            this.Rezervacije.Name = "Rezervacije";
            this.Rezervacije.Size = new System.Drawing.Size(98, 24);
            this.Rezervacije.Text = "Rezervacije";
            this.Rezervacije.Visible = false;
            this.Rezervacije.Click += new System.EventHandler(this.Rezervacije_Click);
            // 
            // RezervacijaPregled
            // 
            this.RezervacijaPregled.Name = "RezervacijaPregled";
            this.RezervacijaPregled.Size = new System.Drawing.Size(218, 26);
            this.RezervacijaPregled.Text = "Pregled rezervacija";
            this.RezervacijaPregled.Click += new System.EventHandler(this.RezervacijaPregled_Click);
            // 
            // Termini
            // 
            this.Termini.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PregledTermina,
            this.DodajTermin});
            this.Termini.Name = "Termini";
            this.Termini.Size = new System.Drawing.Size(72, 24);
            this.Termini.Text = "Termini";
            // 
            // PregledTermina
            // 
            this.PregledTermina.Name = "PregledTermina";
            this.PregledTermina.Size = new System.Drawing.Size(198, 26);
            this.PregledTermina.Text = "Pregled termina";
            this.PregledTermina.Click += new System.EventHandler(this.PregledTermina_Click);
            // 
            // DodajTermin
            // 
            this.DodajTermin.Name = "DodajTermin";
            this.DodajTermin.Size = new System.Drawing.Size(198, 26);
            this.DodajTermin.Text = "Dodaj termin";
            this.DodajTermin.Click += new System.EventHandler(this.DodajTermin_Click);
            // 
            // Novosti
            // 
            this.Novosti.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NovostiPregled,
            this.NovostiDodaj});
            this.Novosti.Name = "Novosti";
            this.Novosti.Size = new System.Drawing.Size(74, 24);
            this.Novosti.Text = "Novosti";
            this.Novosti.Visible = false;
            this.Novosti.Click += new System.EventHandler(this.Novosti_Click);
            // 
            // NovostiPregled
            // 
            this.NovostiPregled.Name = "NovostiPregled";
            this.NovostiPregled.Size = new System.Drawing.Size(195, 26);
            this.NovostiPregled.Text = "Pregled novosti";
            this.NovostiPregled.Click += new System.EventHandler(this.NovostiPregled_Click);
            // 
            // NovostiDodaj
            // 
            this.NovostiDodaj.Name = "NovostiDodaj";
            this.NovostiDodaj.Size = new System.Drawing.Size(195, 26);
            this.NovostiDodaj.Text = "Dodaj novost";
            this.NovostiDodaj.Click += new System.EventHandler(this.NovostiDodaj_Click);
            // 
            // Slike
            // 
            this.Slike.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SlikaPregled,
            this.SlikaDodaj});
            this.Slike.Name = "Slike";
            this.Slike.Size = new System.Drawing.Size(54, 24);
            this.Slike.Text = "Slike";
            this.Slike.Visible = false;
            this.Slike.Click += new System.EventHandler(this.Slike_Click);
            // 
            // SlikaPregled
            // 
            this.SlikaPregled.Name = "SlikaPregled";
            this.SlikaPregled.Size = new System.Drawing.Size(176, 26);
            this.SlikaPregled.Text = "Pregled slika";
            this.SlikaPregled.Click += new System.EventHandler(this.SlikaPregled_Click);
            // 
            // SlikaDodaj
            // 
            this.SlikaDodaj.Name = "SlikaDodaj";
            this.SlikaDodaj.Size = new System.Drawing.Size(176, 26);
            this.SlikaDodaj.Text = "Dodaj sliku";
            this.SlikaDodaj.Click += new System.EventHandler(this.SlikaDodaj_Click);
            // 
            // Arhiva
            // 
            this.Arhiva.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ArhivaPregled});
            this.Arhiva.Name = "Arhiva";
            this.Arhiva.Size = new System.Drawing.Size(65, 24);
            this.Arhiva.Text = "Arhiva";
            this.Arhiva.Visible = false;
            this.Arhiva.Click += new System.EventHandler(this.Arhiva_Click);
            // 
            // ArhivaPregled
            // 
            this.ArhivaPregled.Name = "ArhivaPregled";
            this.ArhivaPregled.Size = new System.Drawing.Size(187, 26);
            this.ArhivaPregled.Text = "Pregled arhive";
            this.ArhivaPregled.Click += new System.EventHandler(this.ArhivaPregled_Click);
            // 
            // Narudzba
            // 
            this.Narudzba.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NarudzbaPregled});
            this.Narudzba.Name = "Narudzba";
            this.Narudzba.Size = new System.Drawing.Size(88, 24);
            this.Narudzba.Text = "Narudzba";
            // 
            // NarudzbaPregled
            // 
            this.NarudzbaPregled.Name = "NarudzbaPregled";
            this.NarudzbaPregled.Size = new System.Drawing.Size(224, 26);
            this.NarudzbaPregled.Text = "Pregled narudzbi";
            this.NarudzbaPregled.Click += new System.EventHandler(this.NarudzbaPregled_Click);
            // 
            // mdiMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 697);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "mdiMain";
            this.Text = "mdiMain";
            this.Load += new System.EventHandler(this.mdiMain_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private ToolStripMenuItem Uposlenici;
        private ToolStripMenuItem Proizvodi;
        private ToolStripMenuItem Rezervacije;
        private ToolStripMenuItem Novosti;
        private ToolStripMenuItem Slike;
        private ToolStripMenuItem Arhiva;
        private ToolStripMenuItem UposlenikPregled;
        private ToolStripMenuItem DodajProizvod;
        private ToolStripMenuItem PregledProizvoda;
        private ToolStripMenuItem UposlenikDodaj;
        private ToolStripMenuItem RezervacijaPregled;
        private ToolStripMenuItem NovostiPregled;
        private ToolStripMenuItem NovostiDodaj;
        private ToolStripMenuItem SlikaPregled;
        private ToolStripMenuItem SlikaDodaj;
        private ToolStripMenuItem ArhivaPregled;
        private ToolStripMenuItem Termini;
        private ToolStripMenuItem PregledTermina;
        private ToolStripMenuItem DodajTermin;
        private ToolStripMenuItem Narudzba;
        private ToolStripMenuItem NarudzbaPregled;
    }
}



