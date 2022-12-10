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
            this.Proizvodi = new System.Windows.Forms.ToolStripMenuItem();
            this.Rezervacije = new System.Windows.Forms.ToolStripMenuItem();
            this.Novosti = new System.Windows.Forms.ToolStripMenuItem();
            this.Slike = new System.Windows.Forms.ToolStripMenuItem();
            this.Arhiva = new System.Windows.Forms.ToolStripMenuItem();
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
            this.Uposlenici.Name = "Uposlenici";
            this.Uposlenici.Size = new System.Drawing.Size(92, 24);
            this.Uposlenici.Text = "Uposlenici";
            this.Uposlenici.Click += new System.EventHandler(this.Uposlenici_Click_1);
            // 
            // Proizvodi
            // 
            this.Proizvodi.Name = "Proizvodi";
            this.Proizvodi.Size = new System.Drawing.Size(85, 24);
            this.Proizvodi.Text = "Proizvodi";
            this.Proizvodi.Click += new System.EventHandler(this.Proizvodi_Click);
            // 
            // Rezervacije
            // 
            this.Rezervacije.Name = "Rezervacije";
            this.Rezervacije.Size = new System.Drawing.Size(98, 24);
            this.Rezervacije.Text = "Rezervacije";
            this.Rezervacije.Click += new System.EventHandler(this.Rezervacije_Click);
            // 
            // Novosti
            // 
            this.Novosti.Name = "Novosti";
            this.Novosti.Size = new System.Drawing.Size(74, 24);
            this.Novosti.Text = "Novosti";
            this.Novosti.Click += new System.EventHandler(this.Novosti_Click);
            // 
            // Slike
            // 
            this.Slike.Name = "Slike";
            this.Slike.Size = new System.Drawing.Size(54, 24);
            this.Slike.Text = "Slike";
            this.Slike.Click += new System.EventHandler(this.Slike_Click);
            // 
            // Arhiva
            // 
            this.Arhiva.Name = "Arhiva";
            this.Arhiva.Size = new System.Drawing.Size(65, 24);
            this.Arhiva.Text = "Arhiva";
            this.Arhiva.Click += new System.EventHandler(this.Arhiva_Click);
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
    }
}



