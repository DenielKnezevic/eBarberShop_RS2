using System;
using System.Collections.Generic;
using System.Text;

namespace eBarberShop.Models.Requests
{
    public class KorisnikUpdateRequest
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public int GradID { get; set; }
        public int DrzavaID { get; set; }
        public string Lozinka { get; set; }
        public string Uloga { get; set; }
    }
}
