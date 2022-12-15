namespace eBarberShop.WinUI
{
    partial class frmArhiva
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
            this.dgvArhiva = new System.Windows.Forms.DataGridView();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.dtpDatumOd = new System.Windows.Forms.DateTimePicker();
            this.dtpDatumDo = new System.Windows.Forms.DateTimePicker();
            this.cmbUposlenik = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArhiva)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArhiva
            // 
            this.dgvArhiva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArhiva.Location = new System.Drawing.Point(12, 102);
            this.dgvArhiva.Name = "dgvArhiva";
            this.dgvArhiva.RowHeadersWidth = 51;
            this.dgvArhiva.RowTemplate.Height = 29;
            this.dgvArhiva.Size = new System.Drawing.Size(776, 336);
            this.dgvArhiva.TabIndex = 0;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(694, 67);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(94, 29);
            this.btnPrikazi.TabIndex = 1;
            this.btnPrikazi.Text = "Prikazi";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // dtpDatumOd
            // 
            this.dtpDatumOd.Location = new System.Drawing.Point(12, 69);
            this.dtpDatumOd.Name = "dtpDatumOd";
            this.dtpDatumOd.Size = new System.Drawing.Size(250, 27);
            this.dtpDatumOd.TabIndex = 2;
            // 
            // dtpDatumDo
            // 
            this.dtpDatumDo.Location = new System.Drawing.Point(268, 69);
            this.dtpDatumDo.Name = "dtpDatumDo";
            this.dtpDatumDo.Size = new System.Drawing.Size(250, 27);
            this.dtpDatumDo.TabIndex = 3;
            // 
            // cmbUposlenik
            // 
            this.cmbUposlenik.FormattingEnabled = true;
            this.cmbUposlenik.Location = new System.Drawing.Point(524, 68);
            this.cmbUposlenik.Name = "cmbUposlenik";
            this.cmbUposlenik.Size = new System.Drawing.Size(164, 28);
            this.cmbUposlenik.TabIndex = 4;
            // 
            // frmArhiva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbUposlenik);
            this.Controls.Add(this.dtpDatumDo);
            this.Controls.Add(this.dtpDatumOd);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.dgvArhiva);
            this.Name = "frmArhiva";
            this.Text = "frmArhiva";
            this.Load += new System.EventHandler(this.frmArhiva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArhiva)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvArhiva;
        private Button btnPrikazi;
        private DateTimePicker dtpDatumOd;
        private DateTimePicker dtpDatumDo;
        private ComboBox cmbUposlenik;
    }
}