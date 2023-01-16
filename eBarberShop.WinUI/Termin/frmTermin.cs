using eBarberShop.Models;
using eBarberShop.Models.SearchObjects;
using eBarberShop.WinUI.Termin;
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
    public partial class frmTermin : Form
    {

        APIService service = new APIService("Termin");
        APIService serviceUposlenici = new APIService("Korisnik");

        public frmTermin()
        {
            InitializeComponent();
        }

        private async void frmTermin_Load(object sender, EventArgs e)
        {
            await LoadData();
            await LoadUposlenici();
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Text = "Obrisi";
            btn.DataPropertyName = "Obrisi";
            btn.HeaderText = "Akcija";
            btn.UseColumnTextForButtonValue = true;

            dgvTermini.Columns.Add(btn);
        }

        public async Task LoadData(TerminSearchObject search = null)
        {
            if(search == null)
                search = new TerminSearchObject();
            search.IsBooked = false;
            search.IncludeKorisnik = true;
            dgvTermini.DataSource = await service.GetAll<List<Models.Termin>>(search);
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

            cmbUposlenici.DataSource = konacnaLista;
            cmbUposlenici.DisplayMember = "Ime";
            cmbUposlenici.ValueMember = "KorisnikID";
            cmbUposlenici.SelectedItem = null;
            cmbUposlenici.SelectedText = "Izaberite uposlenika";
        }

        private async void btnPretraga_Click(object sender, EventArgs e)
        {
            TerminSearchObject search = new TerminSearchObject();

            if (Convert.ToInt32(cmbUposlenici.SelectedValue) > 0)
                search.KorisnikID = Convert.ToInt32(cmbUposlenici.SelectedValue);

            search.DatumOd = dtpDatumOd.Value.Date;
            search.DatumDo = dtpDatumDo.Value.Date;
            search.IncludeKorisnik = true;
            search.IsBooked = false;
            await LoadData(search);
        }

        private async void dgvTermini_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = dgvTermini.SelectedRows[0].DataBoundItem as Models.Termin;

            var grid = (DataGridView)sender;

            if (grid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if (MessageBox.Show($"Jeste li sigurni da zelite obrisati ovaj termin?", $"Message for user - {APIService.Username}", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    var result = await service.Delete<Proizvod>(item.TerminID);

                    await LoadData();

                    MessageBox.Show("Uspjesno ste obrisali termin");
                }
            }

            else
            {
                frmTerminDodaj frm = new frmTerminDodaj(item);
                frm.Show();
            }
        }
    }
}
