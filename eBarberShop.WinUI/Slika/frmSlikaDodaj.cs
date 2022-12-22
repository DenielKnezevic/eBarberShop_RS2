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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBarberShop.WinUI
{
    public partial class frmSlikaDodaj : Form
    {

        public APIService service = new APIService("Slika");
        public Slika _slika;

        public frmSlikaDodaj(Slika slika = null)
        {
            InitializeComponent();
            _slika = slika;
        }

        private void btnDodajSliku_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.jpg; *.jpeg;.*.gif;)| *.jpg; *.jpeg;.*.gif";
            if (ofd.ShowDialog() == DialogResult.OK)
                pbSlika.Image = new Bitmap(ofd.FileName);
            pbSlika.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void frmSlikaDodaj_Load(object sender, EventArgs e)
        {
            if(_slika != null)
            {
                rtbOpis.Text = _slika.Opis;
                pbSlika.Image = ImageHelper.FromByteToImage(_slika.SlikaByte);
                pbSlika.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private async void Dodaj_Click(object sender, EventArgs e)
        {
           if(ValidateChildren())
            {
                if(pbSlika.Image == null)
                {
                    MessageBox.Show("Slika je obavezna", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (_slika != null)
                {
                    SlikaUpdateRequest update = new SlikaUpdateRequest();
                    update.SlikaByte = ImageHelper.FromImageToByte(pbSlika.Image);
                    update.Opis = rtbOpis.Text;

                    var request = await service.Update<Slika>(_slika.SlikaID, update);

                    MessageBox.Show("Uspjesno ste uredili sliku");
                }
                else
                {
                    SlikaInsertRequest insert = new SlikaInsertRequest();
                    insert.SlikaByte = ImageHelper.FromImageToByte(pbSlika.Image);
                    insert.Opis = rtbOpis.Text;
                    insert.KorisnikID = APIService.Korisnik.KorisnikID;

                    var request = await service.Add<Slika>(insert);

                    MessageBox.Show("Uspjesno ste dodali sliku");
                }
            }
        }

        private void rtbOpis_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(rtbOpis.Text))
            {
                e.Cancel = true;
                rtbOpis.Focus();
                errorProvider.SetError(rtbOpis, "Opis ne moze ostati prazno polje");
            }
            else if (rtbOpis.Text.Length < 10)
            {
                e.Cancel = true;
                rtbOpis.Focus();
                errorProvider.SetError(rtbOpis, "Opis ne moze da sadrzi manje od 4 karaktera");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(rtbOpis, "");
            }
        }
    }
}
