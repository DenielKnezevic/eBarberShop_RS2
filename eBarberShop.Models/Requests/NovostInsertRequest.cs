using System;
using System.Collections.Generic;
using System.Text;

namespace eBarberShop.Models.Requests
{
    public class NovostInsertRequest
    {
        public string Naslov { get; set; }
        public string Sadrzaj { get; set; }
        public byte[] Thumbnail { get; set; }
        public DateTime DatumKreiranja { get; set; }
        public int KorisnikID { get; set; }
    }
}
