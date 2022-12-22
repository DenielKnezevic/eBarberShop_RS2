namespace eBarberShop.WinUI
{
    partial class frmTermin
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
            this.dgvTermini = new System.Windows.Forms.DataGridView();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.dtpDatumOd = new System.Windows.Forms.DateTimePicker();
            this.cmbUposlenici = new System.Windows.Forms.ComboBox();
            this.dtpDatumDo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTermini)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTermini
            // 
            this.dgvTermini.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTermini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTermini.Location = new System.Drawing.Point(12, 88);
            this.dgvTermini.Name = "dgvTermini";
            this.dgvTermini.RowHeadersWidth = 51;
            this.dgvTermini.RowTemplate.Height = 29;
            this.dgvTermini.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTermini.Size = new System.Drawing.Size(776, 350);
            this.dgvTermini.TabIndex = 0;
            this.dgvTermini.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTermini_CellContentClick);
            // 
            // btnPretraga
            // 
            this.btnPretraga.Location = new System.Drawing.Point(694, 53);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(94, 29);
            this.btnPretraga.TabIndex = 1;
            this.btnPretraga.Text = "Pretraga";
            this.btnPretraga.UseVisualStyleBackColor = true;
            this.btnPretraga.Click += new System.EventHandler(this.btnPretraga_Click);
            // 
            // dtpDatumOd
            // 
            this.dtpDatumOd.Location = new System.Drawing.Point(12, 54);
            this.dtpDatumOd.Name = "dtpDatumOd";
            this.dtpDatumOd.Size = new System.Drawing.Size(250, 27);
            this.dtpDatumOd.TabIndex = 2;
            // 
            // cmbUposlenici
            // 
            this.cmbUposlenici.FormattingEnabled = true;
            this.cmbUposlenici.Location = new System.Drawing.Point(524, 54);
            this.cmbUposlenici.Name = "cmbUposlenici";
            this.cmbUposlenici.Size = new System.Drawing.Size(164, 28);
            this.cmbUposlenici.TabIndex = 3;
            // 
            // dtpDatumDo
            // 
            this.dtpDatumDo.Location = new System.Drawing.Point(268, 54);
            this.dtpDatumDo.Name = "dtpDatumDo";
            this.dtpDatumDo.Size = new System.Drawing.Size(250, 27);
            this.dtpDatumDo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Datum od:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Datum do:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(524, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Uposlenik;";
            // 
            // frmTermin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDatumDo);
            this.Controls.Add(this.cmbUposlenici);
            this.Controls.Add(this.dtpDatumOd);
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.dgvTermini);
            this.Name = "frmTermin";
            this.Text = "frmTermin";
            this.Load += new System.EventHandler(this.frmTermin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTermini)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvTermini;
        private Button btnPretraga;
        private DateTimePicker dtpDatumOd;
        private ComboBox cmbUposlenici;
        private DateTimePicker dtpDatumDo;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}