using System;
using System.Collections.Generic;
using System.Text;

namespace eBarberShop.Models.Requests
{
    public class UplataUpsertRequest
    {
        public double Iznos { get; set; }
        public DateTime DatumTransakcije { get; set; }
        public string BrojTransakcije { get; set; }
    }
}
