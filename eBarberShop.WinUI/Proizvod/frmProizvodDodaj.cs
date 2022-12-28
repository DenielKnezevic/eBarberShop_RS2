using eBarberShop.Models;
using eBarberShop.Models.Requests;
using eBarberShop.WinUI.Helpers;
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

namespace eBarberShop.WinUI
{
    public partial class frmProizvodDodaj : Form
    {

        public Proizvod _proizvod;
        public APIService service = new APIService("Proizvod");
        public APIService serviceVrstaProizvoda = new APIService("VrstaProizvoda");

        public frmProizvodDodaj(Proizvod proizvod = null)
        {
            InitializeComponent();
            _proizvod = proizvod;
        }

        private void btnDodajSliku_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.jpg; *.jpeg;.*.gif;)| *.jpg; *.jpeg;.*.gif";
            if (ofd.ShowDialog() == DialogResult.OK)
                pbSlika.Image = new Bitmap(ofd.FileName);
            pbSlika.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private async void btnDodajProizvod_Click(object sender, EventArgs e)
        {
            if(ValidateChildren())
            {
                if(pbSlika.Image == null)
                {
                    MessageBox.Show("Slika je obavezna", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string pattern = @"^[+-]?\d*\.?\d*$";
                bool isMatch = Regex.IsMatch(txtCijena.Text, pattern);
                if (isMatch == false)
                {
                    MessageBox.Show("Unesite samo brojeve i . (format mora biti 50.00)");
                    return;
                }

                if (_proizvod != null)
                {
                    ProizvodUpdateRequest update = new ProizvodUpdateRequest();
                    update.Cijena = Decimal.Parse(txtCijena.Text);
                    update.Naziv = txtNaziv.Text;
                    update.Slika = ImageHelper.FromImageToByte(pbSlika.Image);
                    update.VrstaProizvodaID = Convert.ToInt32(cmbVrstaProizvoda.SelectedValue);

                    var updateRequest = await service.Update<Proizvod>(_proizvod.ProizvodID, update);

                    MessageBox.Show("Uspjesno ste uredili proizvod");
                }
                else
                {
                    ProizvodInsertRequest insert = new ProizvodInsertRequest();
                    insert.Cijena = Decimal.Parse(txtCijena.Text);
                    insert.Naziv = txtNaziv.Text;
                    insert.Slika = ImageHelper.FromImageToByte(pbSlika.Image);
                    insert.VrstaProizvodaID = Convert.ToInt32(cmbVrstaProizvoda.SelectedValue);

                    var insertRequest = await service.Add<Proizvod>(insert);

                    MessageBox.Show("Uspjesno ste dodali proizvod");
                }
            }
        }

        public async Task LoadComboBox()
        {
            cmbVrstaProizvoda.DataSource = await serviceVrstaProizvoda.GetAll<List<VrstaProizvoda>>();
            cmbVrstaProizvoda.DisplayMember = "Naziv";
            cmbVrstaProizvoda.ValueMember = "VrstaProizvodaID";
        }

        private async void frmProizvodDodaj_Load(object sender, EventArgs e)
        {
            await LoadComboBox();

            if (_proizvod != null)
            {
                txtCijena.Text = _proizvod.Cijena.ToString();
                txtNaziv.Text = _proizvod.Naziv;
                cmbVrstaProizvoda.SelectedValue = _proizvod.VrstaProizvodaID;
                pbSlika.Image = ImageHelper.FromByteToImage(_proizvod.Slika);
                pbSlika.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void txtNaziv_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNaziv.Text))
            {
                e.Cancel = true;
                txtNaziv.Focus();
                errorProvider.SetError(txtNaziv, "Naslov ne moze ostati prazno polje");
            }
            else if (txtNaziv.Text.Length < 4)
            {
                e.Cancel = true;
                txtNaziv.Focus();
                errorProvider.SetError(txtNaziv, "Naslov ne moze da sadrzi manje od 4 karaktera");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtNaziv, "");
            }
        }

        private void txtCijena_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCijena.Text))
            {
                e.Cancel = true;
                txtCijena.Focus();
                errorProvider.SetError(txtCijena, "Cijena ne moze ostati prazno polje");
            }
            
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtCijena, "");
            }
        }

        private void txtCijena_TextChanged(object sender, EventArgs e)
        {
            string pattern = @"^[+-]?\d*\.?\d*$";
            bool isMatch = Regex.IsMatch(txtCijena.Text, pattern);
            if (isMatch == false)
            {
                if (txtCijena.Text.Length > 0)
                {
                    MessageBox.Show("Unesite samo brojeve i : (format mora biti 50.00)");
                    txtCijena.Text = txtCijena.Text.Remove(txtCijena.Text.Length - 1);
                }
            }
        }

        private void cmbVrstaProizvoda_Validating(object sender, CancelEventArgs e)
        {
            if(Convert.ToInt32(cmbVrstaProizvoda.SelectedValue) < 1)
            {
                e.Cancel = true;
                errorProvider.SetError(cmbVrstaProizvoda, "Morate odabrati vrstu proizvoda");
            }

            else
            {
                e.Cancel = false;
                errorProvider.SetError(cmbVrstaProizvoda, "");
            }
        }
    }
}
