using System;
using System.Collections.Generic;
using System.Text;

namespace eBarberShop.Models
{
    public class Proizvod
    {
        public int ProizvodID { get; set; }
        public string Naziv { get; set; }
        public string Sifra { get; set; }
        public decimal Cijena { get; set; }
        public byte[] Slika { get; set; }
        public int VrstaProizvodaID { get; set; }

        public virtual VrstaProizvoda VrstaProizvoda { get; set; }
    }
}
