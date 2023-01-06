using System;
using System.Collections.Generic;
using System.Text;

namespace eBarberShop.Models
{
    public class Uplata
    {
        public int UplataID { get; set; }
        public double Iznos { get; set; }
        public DateTime DatumTransakcije { get; set; }
        public string BrojTransakcije { get; set; }
    }
}
