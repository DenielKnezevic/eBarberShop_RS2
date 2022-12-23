namespace eBarberShop.WinUI
{
    partial class frmNarudzba
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
            this.dgvNarudzba = new System.Windows.Forms.DataGridView();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.dtpDatumDo = new System.Windows.Forms.DateTimePicker();
            this.txtNarudzbaSearch = new System.Windows.Forms.TextBox();
            this.dtpDatumOd = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarudzba)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNarudzba
            // 
            this.dgvNarudzba.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNarudzba.Location = new System.Drawing.Point(12, 94);
            this.dgvNarudzba.Name = "dgvNarudzba";
            this.dgvNarudzba.RowHeadersWidth = 51;
            this.dgvNarudzba.RowTemplate.Height = 29;
            this.dgvNarudzba.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNarudzba.Size = new System.Drawing.Size(776, 344);
            this.dgvNarudzba.TabIndex = 0;
            this.dgvNarudzba.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNarudzba_CellContentClick);
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(694, 60);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(94, 29);
            this.btnPrikazi.TabIndex = 1;
            this.btnPrikazi.Text = "Prikazi";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // dtpDatumDo
            // 
            this.dtpDatumDo.Location = new System.Drawing.Point(439, 61);
            this.dtpDatumDo.Name = "dtpDatumDo";
            this.dtpDatumDo.Size = new System.Drawing.Size(243, 27);
            this.dtpDatumDo.TabIndex = 2;
            this.dtpDatumDo.ValueChanged += new System.EventHandler(this.dtpDatum_ValueChanged);
            // 
            // txtNarudzbaSearch
            // 
            this.txtNarudzbaSearch.Location = new System.Drawing.Point(12, 61);
            this.txtNarudzbaSearch.Name = "txtNarudzbaSearch";
            this.txtNarudzbaSearch.Size = new System.Drawing.Size(172, 27);
            this.txtNarudzbaSearch.TabIndex = 3;
            this.txtNarudzbaSearch.TextChanged += new System.EventHandler(this.txtNarudzbaSearch_TextChanged);
            // 
            // dtpDatumOd
            // 
            this.dtpDatumOd.Location = new System.Drawing.Point(190, 61);
            this.dtpDatumOd.Name = "dtpDatumOd";
            this.dtpDatumOd.Size = new System.Drawing.Size(243, 27);
            this.dtpDatumOd.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Broj narudzbe:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(439, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Datum do:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Datum od:";
            // 
            // frmNarudzba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDatumOd);
            this.Controls.Add(this.txtNarudzbaSearch);
            this.Controls.Add(this.dtpDatumDo);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.dgvNarudzba);
            this.Name = "frmNarudzba";
            this.Text = "frmNarudzba";
            this.Load += new System.EventHandler(this.frmNarudzba_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarudzba)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvNarudzba;
        private Button btnPrikazi;
        private DateTimePicker dtpDatumDo;
        private TextBox txtNarudzbaSearch;
        private DateTimePicker dtpDatumOd;
        private Label label2;
        private Label label1;
        private Label label3;
    }
}