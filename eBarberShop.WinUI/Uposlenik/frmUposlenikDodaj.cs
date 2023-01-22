using eBarberShop.Models;
using eBarberShop.Models.Requests;
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
            search.IncludeDrzava = true;
            search.IncludeGrad = true;
            search.IncludeUloge = true;

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

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Text = "Dodaj uposlenika";
            btn.DataPropertyName = "DodajUposlenika";
            btn.HeaderText = "Akcija";
            btn.UseColumnTextForButtonValue = true;

            dgvKorisnici.Columns.Add(btn);
            dgvKorisnici.Columns["KorisnikID"].Visible = false;

        }

        private async void dgvKorisnici_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var grid = (DataGridView)sender;

            if (grid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                var korisnik = dgvKorisnici.SelectedRows[0].DataBoundItem as Korisnik;

                KorisnikUpdateRequest request = new KorisnikUpdateRequest() { Uloga = "uposlenik", DrzavaID = korisnik.DrzavaID, GradID = korisnik.GradID, Email = korisnik.Email, Ime = korisnik.Ime, Prezime = korisnik.Prezime };

                var result = await service.AddUloga(korisnik.KorisnikID,request);

                await LoadData();

                MessageBox.Show("Uspjesno ste dodali uposlenika");
            }
                
        }

        private async void btnPretraga_Click(object sender, EventArgs e)
        {
            await LoadData();
        }
    }
}
