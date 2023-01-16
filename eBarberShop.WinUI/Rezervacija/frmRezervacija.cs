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
    public partial class frmRezervacija : Form
    {
        public APIService service = new APIService("Rezervacija");

        public frmRezervacija()
        {
            InitializeComponent();
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            RezervacijaSearchObject search = new RezervacijaSearchObject();

            search.DatumOd = dtpDatumOd.Value.Date;
            search.DatumDo = dtpDatumDo.Value.Date;
            search.IsArchived = false;
            search.IsCanceled = false;
            search.IncludeTermin = true;
            search.IncludeUsluga = true;
            search.IncludeKorisnik = true;

            await LoadData(search);
        }

        private async void frmRezervacija_Load(object sender, EventArgs e)
        {
            await LoadData();

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Text = "Arhiviraj";
            btn.DataPropertyName = "Arhiviraj";
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


            dgvRezervacija.Columns.Add(btn);
            dgvRezervacija.Columns.Add(btn1);
            dgvRezervacija.Columns.Add(btn2);
        }

        public async Task LoadData(RezervacijaSearchObject search = null)
        { 
            if(search == null)
            {
                search = new RezervacijaSearchObject();
                search.IsArchived=false;
                search.IsCanceled = false;
                search.IncludeTermin = true;
                search.IncludeUsluga = true;
                search.IncludeKorisnik = true;

                var list = await service.GetAll<List<Rezervacija>>(search);

                dgvRezervacija.DataSource = list;
            }
            else
            {
                var list = await service.GetAll<List<Rezervacija>>(search);

                dgvRezervacija.DataSource = list;
            }
        }

        private async void dgvRezervacija_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var grid = (DataGridView)sender;

            if (grid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                var item = dgvRezervacija.SelectedRows[0].DataBoundItem as Rezervacija;

                if (grid.Columns[e.ColumnIndex].DataPropertyName == "Arhiviraj")
                {
                    RezervacijaUpsertRequest request = new RezervacijaUpsertRequest();
                    request.IsArchived = true;
                    request.IsCanceled = false;
                    request.UslugaID = item.UslugaID;
                    request.DatumRezervacije = item.DatumRezervacije;
                    request.TerminID = item.TerminID;
                    request.KorisnikID = item.KorisnikID;

                    var result = await service.Update<Rezervacija>(item.RezervacijaID, request);

                    MessageBox.Show("Uspjesno ste arhivirali rezervaciju");

                    await LoadData();

                }
                else if(grid.Columns[e.ColumnIndex].DataPropertyName == "Otkazi")
                {
                    RezervacijaUpsertRequest request = new RezervacijaUpsertRequest();
                    request.IsArchived = false;
                    request.IsCanceled = true;
                    request.UslugaID = item.UslugaID;
                    request.DatumRezervacije = item.DatumRezervacije;
                    request.TerminID = item.TerminID;
                    request.KorisnikID = item.KorisnikID;

                    var result = await service.Update<Rezervacija>(item.RezervacijaID, request);

                    MessageBox.Show("Uspjesno ste otkazali rezervaciju");

                    await LoadData();
                }
                else if(grid.Columns[e.ColumnIndex].DataPropertyName == "Obrisi")
                {
                        if (MessageBox.Show($"Jeste li sigurni da zelite obrisati ovu rezervaciju?", $"Message for user - {APIService.Username}", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            var result = await service.Delete<Rezervacija>(item.RezervacijaID);

                            await LoadData();

                            MessageBox.Show("Uspjesno ste obrisali rezervaciju");
                        }
                    
                }
            }
        }
    }
}
