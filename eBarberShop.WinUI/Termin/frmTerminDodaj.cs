using eBarberShop.Models;
using eBarberShop.Models.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBarberShop.WinUI.Termin
{
    public partial class frmTerminDodaj : Form
    {

        APIService service = new APIService("Termin");
        APIService serviceUposlenici = new APIService("Korisnik");
        Models.Termin _termin;

        public frmTerminDodaj(Models.Termin termin = null)
        {
            InitializeComponent();
            _termin = termin;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void frmTerminDodaj_Load(object sender, EventArgs e)
        {
            await LoadUposlenici();
            await LoadTermin();
        }

        public async Task LoadTermin()
        {
            if(_termin!= null)
            {
                dtpDatum.Value = _termin.DatumTermina.Date;
                txtVrijeme.Text = _termin.VrijemeTermina;
                cmbUposlenici.SelectedIndex = _termin.KorisnikID - 1;
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

            cmbUposlenici.DataSource = konacnaLista;
            cmbUposlenici.DisplayMember = "Ime";
            cmbUposlenici.ValueMember = "KorisnikID";
            cmbUposlenici.SelectedItem = null;
            cmbUposlenici.SelectedText = "Izaberite uposlenika";
        }

        private async void btnDodaj_Click(object sender, EventArgs e)
        {
           if(_termin != null)
            {
                TerminUpsertRequest request = new TerminUpsertRequest();

                request.VrijemeTermina = txtVrijeme.Text;
                request.DatumTermina = dtpDatum.Value.Date;
                request.KorisnikID = Convert.ToInt32(cmbUposlenici.SelectedValue);

                var insert = await service.Update<Models.Termin>(_termin.KorisnikID,request);
            }
            else
            {
                TerminUpsertRequest request = new TerminUpsertRequest();

                request.VrijemeTermina = txtVrijeme.Text;
                request.DatumTermina = dtpDatum.Value.Date;
                request.KorisnikID = Convert.ToInt32(cmbUposlenici.SelectedValue);

                var insert = await service.Add<Models.Termin>(request);
            }
        }
    }
}
