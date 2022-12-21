using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace eBarberShop.Models
{
    public class Narudzba
    {
        [Browsable(false)]
        public int NarudzbaID { get; set; }
        public string BrojNarudzbe { get; set; }
        [Browsable(false)]
        public int KorisnikID { get; set; }
        [DisplayName("Narucio korisnik")]
        public string KorisnikIme => $"{Korisnik?.Ime} {Korisnik?.Prezime}";
        public DateTime DatumNarudzbe { get; set; }
        public string NarudzbaProizvodi => string.Join(", ", NarudzbaProizvodis?.Select(x => x.Proizvod?.Naziv)?.ToList());
        public bool IsCanceled { get; set; } = false;
        public bool IsShipped { get; set; } = false;
        [Browsable(false)]
        public virtual Korisnik Korisnik { get; set; }
        [Browsable(false)]

        public virtual ICollection<NarudzbaProizvodi> NarudzbaProizvodis { get; set; }
    }
}
