using System;
using System.Collections.Generic;
using System.Text;

namespace eBarberShop.Models.SearchObjects
{
    public class TerminSearchObject : BaseSearchObject
    {
        public int? KorisnikID { get; set; }
        public bool? IsBooked { get; set; }
        public DateTime? DatumOd { get; set; }
        public DateTime? DatumDo { get; set; }
    }
}
