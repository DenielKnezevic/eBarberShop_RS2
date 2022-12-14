using System;
using System.Collections.Generic;
using System.Text;

namespace eBarberShop.Models.SearchObjects
{
    public class TerminSearchObject : BaseSearchObject
    {
        public int? KorisnikID { get; set; }
        public DateTime? DatumTermina { get; set; }
    }
}
