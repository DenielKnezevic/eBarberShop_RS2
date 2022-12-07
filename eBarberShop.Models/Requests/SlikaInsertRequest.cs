using System;
using System.Collections.Generic;
using System.Text;

namespace eBarberShop.Models.Requests
{
    public class SlikaInsertRequest
    {
        public byte[] SlikaByte { get; set; }
        public string Opis { get; set; }
        public int KorisnikID { get; set; }
    }
}
