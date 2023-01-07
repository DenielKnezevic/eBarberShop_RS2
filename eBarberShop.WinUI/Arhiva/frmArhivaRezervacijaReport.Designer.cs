namespace eBarberShop.WinUI.Arhiva
{
    partial class frmArhivaRezervacijaReport
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
            this.rptRezervacija = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rptRezervacija
            // 
            this.rptRezervacija.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptRezervacija.Location = new System.Drawing.Point(0, 0);
            this.rptRezervacija.Name = "ReportViewer";
            this.rptRezervacija.ServerReport.BearerToken = null;
            this.rptRezervacija.Size = new System.Drawing.Size(1068, 768);
            this.rptRezervacija.TabIndex = 0;
            this.rptRezervacija.Load += new System.EventHandler(this.rptRezervacija_Load);
            // 
            // frmArhivaRezervacijaReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 768);
            this.Controls.Add(this.rptRezervacija);
            this.Name = "frmArhivaRezervacijaReport";
            this.Text = "frmArhivaRezervacijaReport";
            this.Load += new System.EventHandler(this.frmArhivaRezervacijaReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptRezervacija;
    }
}