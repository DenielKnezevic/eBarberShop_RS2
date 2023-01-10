using eBarberShop.Models;
using eBarberShop.Models.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
                cmbUposlenici.SelectedValue = _termin.KorisnikID;
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
           if(ValidateChildren())
            {
                string pattern = @"\d{2}:\d{2}";
                bool isMatch = Regex.IsMatch(txtVrijeme.Text, pattern);
                if (isMatch == false)
                {
                    MessageBox.Show("Unesite samo brojeve i : (format mora biti 12:00)");
                    return;
                }

                if (_termin != null)
                {
                    TerminUpsertRequest request = new TerminUpsertRequest();

                    request.VrijemeTermina = txtVrijeme.Text;
                    request.DatumTermina = dtpDatum.Value.Date;
                    request.KorisnikID = Convert.ToInt32(cmbUposlenici.SelectedValue);

                    var insert = await service.Update<Models.Termin>(_termin.KorisnikID, request);

                    MessageBox.Show("Uspjesno ste uredili termin");
                }
                else
                {
                    TerminUpsertRequest request = new TerminUpsertRequest();

                    request.VrijemeTermina = txtVrijeme.Text;
                    request.DatumTermina = dtpDatum.Value.Date;
                    request.KorisnikID = Convert.ToInt32(cmbUposlenici.SelectedValue);

                    var insert = await service.Add<Models.Termin>(request);

                    MessageBox.Show("Uspjesno ste dodali termin");
                }
            }
        }

        private void dtpDatum_Validating(object sender, CancelEventArgs e)
        {
            if(dtpDatum.Value.Date < DateTime.Now.Date)
            {
                e.Cancel = true;
                errorProvider.SetError(dtpDatum, "Datum ne smije biti manji od trenutnog");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(dtpDatum, "");
            }
        }

        private void cmbUposlenici_Validated(object sender, EventArgs e)
        {
            
        }

        private void cmbUposlenici_Validating(object sender, CancelEventArgs e)
        {
            if (Convert.ToInt32((cmbUposlenici.SelectedValue)) < 1)
            {
                e.Cancel = true;
                errorProvider.SetError(cmbUposlenici, "Morate odabrati uposlenika");
            }

            else
            {
                e.Cancel = false;
                errorProvider.SetError(cmbUposlenici, "");
            }
        }

        private void txtVrijeme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtVrijeme.Text))
            {
                e.Cancel = true;
                txtVrijeme.Focus();
                errorProvider.SetError(txtVrijeme, "Vrijeme ne moze ostati prazno polje");
            }
            else if (txtVrijeme.Text.Length < 4)
            {
                e.Cancel = true;
                txtVrijeme.Focus();
                errorProvider.SetError(txtVrijeme, "Vrijeme ne moze da sadrzi manje od 4 karaktera");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtVrijeme, "");
            }
        }
    }
}
