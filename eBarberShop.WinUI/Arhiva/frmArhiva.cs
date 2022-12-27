using eBarberShop.Models;
using eBarberShop.Models.SearchObjects;
using eBarberShop.WinUI.Arhiva;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBarberShop.WinUI
{
    public partial class frmArhiva : Form
    {

        APIService service = new APIService("Rezervacija");
        APIService serviceUposlenici = new APIService("Korisnik");

        public frmArhiva()
        {
            InitializeComponent();
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            RezervacijaSearchObject search = new RezervacijaSearchObject();

            search.IsArchived = true;
            search.DatumOd = dtpDatumOd.Value.Date;
            search.DatumDo = dtpDatumDo.Value.Date;
            search.IsCanceled = false;

            if (Convert.ToInt32(cmbUposlenik.SelectedValue) > 0)
            {
                search.KorisnikID = Convert.ToInt32(cmbUposlenik.SelectedValue);
            }

            await LoadData(search);
        }

        private async void frmArhiva_Load(object sender, EventArgs e)
        {
            await LoadData();
            await LoadUposlenike();
        }

        public async Task LoadData(RezervacijaSearchObject search = null)
        { 
            if(search == null)
            { 
                search = new RezervacijaSearchObject();
                search.IsArchived=true;
                search.IsCanceled = false;

                var list = await service.GetAll<List<Rezervacija>>(search);
                dgvArhiva.DataSource = list;
            }
            else
            {
                var list = await service.GetAll<List<Rezervacija>>(search);
                dgvArhiva.DataSource = list;
            }
        }

        public async Task LoadUposlenike()
        {
            var list = await serviceUposlenici.GetAll<List<Korisnik>>();

            List<Korisnik> konacnaLista = new List<Korisnik>();

            foreach (var item in list)
            {
                foreach (var item2 in item.KorisnikUlogas)
                {
                    if (item2.Uloga.Naziv.ToLower() == "uposlenik")
                        konacnaLista.Add(item);
                }
            }

            cmbUposlenik.DataSource = konacnaLista;
            cmbUposlenik.DisplayMember = "Ime";
            cmbUposlenik.ValueMember = "KorisnikID";
            cmbUposlenik.SelectedItem = null;
            cmbUposlenik.SelectedText = "Izaberite uposlenika";
        }

        private void btnIzvjestaj_Click(object sender, EventArgs e)
        {
            var list = dgvArhiva.DataSource as List<Rezervacija>;

            if(list.Count > 0)
            {
                var frmReport = new frmArhivaRezervacijaReport(list);
                frmReport.Show();
            }

            else
            {
                MessageBox.Show("Nema podataka za izvjestaj");
            }
        }

        private void cmbUposlenik_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
