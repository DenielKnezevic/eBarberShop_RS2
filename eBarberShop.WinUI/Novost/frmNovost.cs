using eBarberShop.Models;
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
    public partial class frmNovost : Form
    {

        APIService service = new APIService("Novost");

        public frmNovost()
        {
            InitializeComponent();
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            var lista = await service.GetAll<List<Novost>>();

            dgvNovost.DataSource = lista;
        }

        private void dgvNovost_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = dgvNovost.SelectedRows[0].DataBoundItem as Novost;
            frmNovostiDodaj frmNovostiDodaj = new frmNovostiDodaj(item);
            frmNovostiDodaj.Show();
        }
    }
}
