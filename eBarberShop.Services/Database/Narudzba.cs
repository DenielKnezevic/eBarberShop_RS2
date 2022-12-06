using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBarberShop.Services.Database
{
    public class Narudzba
    {
        public Narudzba()
        {
            NarudzbaProizvodis = new HashSet<NarudzbaProizvodi>();
        }

        public int NarudzbaID { get; set; }
        public string? BrojNarudzbe { get; set; }
        public int KorisnikID { get; set; }
        public DateTime DatumNarudzbe { get; set; }

        public virtual Korisnik Korisnik { get; set; } = null!;
        public virtual ICollection<NarudzbaProizvodi> NarudzbaProizvodis { get; set; }
    }
}
