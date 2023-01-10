namespace eBarberShop.WinUI.Arhiva
{
    partial class frmArhivaNarudzbaReport
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
            this.rptArhiva = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rptArhiva
            // 
            this.rptArhiva.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptArhiva.Location = new System.Drawing.Point(0, 0);
            this.rptArhiva.Name = "ReportViewer";
            this.rptArhiva.ServerReport.BearerToken = null;
            this.rptArhiva.Size = new System.Drawing.Size(1495, 745);
            this.rptArhiva.TabIndex = 0;
            // 
            // frmArhivaNarudzbaReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1495, 745);
            this.Controls.Add(this.rptArhiva);
            this.Name = "frmArhivaNarudzbaReport";
            this.Text = "frmArhivaNarudzbaReport";
            this.Load += new System.EventHandler(this.frmArhivaNarudzbaReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptArhiva;
    }
}