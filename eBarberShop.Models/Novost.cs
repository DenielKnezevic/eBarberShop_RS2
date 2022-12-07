using System;
using System.Collections.Generic;
using System.Text;

namespace eBarberShop.Models
{
    public class Novost
    {
        public int NovostID { get; set; }
        public string Naslov { get; set; }
        public string Sadrzaj { get; set; }
        public byte[] Thumbnail { get; set; }
        public DateTime DatumKreiranja { get; set; }
        public int KorisnikID { get; set; }
    }
}
