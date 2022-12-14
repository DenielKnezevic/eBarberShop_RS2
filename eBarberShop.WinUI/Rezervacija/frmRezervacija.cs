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
    public partial class frmRezervacija : Form
    {
        public APIService service = new APIService("Rezervacija");

        public frmRezervacija()
        {
            InitializeComponent();
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {

        }

        private async void frmRezervacija_Load(object sender, EventArgs e)
        {
            await LoadData();
        }

        public async Task LoadData()
        {
            RezervacijaSearchObject search = new RezervacijaSearchObject();

            search.DatumOd = dtpDatumOd.Value.Date;
            search.DatumDo = dtpDatumDo.Value.Date;
            search.IsArchived = false;

            var list = await service.GetAll<List<Rezervacija>>(search);

            dgvRezervacija.DataSource = list;
        }
    }
}
