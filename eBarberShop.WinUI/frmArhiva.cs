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
    public partial class frmArhiva : Form
    {

        APIService service = new APIService("Rezervacija");

        public frmArhiva()
        {
            InitializeComponent();
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            RezervacijaSearchObject search = new RezervacijaSearchObject();

            search.IsArchived = true;

            var list = await service.GetAll<List<Rezervacija>>(search);

            dgvArhiva.DataSource = list;
        }
    }
}
