using System;
using System.Collections.Generic;
using System.Text;

namespace eBarberShop.Models
{
    public class Korisnik
    {
        public int KorisnikID { get; set; }
        public string Ime { get; set; } 
        public string Prezime { get; set; } 
        public DateTime DatumRodjenja { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public int GradID { get; set; }
        public int DrzavaID { get; set; }
        public string KorisnickoIme { get; set; }

        public virtual ICollection<KorisnikUloga> KorisnikUlogas { get; set; }
    }
}
