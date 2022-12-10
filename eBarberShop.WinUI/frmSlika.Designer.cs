namespace eBarberShop.WinUI
{
    partial class frmSlika
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
            this.dgvSlika = new System.Windows.Forms.DataGridView();
            this.btnPrikazi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSlika)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSlika
            // 
            this.dgvSlika.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSlika.Location = new System.Drawing.Point(12, 94);
            this.dgvSlika.Name = "dgvSlika";
            this.dgvSlika.RowHeadersWidth = 51;
            this.dgvSlika.RowTemplate.Height = 29;
            this.dgvSlika.Size = new System.Drawing.Size(776, 344);
            this.dgvSlika.TabIndex = 0;
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
            // frmSlika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.dgvSlika);
            this.Name = "frmSlika";
            this.Text = "frmSlika";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSlika)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvSlika;
        private Button btnPrikazi;
    }
}