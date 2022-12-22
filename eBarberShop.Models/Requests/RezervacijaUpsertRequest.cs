using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eBarberShop.Models.Requests
{
    public class RezervacijaUpsertRequest
    {
        [Required]
        public int KorisnikID { get; set; }
        [Required]
        public int TerminID { get; set; }
        [Required]
        public int UslugaID { get; set; }
        [Required]
        public DateTime DatumRezervacije { get; set; }
        public bool IsCanceled { get; set; }
        public bool IsArchived { get; set; }
    }
}
