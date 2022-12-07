using System;
using System.Collections.Generic;
using System.Text;

namespace eBarberShop.Models
{
    public class Narudzba
    {
        public int NarudzbaID { get; set; }
        public string BrojNarudzbe { get; set; }
        public int KorisnikID { get; set; }
        public DateTime DatumNarudzbe { get; set; }
        public virtual Korisnik Korisnik { get; set; }

        public virtual ICollection<NarudzbaProizvodi> NarudzbaProizvodis { get; set; }
    }
}
