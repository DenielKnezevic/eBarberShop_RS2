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
    public partial class frmNovostiDodaj : Form
    {

        public Novost _novost;
        public APIService service = new APIService("Novost");

        public frmNovostiDodaj(Novost novost = null)
        {
            InitializeComponent();
            _novost = novost;
        }

        private void btnDodajSliku_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.jpg; *.jpeg;.*.gif;)| *.jpg; *.jpeg;.*.gif";
            if (ofd.ShowDialog() == DialogResult.OK)
                pbSlika.Image = new Bitmap(ofd.FileName);
            pbSlika.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private async void btnDodajNovost_Click(object sender, EventArgs e)
        {
            if(ValidateChildren())
            {
                if(pbSlika.Image == null)
                {
                    MessageBox.Show("Slika je obavezna", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (_novost != null)
                {
                    NovostUpdateRequest update = new NovostUpdateRequest();
                    update.Sadrzaj = rtbSadrzaj.Text;
                    update.Naslov = txtNaslov.Text;
                    update.DatumKreiranja = DateTime.Now;
                    update.Thumbnail = ImageHelper.FromImageToByte(pbSlika.Image);

                    var request = await service.Update<Novost>(_novost.NovostID, update);

                    MessageBox.Show("Uspjesno ste uredili novost");
                }
                else
                {
                    NovostInsertRequest insert = new NovostInsertRequest();
                    insert.Sadrzaj = rtbSadrzaj.Text;
                    insert.Naslov = txtNaslov.Text;
                    insert.DatumKreiranja = DateTime.Now;
                    insert.Thumbnail = ImageHelper.FromImageToByte(pbSlika.Image);
                    insert.KorisnikID = APIService.Korisnik.KorisnikID;

                    var request = await service.Add<Novost>(insert);

                    MessageBox.Show("Uspjesno ste uredili novost");
                }
            }
        }

        private void frmNovostiDodaj_Load(object sender, EventArgs e)
        {
            if(_novost != null)
            {
                txtNaslov.Text = _novost.Naslov;
                rtbSadrzaj.Text = _novost.Sadrzaj;
                pbSlika.Image = ImageHelper.FromByteToImage(_novost.Thumbnail);
            }
        }

        private void txtNaslov_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtNaslov.Text))
            {
                e.Cancel = true;
                txtNaslov.Focus();
                errorProvider.SetError(txtNaslov, "Naslov ne moze ostati prazno polje");
            }
            else if(txtNaslov.Text.Length < 4)
            {
                e.Cancel=true;
                txtNaslov.Focus();
                errorProvider.SetError(txtNaslov, "Naslov ne moze da sadrzi manje od 4 karaktera");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtNaslov, "");
            }
        }

        private void rtbSadrzaj_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(rtbSadrzaj.Text))
            {
                e.Cancel = true;
                txtNaslov.Focus();
                errorProvider.SetError(rtbSadrzaj, "Sadrzaj ne moze ostati prazno polje");
            }
            else if (rtbSadrzaj.Text.Length < 10)
            {
                e.Cancel = true;
                txtNaslov.Focus();
                errorProvider.SetError(rtbSadrzaj, "Sadrzaj ne moze da sadrzi manje od 10 karaktera");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(rtbSadrzaj, "");
            }
        }
    }
}
