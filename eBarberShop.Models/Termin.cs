using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace eBarberShop.Models
{
    public class Termin
    {
        [Browsable(false)]
        public int TerminID { get; set; }
        [DisplayName("Termin kod")]
        public string TerminUposelnik => $"{Korisnik?.Ime} {Korisnik?.Prezime}";
        public DateTime DatumTermina { get; set; }
        public DateTime DatumKreiranja { get; set; }
        public string VrijemeTermina { get; set; }
        [Browsable(false)]
        public int KorisnikID { get; set; }
        [Browsable(false)]
        public Korisnik Korisnik { get; set; }
    }
}
