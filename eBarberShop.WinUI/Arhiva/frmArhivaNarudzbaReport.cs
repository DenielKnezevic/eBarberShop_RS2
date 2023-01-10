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
    public partial class frmArhivaNarudzbaReport : Form
    {

        private List<Narudzba> list;

        public frmArhivaNarudzbaReport(List<Narudzba> list)
        {
            this.list = list;
            InitializeComponent();
        }

        private void frmArhivaNarudzbaReport_Load(object sender, EventArgs e)
        {
            var tbl = new dsNarudzbe.NarudzbeDataTable();
            for (int i = 0; i < list.Count(); i++)
            {
                var red = tbl.NewNarudzbeRow();
                red.Rb = $"{i + 1}";
                red.Kupac = $"{list[i].Korisnik.Ime} {list[i].Korisnik.Prezime}";
                red.DatumNarudzbe = list[i].DatumNarudzbe.Date.ToString("dd.MM.yyy");
                red.Proizvodi = $"{list[i].NarudzbaProizvodi}";
                red.UkupnaCijena = $"{list[i].UkupnaCijena.ToString()}";
                red.BrojNarudzbe = $"{list[i].BrojNarudzbe}";
                red.Uplata = $"{list[i].Uplata.BrojTransakcije}";
                tbl.AddNarudzbeRow(red);
            }

            ReportDataSource dataSource = new ReportDataSource();
            dataSource.Name = "dsNarudzba";
            dataSource.Value = tbl;

            this.rptArhiva.LocalReport.DataSources.Add(dataSource);
            rptArhiva.LocalReport.ReportEmbeddedResource = "eBarberShop.WinUI.Arhiva.NarudzbeReport.rdlc";
            rptArhiva.RefreshReport();
        }
    }
}
