using eBarberShop.Models.Requests;
using eBarberShop.Services.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBarberShop.Services.Services
{
    public interface IRezervacijaService:ICRUDService<Models.Rezervacija,object,RezervacijaUpsertRequest,RezervacijaUpsertRequest>
    {
    }
}
