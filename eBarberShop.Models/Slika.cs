using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace eBarberShop.Models
{
    public class Slika
    {
        [Browsable(false)]
        public int SlikaID { get; set; }
        [DisplayName("Dodao korisnik")]
        public string UposlenikIme => $"{Korisnik?.Ime} {Korisnik?.Prezime}";
        public byte[] SlikaByte { get; set; }
        public string Opis { get; set; }
        [Browsable(false)]
        public int KorisnikID { get; set; }
        [Browsable(false)]
        public Korisnik Korisnik { get; set; }
    }
}
