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
    public partial class frmSlika : Form
    {

        APIService service = new APIService("Slika");
        APIService serviceUposlenici = new APIService("Korisnik");

        public frmSlika()
        {
            InitializeComponent();
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            SlikaSearchObject search = new SlikaSearchObject();
            if(Convert.ToInt32(cmbKorisnik.SelectedValue) > 0)
                search.KorisnikID = Convert.ToInt32(cmbKorisnik.SelectedValue);
            search.IncludeKorisnik = true;
            await LoadData(search);
        }

        private async void dgvSlika_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = dgvSlika.SelectedRows[0].DataBoundItem as Slika;
            var grid = (DataGridView)sender;

            if (grid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if (MessageBox.Show($"Jeste li sigurni da zelite obrisati ovu sliku?", $"Message for user - {APIService.Username}", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    var result = await service.Delete<Slika>(item.SlikaID);

                    await LoadData();

                    MessageBox.Show("Uspjesno ste obrisali sliku");
                }
            }
            else
            {
                frmSlikaDodaj frmSlikaDodaj = new frmSlikaDodaj(item);
                frmSlikaDodaj.Show();
            }
        }

        private async void frmSlika_Load(object sender, EventArgs e)
        {
            await LoadData();
            await LoadUposlenici();

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Text = "Obrisi";
            btn.DataPropertyName = "Obrisi";
            btn.HeaderText = "Akcija";
            btn.UseColumnTextForButtonValue = true;

            dgvSlika.Columns.Add(btn);
        }

        public async Task LoadUposlenici()
        {
            KorisnikSearchObject search = new KorisnikSearchObject();
            search.IncludeDrzava = true;
            search.IncludeGrad = true;
            search.IncludeUloge = true;

            var list = await serviceUposlenici.GetAll<List<Korisnik>>(search);

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

        public async Task LoadData(SlikaSearchObject search = null)
        {
            if(search != null)
            { 
                var list = await service.GetAll<List<Slika>>(search);

                dgvSlika.DataSource = list;
            }

            else
            {
                search = new SlikaSearchObject();
                search.IncludeKorisnik = true;

                var list = await service.GetAll<List<Slika>>(search);

                dgvSlika.DataSource = list;
            }
        }
    }
}
