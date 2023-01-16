using System;
using System.Collections.Generic;
using System.Text;

namespace eBarberShop.Models.SearchObjects
{
    public class ProizvodSearchObject : BaseSearchObject
    {
        public int? VrstaProizvodaID { get; set; }
        public string Naziv { get; set; }
        public bool? IncludeVrstaProizvoda { get; set; }
    }
}
