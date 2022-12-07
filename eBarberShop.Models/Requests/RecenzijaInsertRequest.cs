using System;
using System.Collections.Generic;
using System.Text;

namespace eBarberShop.Models.Requests
{
    public class RecenzijaInsertRequest
    {
        public string SadrzajRecenzije { get; set; }
        public int Ocjena { get; set; }
        public DateTime DatumKreiranja { get; set; }
        public int KorisnikID { get; set; }
    }
}
