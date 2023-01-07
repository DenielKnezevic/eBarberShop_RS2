using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eBarberShop.Models.Requests
{
    public class NarudzbaUpdateRequest
    {
        [Required]
        public bool IsShipped { get; set; }
        [Required]
        public bool IsCanceled { get; set; }
    }
}
