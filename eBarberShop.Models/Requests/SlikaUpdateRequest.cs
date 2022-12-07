using System;
using System.Collections.Generic;
using System.Text;

namespace eBarberShop.Models.Requests
{
    public class SlikaUpdateRequest
    {
        public byte[] SlikaByte { get; set; }
        public string Opis { get; set; }
    }
}
