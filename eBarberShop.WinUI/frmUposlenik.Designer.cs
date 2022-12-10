namespace eBarberShop.WinUI
{
    partial class frmUposlenik
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
            this.dgvUposlenik = new System.Windows.Forms.DataGridView();
            this.btnPrikazi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUposlenik)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUposlenik
            // 
            this.dgvUposlenik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUposlenik.Location = new System.Drawing.Point(12, 97);
            this.dgvUposlenik.Name = "dgvUposlenik";
            this.dgvUposlenik.RowHeadersWidth = 51;
            this.dgvUposlenik.RowTemplate.Height = 29;
            this.dgvUposlenik.Size = new System.Drawing.Size(776, 341);
            this.dgvUposlenik.TabIndex = 0;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(694, 51);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(94, 29);
            this.btnPrikazi.TabIndex = 1;
            this.btnPrikazi.Text = "Prikazi";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // frmUposlenik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.dgvUposlenik);
            this.Name = "frmUposlenik";
            this.Text = "frmUposlenik";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUposlenik)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvUposlenik;
        private Button btnPrikazi;
    }
}