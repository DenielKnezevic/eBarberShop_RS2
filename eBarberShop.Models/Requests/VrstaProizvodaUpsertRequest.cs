using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eBarberShop.Models.Requests
{
    public class VrstaProizvodaUpsertRequest
    {
        [Required(AllowEmptyStrings =false,ErrorMessage ="Naziv ne smije ostati prazno polje")]
        public string Naziv { get; set; }
        public string Opis { get; set; }
    }
}
