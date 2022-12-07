using System;
using System.Collections.Generic;
using System.Text;

namespace eBarberShop.Models
{
    public class Termin
    {
        public int TerminID { get; set; }
        public DateTime DatumTermina { get; set; }
        public string VrijemeTermina { get; set; }
        public int KorisnikID { get; set; }
    }
}
