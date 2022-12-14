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
            this.btnPrikazi.Location = new System.Drawing.Point(694, 56);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(94, 29);
            this.btnPrikazi.TabIndex = 1;
            this.btnPrikazi.Text = "Prikazi";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // frmArhiva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.dgvArhiva);
            this.Name = "frmArhiva";
            this.Text = "frmArhiva";
            ((System.ComponentModel.ISupportInitialize)(this.dgvArhiva)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvArhiva;
        private Button btnPrikazi;
    }
}