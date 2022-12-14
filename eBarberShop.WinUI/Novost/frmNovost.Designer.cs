namespace eBarberShop.WinUI
{
    partial class frmNovost
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
            this.dgvNovost = new System.Windows.Forms.DataGridView();
            this.btnPrikazi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNovost)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNovost
            // 
            this.dgvNovost.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNovost.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNovost.Location = new System.Drawing.Point(12, 112);
            this.dgvNovost.Name = "dgvNovost";
            this.dgvNovost.RowHeadersWidth = 51;
            this.dgvNovost.RowTemplate.Height = 29;
            this.dgvNovost.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNovost.Size = new System.Drawing.Size(776, 326);
            this.dgvNovost.TabIndex = 0;
            this.dgvNovost.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNovost_CellContentClick);
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(694, 64);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(94, 29);
            this.btnPrikazi.TabIndex = 1;
            this.btnPrikazi.Text = "Prikazi";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // frmNovost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.dgvNovost);
            this.Name = "frmNovost";
            this.Text = "frmNovost";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNovost)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvNovost;
        private Button btnPrikazi;
    }
}