using eBarberShop.Models;
using eBarberShop.Models.Requests;
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

        private async void frmNarudzba_Load(object sender, EventArgs e)
        {
            await LoadData();

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Text = "Isporuci";
            btn.DataPropertyName = "Isporuci";
            btn.HeaderText = "Akcija";
            btn.UseColumnTextForButtonValue = true;

            dgvNarudzba.Columns.Add(btn);
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            NarudzbaSearchObject search = new NarudzbaSearchObject();

            search.DatumNarudzbe = dtpDatum.Value.Date;

            search.BrojNarudzbe = txtNarudzbaSearch.Text;

            await LoadData(search);

            
        }

        public async Task LoadData(NarudzbaSearchObject search = null)
        {
            if(search == null)
            {
                search = new NarudzbaSearchObject();
                search.IsShipped = false;
                var list = await service.GetAll<List<Narudzba>>(search);

                dgvNarudzba.DataSource = list;

            }
            else
            {
                var list = await service.GetAll<List<Narudzba>>(search);

                dgvNarudzba.DataSource = list;
            }
        }

        private async void dgvNarudzba_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var grid = (DataGridView)sender;

            if (grid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                var narudzba = dgvNarudzba.SelectedRows[0].DataBoundItem as Narudzba;

                NarudzbaUpdateRequest request = new NarudzbaUpdateRequest() { IsShipped = true };

                    var result = await service.Update<Narudzba>(narudzba.NarudzbaID, request);

                    await LoadData();

            }
        }

        private void dtpDatum_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtNarudzbaSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
