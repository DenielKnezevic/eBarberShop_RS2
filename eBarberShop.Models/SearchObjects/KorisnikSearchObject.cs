﻿using System;
using System.Collections.Generic;
using System.Text;

namespace eBarberShop.Models.SearchObjects
{
    public class KorisnikSearchObject : BaseSearchObject
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string KorisnickoIme { get; set; }
        public bool? IncludeUloge { get; set; }
        public bool? IncludeGrad { get; set; }
        public bool? IncludeDrzava { get; set; }
    }
}
