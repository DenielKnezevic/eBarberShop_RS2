using System;
using System.Collections.Generic;
using System.Text;

namespace eBarberShop.Models
{
    public class Slika
    {
        public int SlikaID { get; set; }
        public byte[] SlikaByte { get; set; }
        public string Opis { get; set; }
        public int KorisnikID { get; set; }
    }
}
