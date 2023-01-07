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

            DataGridViewButtonColumn btn1 = new DataGridViewButtonColumn();
            btn1.Text = "Otkazi";
            btn1.DataPropertyName = "Otkazi";
            btn1.HeaderText = "Akcija";
            btn1.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn btn2 = new DataGridViewButtonColumn();
            btn2.Text = "Obrisi";
            btn2.DataPropertyName = "Obrisi";
            btn2.HeaderText = "Akcija";
            btn2.UseColumnTextForButtonValue = true;

            dgvNarudzba.Columns.Add(btn);
            dgvNarudzba.Columns.Add(btn1);
            dgvNarudzba.Columns.Add(btn2);
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            NarudzbaSearchObject search = new NarudzbaSearchObject();

            search.DatumDo = dtpDatumDo.Value.Date;
            search.DatumOd = dtpDatumOd.Value.Date;
            search.BrojNarudzbe = txtNarudzbaSearch.Text;
            search.IsShipped = false;
            search.IsCanceled = false;

            await LoadData(search);

            
        }

        public async Task LoadData(NarudzbaSearchObject search = null)
        {
            if(search == null)
            {
                search = new NarudzbaSearchObject();
                search.IsShipped = false;
                search.IsCanceled = false;
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

                if (grid.Columns[e.ColumnIndex].DataPropertyName == "Isporuci")
                {
                    NarudzbaUpdateRequest request = new NarudzbaUpdateRequest() { IsShipped = true, IsCanceled = false };

                    var result = await service.Update<Narudzba>(narudzba.NarudzbaID, request);

                    MessageBox.Show("Uspjesno ste isporucili narudzbu");

                    await LoadData();
                }
                if (grid.Columns[e.ColumnIndex].DataPropertyName == "Otkazi")
                {
                    NarudzbaUpdateRequest request = new NarudzbaUpdateRequest() { IsShipped = false, IsCanceled = true };

                    var result = await service.Update<Narudzba>(narudzba.NarudzbaID, request);

                    MessageBox.Show("Uspjesno ste otkazali narudzbu");

                    await LoadData();
                }
                else if (grid.Columns[e.ColumnIndex].DataPropertyName == "Obrisi")
                {
                    if (MessageBox.Show($"Jeste li sigurni da zelite obrisati ovu narudzbu?", $"Message for user - {APIService.Username}", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        var result = await service.Delete<Rezervacija>(narudzba.NarudzbaID);

                        await LoadData();

                        MessageBox.Show("Uspjesno ste obrisali narudzbu");
                    }
                }

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
