using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBarberShop.Services.Database
{
    public class NarudzbaProizvodi
    {
        public int NarudzbaProizvodiID { get; set; }
        public int KorisnikID { get; set; }
        public int ProizvodID { get; set; }
        public int Kolicina { get; set; }

        public virtual Korisnik Korisnik { get; set; } = null!;
        public virtual Proizvod Proizvod { get; set; } = null!;
    }

}
