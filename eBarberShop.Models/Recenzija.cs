using System;
using System.Collections.Generic;
using System.Text;

namespace eBarberShop.Models
{
    public class Recenzija
    {
        public int RecenzijaID { get; set; }
        public string SadrzajRecenzije { get; set; }
        public int Ocjena { get; set; }
        public DateTime DatumKreiranja { get; set; }
        public int KorisnikID { get; set; }
    }
}
