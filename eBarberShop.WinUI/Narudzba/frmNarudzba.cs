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
    public partial class frmNarudzba : Form
    {

        public APIService service = new APIService("Narudzba");

        public frmNarudzba()
        {
            InitializeComponent();
        }

        private void frmNarudzba_Load(object sender, EventArgs e)
        {

        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            NarudzbaSearchObject search = new NarudzbaSearchObject();

            search.DatumNarudzbe = dtpDatum.Value.Date;

            search.BrojNarudzbe = txtNarudzbaSearch.Text;

            var list = await service.GetAll<List<Narudzba>>(search);

            dgvNarudzba.DataSource = list;
        }
    }
}
