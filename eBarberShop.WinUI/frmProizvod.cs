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
    public partial class frmProizvod : Form
    {
        public APIService service = new APIService("Proizvod");
        public APIService serviceVrstaProizvod = new APIService("VrstaProizvoda");

        public frmProizvod()
        {
            InitializeComponent();
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            ProizvodSearchObject proizvodSeachObject = new ProizvodSearchObject();

            proizvodSeachObject.Naziv = txtProizvodiSearch.Text;

            if(Convert.ToInt32(cmbVrstaProizvod.SelectedValue) > 0)
                proizvodSeachObject.VrstaProizvodaID = Convert.ToInt32(cmbVrstaProizvod.SelectedValue);

            var list = await service.GetAll<List<Proizvod>>(proizvodSeachObject);

            dgvProizvod.DataSource = list;
        }

        private async void frmProizvod_Load(object sender, EventArgs e)
        {
           await UcitajComboBox();
        }

        private async Task UcitajComboBox()
        {
            var list = await serviceVrstaProizvod.GetAll<List<VrstaProizvoda>>();
            cmbVrstaProizvod.DataSource = list;
            cmbVrstaProizvod.DisplayMember = "Naziv";
            cmbVrstaProizvod.ValueMember = "VrstaProizvodaID";
            cmbVrstaProizvod.SelectedItem = null;
            cmbVrstaProizvod.SelectedText = "Izaberite vrstu proizvoda";
        }
    }
}
