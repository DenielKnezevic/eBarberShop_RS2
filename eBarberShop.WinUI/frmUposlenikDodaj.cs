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
    public partial class frmUposlenikDodaj : Form
    {

        APIService service = new APIService("Korisnik");

        public frmUposlenikDodaj()
        {
            InitializeComponent();
        }

        public async Task LoadData()
        {
            KorisnikSearchObject search = new KorisnikSearchObject();
            search.Ime = txtIme.Text;
            search.Prezime = txtPrezime.Text;

            var items = await service.GetAll<List<Korisnik>>(search);
            List<Korisnik> konacnaLista = new List<Korisnik>();

            foreach (var item in items)
            {
                if (item.KorisnikUlogas.Count == 0)
                    konacnaLista.Add(item);
            }
            dgvKorisnici.DataSource = konacnaLista;
        }

        private async void frmUposlenikDodaj_Load(object sender, EventArgs e)
        {
            await LoadData();

        }

        private async void dgvKorisnici_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var korisnik = dgvKorisnici.SelectedRows[0].DataBoundItem as Korisnik;

            var result = await service.AddUloga(korisnik.KorisnikID);

            await LoadData();

            MessageBox.Show("Uspjesno ste dodali zaposlenika");
        }

        private async void btnPretraga_Click(object sender, EventArgs e)
        {
            await LoadData();
        }
    }
}
