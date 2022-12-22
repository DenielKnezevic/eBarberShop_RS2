using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eBarberShop.Models.Requests
{
    public class NarudzbaInsertRequest
    {
        public string BrojNarudzbe { get; set; }
        [Required]
        public int KorisnikID { get; set; }
        [Required]
        public DateTime DatumNarudzbe { get; set; }
        [Required]
        public List<int> ProizvodiID { get; set; }
    }
}
