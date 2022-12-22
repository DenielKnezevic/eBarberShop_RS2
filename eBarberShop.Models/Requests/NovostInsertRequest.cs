﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eBarberShop.Models.Requests
{
    public class NovostInsertRequest
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Naslov ne smije ostati prazno polje")]
        public string Naslov { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Sadrzaj ne smije ostati prazno polje")]
        public string Sadrzaj { get; set; }
        [Required(ErrorMessage = "Slika je obavezna")]
        public byte[] Thumbnail { get; set; }
        public DateTime DatumKreiranja { get; set; }
        [Required]
        public int KorisnikID { get; set; }
    }
}
