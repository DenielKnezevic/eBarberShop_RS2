namespace eBarberShop.WinUI
{
    partial class frmProizvod
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
            this.dgvProizvod = new System.Windows.Forms.DataGridView();
            this.txtProizvodiSearch = new System.Windows.Forms.TextBox();
            this.cmbVrstaProizvod = new System.Windows.Forms.ComboBox();
            this.btnPrikazi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvod)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProizvod
            // 
            this.dgvProizvod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProizvod.Location = new System.Drawing.Point(15, 88);
            this.dgvProizvod.Name = "dgvProizvod";
            this.dgvProizvod.RowHeadersWidth = 51;
            this.dgvProizvod.RowTemplate.Height = 29;
            this.dgvProizvod.Size = new System.Drawing.Size(773, 350);
            this.dgvProizvod.TabIndex = 0;
            // 
            // txtProizvodiSearch
            // 
            this.txtProizvodiSearch.Location = new System.Drawing.Point(15, 42);
            this.txtProizvodiSearch.Name = "txtProizvodiSearch";
            this.txtProizvodiSearch.Size = new System.Drawing.Size(382, 27);
            this.txtProizvodiSearch.TabIndex = 1;
            // 
            // cmbVrstaProizvod
            // 
            this.cmbVrstaProizvod.FormattingEnabled = true;
            this.cmbVrstaProizvod.Location = new System.Drawing.Point(421, 41);
            this.cmbVrstaProizvod.Name = "cmbVrstaProizvod";
            this.cmbVrstaProizvod.Size = new System.Drawing.Size(251, 28);
            this.cmbVrstaProizvod.TabIndex = 2;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(694, 40);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(94, 29);
            this.btnPrikazi.TabIndex = 3;
            this.btnPrikazi.Text = "Prikazi";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // frmProizvod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.cmbVrstaProizvod);
            this.Controls.Add(this.txtProizvodiSearch);
            this.Controls.Add(this.dgvProizvod);
            this.Name = "frmProizvod";
            this.Text = "frmProizvod";
            this.Load += new System.EventHandler(this.frmProizvod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvProizvod;
        private TextBox txtProizvodiSearch;
        private ComboBox cmbVrstaProizvod;
        private Button btnPrikazi;
    }
}