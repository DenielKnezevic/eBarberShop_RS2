using System;
using System.Collections.Generic;
using System.Text;

namespace eBarberShop.Models
{
    public class Rezervacija
    {
        public int RezervacijaID { get; set; }
        public int KorisnikID { get; set; }
        public int TerminID { get; set; }
        public int UslugaID { get; set; }
        public DateTime DatumRezervacije { get; set; }
        public bool IsCanceled { get; set; } 
        public bool IsArchived { get; set; } 

        public virtual Korisnik Korisnik { get; set; }
        public virtual Termin Termin { get; set; }
    }
}
