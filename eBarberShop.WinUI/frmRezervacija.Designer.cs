namespace eBarberShop.WinUI
{
    partial class frmRezervacija
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
            this.dgvRezervacija = new System.Windows.Forms.DataGridView();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervacija)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRezervacija
            // 
            this.dgvRezervacija.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRezervacija.Location = new System.Drawing.Point(12, 97);
            this.dgvRezervacija.Name = "dgvRezervacija";
            this.dgvRezervacija.RowHeadersWidth = 51;
            this.dgvRezervacija.RowTemplate.Height = 29;
            this.dgvRezervacija.Size = new System.Drawing.Size(776, 341);
            this.dgvRezervacija.TabIndex = 0;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(694, 53);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(94, 29);
            this.btnPrikazi.TabIndex = 1;
            this.btnPrikazi.Text = "Prikazi";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(399, 53);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(280, 27);
            this.dtpDatum.TabIndex = 2;
            // 
            // frmRezervacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.dgvRezervacija);
            this.Name = "frmRezervacija";
            this.Text = "frmRezervacija";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervacija)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvRezervacija;
        private Button btnPrikazi;
        private DateTimePicker dtpDatum;
    }
}