using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace eBarberShop.Models
{
    public class Rezervacija
    {
        [Browsable(false)]
        public int RezervacijaID { get; set; }
        [Browsable(false)]
        public int KorisnikID { get; set; }
        [Browsable(false)]
        public int TerminID { get; set; }
        [Browsable(false)]
        public int UslugaID { get; set; }
        [DisplayName("Termin kod")]
        public string TerminKod => $"{Korisnik?.Ime} {Korisnik?.Prezime}";
        [DisplayName("Datum termina")]
        public string TerminVrijeme => $"{Termin?.DatumTermina.Date}, {Termin?.VrijemeTermina}";
        public DateTime DatumRezervacije { get; set; }
        public bool IsCanceled { get; set; } 
        public bool IsArchived { get; set; }
        [Browsable(false)]
        public virtual Korisnik Korisnik { get; set; }
        [Browsable(false)]
        public virtual Termin Termin { get; set; }
    }
}
