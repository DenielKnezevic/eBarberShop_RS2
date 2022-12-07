using eBarberShop.Models.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBarberShop.Services.Services
{
    public interface INarudzbaService : ICRUDService<Models.Narudzba, object , NarudzbaInsertRequest , NarudzbaUpdateRequest>
    {
    }
}
