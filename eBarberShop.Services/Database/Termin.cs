using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBarberShop.Services.Database
{
    public class Termin
    {
        public int TerminID { get; set; }
        public DateTime DatumTermina { get; set; }
        public DateTime DatumKreiranja { get; set; } = DateTime.Now;
        public string VrijemeTermina { get; set; } = null!;
        public int KorisnikID { get; set; }

        public virtual Korisnik Korisnik { get; set; } = null!;

    }
}
