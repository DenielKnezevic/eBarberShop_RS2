using System;
using System.Collections.Generic;
using System.Text;

namespace eBarberShop.Models.SearchObjects
{
    public class NarudzbaSearchObject : BaseSearchObject
    {
        public string BrojNarudzbe { get; set; }
        public int? KorisnikID { get; set; }
        public DateTime? DatumOd { get; set; }
        public DateTime? DatumDo { get; set; }
        public bool? IsShipped { get; set; }
    }
}
