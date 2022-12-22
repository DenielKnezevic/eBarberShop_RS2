using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eBarberShop.Models.Requests
{
    public class TerminUpsertRequest
    {
        [Required]
        public DateTime DatumTermina { get; set; }
        [Required(AllowEmptyStrings =false,ErrorMessage ="Vrijeme termina ne smije ostati prazno polje")]
        public string VrijemeTermina { get; set; }
        [Required]
        public int KorisnikID { get; set; }
    }
}
