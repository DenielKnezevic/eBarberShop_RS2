using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBarberShop.Services.Database
{
    public class Rezervacija
    {
        public int RezervacijaID { get; set; }
        public int KorisnikID { get; set; }
        public int? TerminID { get; set; }
        public int UslugaID { get; set; }
        public DateTime DatumRezervacije { get; set; }

        public virtual Korisnik Korisnik { get; set; } = null!;
        public virtual Termin Termin { get; set; } = null!;
        public virtual Usluga Usluga { get; set; } = null!;
    }
}
