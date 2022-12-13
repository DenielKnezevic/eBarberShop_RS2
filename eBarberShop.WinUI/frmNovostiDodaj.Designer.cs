namespace eBarberShop.WinUI
{
    partial class frmNovostiDodaj
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnDodajNovost = new System.Windows.Forms.Button();
            this.btnDodajSliku = new System.Windows.Forms.Button();
            this.pbSlika = new System.Windows.Forms.PictureBox();
            this.rtbSadrzaj = new System.Windows.Forms.RichTextBox();
            this.txtNaslov = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnDodajNovost);
            this.groupBox1.Controls.Add(this.btnDodajSliku);
            this.groupBox1.Controls.Add(this.pbSlika);
            this.groupBox1.Controls.Add(this.rtbSadrzaj);
            this.groupBox1.Controls.Add(this.txtNaslov);
            this.groupBox1.Location = new System.Drawing.Point(142, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(520, 408);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Novost";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naslov";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sadrzaj";
            // 
            // btnDodajNovost
            // 
            this.btnDodajNovost.Location = new System.Drawing.Point(182, 350);
            this.btnDodajNovost.Name = "btnDodajNovost";
            this.btnDodajNovost.Size = new System.Drawing.Size(118, 29);
            this.btnDodajNovost.TabIndex = 1;
            this.btnDodajNovost.Text = "Dodaj novost";
            this.btnDodajNovost.UseVisualStyleBackColor = true;
            this.btnDodajNovost.Click += new System.EventHandler(this.btnDodajNovost_Click);
            // 
            // btnDodajSliku
            // 
            this.btnDodajSliku.Location = new System.Drawing.Point(38, 275);
            this.btnDodajSliku.Name = "btnDodajSliku";
            this.btnDodajSliku.Size = new System.Drawing.Size(171, 29);
            this.btnDodajSliku.TabIndex = 3;
            this.btnDodajSliku.Text = "Dodaj sliku";
            this.btnDodajSliku.UseVisualStyleBackColor = true;
            this.btnDodajSliku.Click += new System.EventHandler(this.btnDodajSliku_Click);
            // 
            // pbSlika
            // 
            this.pbSlika.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSlika.Location = new System.Drawing.Point(262, 73);
            this.pbSlika.Name = "pbSlika";
            this.pbSlika.Size = new System.Drawing.Size(225, 231);
            this.pbSlika.TabIndex = 2;
            this.pbSlika.TabStop = false;
            this.pbSlika.Click += new System.EventHandler(this.pbSlika_Click);
            // 
            // rtbSadrzaj
            // 
            this.rtbSadrzaj.Location = new System.Drawing.Point(38, 129);
            this.rtbSadrzaj.Name = "rtbSadrzaj";
            this.rtbSadrzaj.Size = new System.Drawing.Size(171, 120);
            this.rtbSadrzaj.TabIndex = 1;
            this.rtbSadrzaj.Text = "";
            // 
            // txtNaslov
            // 
            this.txtNaslov.Location = new System.Drawing.Point(38, 73);
            this.txtNaslov.Name = "txtNaslov";
            this.txtNaslov.Size = new System.Drawing.Size(171, 27);
            this.txtNaslov.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog";
            // 
            // frmNovostiDodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmNovostiDodaj";
            this.Text = "frmNovostiDodaj";
            this.Load += new System.EventHandler(this.frmNovostiDodaj_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtNaslov;
        private RichTextBox rtbSadrzaj;
        private PictureBox pbSlika;
        private OpenFileDialog openFileDialog1;
        private Label label1;
        private Label label3;
        private Button btnDodajNovost;
        private Button btnDodajSliku;
    }
}