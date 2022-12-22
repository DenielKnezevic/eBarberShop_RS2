namespace eBarberShop.WinUI.Arhiva
{
    partial class frmArhivaNarudzbe
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
            this.txtArhivaSearch = new System.Windows.Forms.TextBox();
            this.dtpDatumDo = new System.Windows.Forms.DateTimePicker();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.dgvArhiva = new System.Windows.Forms.DataGridView();
            this.btnIzvjestaj = new System.Windows.Forms.Button();
            this.dtpDatumOd = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArhiva)).BeginInit();
            this.SuspendLayout();
            // 
            // txtArhivaSearch
            // 
            this.txtArhivaSearch.Location = new System.Drawing.Point(12, 61);
            this.txtArhivaSearch.Name = "txtArhivaSearch";
            this.txtArhivaSearch.Size = new System.Drawing.Size(176, 27);
            this.txtArhivaSearch.TabIndex = 7;
            // 
            // dtpDatumDo
            // 
            this.dtpDatumDo.Location = new System.Drawing.Point(441, 61);
            this.dtpDatumDo.Name = "dtpDatumDo";
            this.dtpDatumDo.Size = new System.Drawing.Size(241, 27);
            this.dtpDatumDo.TabIndex = 6;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(694, 60);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(94, 29);
            this.btnPrikazi.TabIndex = 5;
            this.btnPrikazi.Text = "Prikazi";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // dgvArhiva
            // 
            this.dgvArhiva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArhiva.Location = new System.Drawing.Point(12, 94);
            this.dgvArhiva.Name = "dgvArhiva";
            this.dgvArhiva.RowHeadersWidth = 51;
            this.dgvArhiva.RowTemplate.Height = 29;
            this.dgvArhiva.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArhiva.Size = new System.Drawing.Size(776, 344);
            this.dgvArhiva.TabIndex = 4;
            this.dgvArhiva.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArhiva_CellContentClick);
            // 
            // btnIzvjestaj
            // 
            this.btnIzvjestaj.Location = new System.Drawing.Point(652, 444);
            this.btnIzvjestaj.Name = "btnIzvjestaj";
            this.btnIzvjestaj.Size = new System.Drawing.Size(136, 29);
            this.btnIzvjestaj.TabIndex = 8;
            this.btnIzvjestaj.Text = "Isprintaj izvjestaj";
            this.btnIzvjestaj.UseVisualStyleBackColor = true;
            this.btnIzvjestaj.Click += new System.EventHandler(this.btnIzvjestaj_Click);
            // 
            // dtpDatumOd
            // 
            this.dtpDatumOd.Location = new System.Drawing.Point(194, 61);
            this.dtpDatumOd.Name = "dtpDatumOd";
            this.dtpDatumOd.Size = new System.Drawing.Size(241, 27);
            this.dtpDatumOd.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(441, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Datum do:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Datum od:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Broj narudzbe";
            // 
            // frmArhivaNarudzbe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 490);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDatumOd);
            this.Controls.Add(this.btnIzvjestaj);
            this.Controls.Add(this.txtArhivaSearch);
            this.Controls.Add(this.dtpDatumDo);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.dgvArhiva);
            this.Name = "frmArhivaNarudzbe";
            this.Text = "frmArhivaNarudzbe";
            this.Load += new System.EventHandler(this.frmArhivaNarudzbe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArhiva)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtArhivaSearch;
        private DateTimePicker dtpDatumDo;
        private Button btnPrikazi;
        private DataGridView dgvArhiva;
        private Button btnIzvjestaj;
        private DateTimePicker dtpDatumOd;
        private Label label2;
        private Label label1;
        private Label label3;
    }
}