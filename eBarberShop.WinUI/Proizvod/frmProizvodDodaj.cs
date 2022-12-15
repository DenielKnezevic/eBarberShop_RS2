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
            if(_proizvod != null)
            {
                ProizvodUpdateRequest update = new ProizvodUpdateRequest();
                update.Cijena = Decimal.Parse(txtCijena.Text);
                update.Naziv = txtNaziv.Text;
                update.Slika = ImageHelper.FromImageToByte(pbSlika.Image);
                update.VrstaProizvodaID = Convert.ToInt32(cmbVrstaProizvoda.SelectedValue);

                var updateRequest = await service.Update<Proizvod>(_proizvod.ProizvodID, update);
            }
            else
            {
                ProizvodInsertRequest insert = new ProizvodInsertRequest();
                insert.Cijena = Decimal.Parse(txtCijena.Text);
                insert.Naziv = txtNaziv.Text;
                insert.Sifra = Guid.NewGuid().ToString();
                insert.Slika = ImageHelper.FromImageToByte(pbSlika.Image);
                insert.VrstaProizvodaID = Convert.ToInt32(cmbVrstaProizvoda.SelectedValue);

                var insertRequest = await service.Add<Proizvod>(insert); 
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
    }
}
