﻿using System;
using System.Collections.Generic;
using System.Text;

namespace eBarberShop.Models.Requests
{
    public class ProizvodUpdateRequest
    {
        public string Naziv { get; set; }
        public decimal Cijena { get; set; }
        public byte[] Slika { get; set; }
        public int VrstaProizvodaID { get; set; }
    }
}