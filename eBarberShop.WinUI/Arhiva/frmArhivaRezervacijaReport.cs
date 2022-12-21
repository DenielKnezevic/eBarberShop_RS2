using eBarberShop.Models;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBarberShop.WinUI.Arhiva
{
    public partial class frmArhivaRezervacijaReport : Form
    {
        private List<Rezervacija> list;

        public frmArhivaRezervacijaReport(List<Rezervacija> list)
        {
            this.list = list;
            InitializeComponent();
        }

        private void frmArhivaRezervacijaReport_Load(object sender, EventArgs e)
        {
            
            var tbl = new dsRezervacija.DataTable1DataTable();
            for (int i = 0; i < list.Count(); i++)
            {
                var red = tbl.NewDataTable1Row();
                red.Rb = $"{i+1}";
                red.DatumTermina = list[i].Termin.DatumTermina.Date.ToString("dd.MM.yyy");
                red.DatumRezervacije = list[i].DatumRezervacije.Date.ToString("dd.MM.yyy");
                red.KorisnikIme = $"{list[i].Korisnik.Ime} {list[i].Korisnik.Prezime}";
                red.UposlenikIme = $"{list[i].Termin.Korisnik.Ime} {list[i].Termin.Korisnik.Prezime}";
                tbl.AddDataTable1Row(red);
            }

            ReportDataSource dataSource = new ReportDataSource();
            dataSource.Name = "dsRezervacijaReport";
            dataSource.Value = tbl;
            
            this.rptRezervacija.LocalReport.DataSources.Add(dataSource);
            rptRezervacija.LocalReport.ReportEmbeddedResource = "eBarberShop.WinUI.Arhiva.RezervacijaReport.rdlc";
            rptRezervacija.RefreshReport();
        }

        private void rptRezervacija_Load(object sender, EventArgs e)
        {
            
        }
    }
}
