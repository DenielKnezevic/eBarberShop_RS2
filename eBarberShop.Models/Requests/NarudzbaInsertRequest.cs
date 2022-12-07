using System;
using System.Collections.Generic;
using System.Text;

namespace eBarberShop.Models.Requests
{
    public class NarudzbaInsertRequest
    {
        public string BrojNarudzbe { get; set; }
        public int KorisnikID { get; set; }
        public DateTime DatumNarudzbe { get; set; }
        public List<int> ProizvodiID { get; set; }
    }
}
