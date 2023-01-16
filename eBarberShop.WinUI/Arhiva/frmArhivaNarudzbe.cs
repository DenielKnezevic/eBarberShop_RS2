using eBarberShop.Models;
using eBarberShop.Models.SearchObjects;
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
    public partial class frmArhivaNarudzbe : Form
    {

        public APIService service = new APIService("Narudzba");

        public frmArhivaNarudzbe()
        {
            InitializeComponent();
        }

        public async Task LoadData(NarudzbaSearchObject search = null)
        {
            if (search == null)
            {
                search = new NarudzbaSearchObject();
                search.IsShipped = true;
                search.IsCanceled = false;
                search.IncludeUplata = true;
                search.IncludeKorisnik = true;
                search.IncludeNarudzbaProizvodi = true;
                var list = await service.GetAll<List<Narudzba>>(search);

                dgvArhiva.DataSource = list;

            }
            else
            {
                var list = await service.GetAll<List<Narudzba>>(search);

                dgvArhiva.DataSource = list;
            }
        }

        private async void frmArhivaNarudzbe_Load(object sender, EventArgs e)
        {
            await LoadData();
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            NarudzbaSearchObject search = new NarudzbaSearchObject();

            search.DatumDo = dtpDatumDo.Value.Date;
            search.DatumOd = dtpDatumOd.Value.Date;
            search.BrojNarudzbe = txtArhivaSearch.Text;
            search.IsShipped = true;
            search.IsCanceled = false;
            search.IncludeUplata = true;
            search.IncludeKorisnik = true;
            search.IncludeNarudzbaProizvodi = true;

            await LoadData(search);
        }

        private void btnIzvjestaj_Click(object sender, EventArgs e)
        {
            var list = dgvArhiva.DataSource as List<Narudzba>;

            if (list.Count > 0)
            {
                var frmReport = new frmArhivaNarudzbaReport(list);
                frmReport.Show();
            }

            else
            {
                MessageBox.Show("Nema podataka za izvjestaj");
            }
        }
    }
}
