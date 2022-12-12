using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace eBarberShop.Models
{
    public class Proizvod
    {
        [Browsable(false)]
        public int ProizvodID { get; set; }
        public string Naziv { get; set; }
        public string Sifra { get; set; }
        public decimal Cijena { get; set; }
        public byte[] Slika { get; set; }
        [Browsable(false)]
        public int VrstaProizvodaID { get; set; }
        [Browsable(false)]
        public virtual VrstaProizvoda VrstaProizvoda { get; set; }
        public string VrstaProizvodaNaziv => VrstaProizvoda?.Naziv;
    }
}
