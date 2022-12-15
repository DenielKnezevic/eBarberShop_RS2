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

        private async void frmUposlenik_Load(object sender, EventArgs e)
        {
            await LoadData();

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Text = "Izbrisi uposlenika";
            btn.DataPropertyName = "IzbrisiUposlenika";
            btn.HeaderText = "Akcija";
            btn.UseColumnTextForButtonValue = true;

            dgvUposlenik.Columns.Add(btn);
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

        private async void dgvUposlenik_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var grid = (DataGridView)sender;

            if (grid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                var korisnik = dgvUposlenik.SelectedRows[0].DataBoundItem as Korisnik;

                KorisnikUpdateRequest request = new KorisnikUpdateRequest() { Uloga="uposlenik"};

                if (MessageBox.Show($"Jeste li sigurni da zelite obrisati ovog zaposlenika?", $"Message for user - {APIService.Username}", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    var result = await service.DeleteUloga(korisnik.KorisnikID, request);

                    await LoadData();

                    MessageBox.Show("Uspjesno ste obrisali uposlenika");
                }
            }
        }
    }
}
