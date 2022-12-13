using System;
using System.Collections.Generic;
using System.Text;

namespace eBarberShop.Models.Requests
{
    public class RezervacijaUpsertRequest
    {
        public int KorisnikID { get; set; }
        public int TerminID { get; set; }
        public int UslugaID { get; set; }
        public DateTime DatumRezervacije { get; set; }
        public bool IsCanceled { get; set; }
        public bool IsArchived { get; set; }
    }
}
