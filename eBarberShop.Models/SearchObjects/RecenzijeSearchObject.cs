using System;
using System.Collections.Generic;
using System.Text;

namespace eBarberShop.Models.SearchObjects
{
    public class RecenzijeSearchObject : BaseSearchObject
    {
        public bool? IncludeKorisnik { get; set; }
    }
}
