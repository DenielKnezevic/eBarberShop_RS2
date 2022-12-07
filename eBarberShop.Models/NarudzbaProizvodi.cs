using System;
using System.Collections.Generic;
using System.Text;

namespace eBarberShop.Models
{
    public class NarudzbaProizvodi
    {
        public int NarudzbaProizvodiID { get; set; }
        public int ProizvodID { get; set; }
        public int NarudzbaID { get; set; } 
        public int Kolicina { get; set; }

        public virtual Proizvod Proizvod { get; set; }
    }
}
