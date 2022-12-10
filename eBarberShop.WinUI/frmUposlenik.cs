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
    public partial class frmUposlenik : Form
    {
        APIService service = new APIService("Korisnik");

        public frmUposlenik()
        {
            InitializeComponent();
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            var list = await service.GetAll<List<Korisnik>>();

            List<Korisnik> konacnaLista = new List<Korisnik>();

            foreach (var item in list)
            {
                foreach (var item2 in item.KorisnikUlogas)
                {
                    if (item2.UlogaID == 2)
                        konacnaLista.Add(item);
                }
            }

            dgvUposlenik.DataSource = konacnaLista;
        }
    }
}
