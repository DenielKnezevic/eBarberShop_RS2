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
    public partial class frmSlika : Form
    {

        APIService service = new APIService("Slika");

        public frmSlika()
        {
            InitializeComponent();
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            await LoadData();
        }

        private void dgvSlika_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = dgvSlika.SelectedRows[0].DataBoundItem as Slika;
            frmSlikaDodaj frmSlikaDodaj = new frmSlikaDodaj(item);
            frmSlikaDodaj.Show();
        }

        private async void frmSlika_Load(object sender, EventArgs e)
        {
            await LoadData();
        }

        public async Task LoadData()
        {
            var list = await service.GetAll<List<Slika>>();

            dgvSlika.DataSource = list;
        }
    }
}
