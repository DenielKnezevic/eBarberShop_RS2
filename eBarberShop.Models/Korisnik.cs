using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace eBarberShop.Models
{
    public class Korisnik
    {
        [Browsable(false)]
        public int KorisnikID { get; set; }
        public string Ime { get; set; } 
        public string Prezime { get; set; } 
        public DateTime DatumRodjenja { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string Lokacija => $"{Grad?.Naziv},{Drzava?.Naziv}";
        [Browsable(false)]
        public int GradID { get; set; }
        [Browsable(false)]
        public int DrzavaID { get; set; }
        public string KorisnickoIme { get; set; }
        public string Uloge => string.Join(", ", KorisnikUlogas?.Select(x => x.Uloga?.Naziv)?.ToList());
        [Browsable(false)]
        public virtual Grad Grad { get; set; }
        [Browsable(false)]
        public virtual Drzava Drzava { get; set; }
        [Browsable(false)]
        public virtual ICollection<KorisnikUloga> KorisnikUlogas { get; set; }
    }
}
