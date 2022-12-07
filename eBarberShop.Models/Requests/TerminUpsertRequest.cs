using System;
using System.Collections.Generic;
using System.Text;

namespace eBarberShop.Models.Requests
{
    public class TerminUpsertRequest
    {
        public DateTime DatumTermina { get; set; }
        public string VrijemeTermina { get; set; }
        public int KorisnikID { get; set; }
    }
}
