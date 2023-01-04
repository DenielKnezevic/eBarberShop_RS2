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

            if (Convert.ToInt32(cmbVrstaProizvod.SelectedValue) > 0)
                proizvodSeachObject.VrstaProizvodaID = Convert.ToInt32(cmbVrstaProizvod.SelectedValue);

            await LoadData(proizvodSeachObject);

        }

        private async void frmProizvod_Load(object sender, EventArgs e)
        {
           await UcitajComboBox();
           await LoadData();

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Text = "Obrisi";
            btn.DataPropertyName = "Obrisi";
            btn.HeaderText = "Akcija";
            btn.UseColumnTextForButtonValue = true;

            dgvProizvod.Columns.Add(btn);

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
        
        public async Task LoadData(ProizvodSearchObject search = null)
        {
            var list = await service.GetAll<List<Proizvod>>(search);

            dgvProizvod.DataSource = list;
        }

        private async void dgvProizvod_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var proizvod = dgvProizvod.SelectedRows[0].DataBoundItem as Proizvod;

            var grid = (DataGridView)sender;

            if (grid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if (MessageBox.Show($"Jeste li sigurni da zelite obrisati ovaj proizvod?", $"Message for user - {APIService.Username}", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    var result = await service.Delete<Proizvod>(proizvod.ProizvodID);

                    await LoadData();

                    MessageBox.Show("Uspjesno ste obrisali proizvod");
                }
            }
            else
            {
                frmProizvodDodaj frmProizvodDodaj = new frmProizvodDodaj(proizvod);
                frmProizvodDodaj.ShowDialog();
            }
            
        }
    }
}
