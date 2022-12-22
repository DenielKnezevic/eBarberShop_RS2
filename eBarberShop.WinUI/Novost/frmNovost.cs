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

namespace eBarberShop.WinUI
{
    public partial class frmNovost : Form
    {

        APIService service = new APIService("Novost");
        APIService serviceUposlenici = new APIService("Korisnik");

        public frmNovost()
        {
            InitializeComponent();
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            NovostSearchObject search = new NovostSearchObject();
            search.DatumOd = dtpDatumOd.Value.Date;
            search.DatumDo = dtpDatumDo.Value.Date;
            if(Convert.ToInt32(cmbKorisnik.SelectedValue) > 0)
                search.KorisnikID = Convert.ToInt32(cmbKorisnik.SelectedValue);
            await LoadData(search);
        }

        private void dgvNovost_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = dgvNovost.SelectedRows[0].DataBoundItem as Novost;
            frmNovostiDodaj frmNovostiDodaj = new frmNovostiDodaj(item);
            frmNovostiDodaj.Show();
        }

        public async Task LoadData(NovostSearchObject search = null)
        {
            if(search != null)
            { 
                var lista = await service.GetAll<List<Novost>>(search);

                dgvNovost.DataSource = lista;
            }

            else
            {
                var lista = await service.GetAll<List<Novost>>();

                dgvNovost.DataSource = lista;
            }
        }

        public async Task LoadUposlenici()
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

            cmbKorisnik.DataSource = konacnaLista;
            cmbKorisnik.DisplayMember = "Ime";
            cmbKorisnik.ValueMember = "KorisnikID";
            cmbKorisnik.SelectedItem = null;
            cmbKorisnik.SelectedText = "Izaberite uposlenika";
        }

        private async void frmNovost_Load(object sender, EventArgs e)
        {
            await LoadData();
            await LoadUposlenici();
        }
    }
}
