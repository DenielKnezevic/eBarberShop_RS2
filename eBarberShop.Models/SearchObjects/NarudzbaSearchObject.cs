using System;
using System.Collections.Generic;
using System.Text;

namespace eBarberShop.Models.SearchObjects
{
    public class NarudzbaSearchObject : BaseSearchObject
    {
        public string BrojNarudzbe { get; set; }
        public int? KorisnikID { get; set; }
        public DateTime? DatumNarudzbe { get; set; }
    }
}
