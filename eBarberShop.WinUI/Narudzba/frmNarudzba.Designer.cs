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
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.txtNarudzbaSearch = new System.Windows.Forms.TextBox();
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
            this.btnPrikazi.Location = new System.Drawing.Point(694, 49);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(94, 29);
            this.btnPrikazi.TabIndex = 1;
            this.btnPrikazi.Text = "Prikazi";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(418, 50);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(264, 27);
            this.dtpDatum.TabIndex = 2;
            this.dtpDatum.ValueChanged += new System.EventHandler(this.dtpDatum_ValueChanged);
            // 
            // txtNarudzbaSearch
            // 
            this.txtNarudzbaSearch.Location = new System.Drawing.Point(12, 50);
            this.txtNarudzbaSearch.Name = "txtNarudzbaSearch";
            this.txtNarudzbaSearch.Size = new System.Drawing.Size(396, 27);
            this.txtNarudzbaSearch.TabIndex = 3;
            this.txtNarudzbaSearch.TextChanged += new System.EventHandler(this.txtNarudzbaSearch_TextChanged);
            // 
            // frmNarudzba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNarudzbaSearch);
            this.Controls.Add(this.dtpDatum);
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
        private DateTimePicker dtpDatum;
        private TextBox txtNarudzbaSearch;
    }
}