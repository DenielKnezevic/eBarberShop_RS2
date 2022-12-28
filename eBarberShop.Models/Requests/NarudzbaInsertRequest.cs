using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eBarberShop.Models.Requests
{
    public class NarudzbaInsertRequest
    {
        [Required]
        public int KorisnikID { get; set; }
        [Required]
        public List<NarudzbaProizvodiInsertRequest> ListaProizvoda { get; set; }
    }
}
