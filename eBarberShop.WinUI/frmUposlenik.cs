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
    public partial class frmUposlenik : Form
    {
        APIService service = new APIService("Korisnik");

        public frmUposlenik()
        {
            InitializeComponent();
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            await LoadData();
        }

        private void frmUposlenik_Load(object sender, EventArgs e)
        {

        }

        public async Task LoadData()
        {
            KorisnikSearchObject search = new KorisnikSearchObject();
            search.Prezime = txtPrezime.Text;
            search.Ime = txtIme.Text;

            var list = await service.GetAll<List<Korisnik>>(search);

            List<Korisnik> konacnaLista = new List<Korisnik>();

            foreach (var item in list)
            {
                foreach (var item2 in item.KorisnikUlogas)
                {
                    if (item2.Uloga.Naziv.ToLower() == "uposlenik")
                        konacnaLista.Add(item);
                }
            }

            dgvUposlenik.DataSource = konacnaLista;
        }
    }
}
