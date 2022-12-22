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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvod)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProizvod
            // 
            this.dgvProizvod.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProizvod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProizvod.Location = new System.Drawing.Point(15, 88);
            this.dgvProizvod.Name = "dgvProizvod";
            this.dgvProizvod.RowHeadersWidth = 51;
            this.dgvProizvod.RowTemplate.Height = 29;
            this.dgvProizvod.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProizvod.Size = new System.Drawing.Size(773, 350);
            this.dgvProizvod.TabIndex = 0;
            this.dgvProizvod.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProizvod_CellContentClick);
            // 
            // txtProizvodiSearch
            // 
            this.txtProizvodiSearch.Location = new System.Drawing.Point(15, 55);
            this.txtProizvodiSearch.Name = "txtProizvodiSearch";
            this.txtProizvodiSearch.Size = new System.Drawing.Size(382, 27);
            this.txtProizvodiSearch.TabIndex = 1;
            // 
            // cmbVrstaProizvod
            // 
            this.cmbVrstaProizvod.FormattingEnabled = true;
            this.cmbVrstaProizvod.Location = new System.Drawing.Point(421, 54);
            this.cmbVrstaProizvod.Name = "cmbVrstaProizvod";
            this.cmbVrstaProizvod.Size = new System.Drawing.Size(251, 28);
            this.cmbVrstaProizvod.TabIndex = 2;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(694, 53);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(94, 29);
            this.btnPrikazi.TabIndex = 3;
            this.btnPrikazi.Text = "Prikazi";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Naziv proizvoda:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(421, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Vrsta proizvoda:";
            // 
            // frmProizvod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
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
        private Label label2;
        private Label label1;
    }
}