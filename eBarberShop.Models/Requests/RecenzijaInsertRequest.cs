using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eBarberShop.Models.Requests
{
    public class RecenzijaInsertRequest
    {
        [Required(AllowEmptyStrings =false,ErrorMessage = "Sadrzaj ne smije ostati prazno polje")]
        public string SadrzajRecenzije { get; set; }
        [Required(ErrorMessage ="Ocjena je obavezna")]
        public int Ocjena { get; set; }
        public DateTime DatumKreiranja { get; set; }
        [Required]
        public int KorisnikID { get; set; }
    }
}
