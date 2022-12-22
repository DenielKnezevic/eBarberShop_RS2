using eBarberShop.Models.Requests;
using eBarberShop.Models.SearchObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBarberShop.Services.Services
{
    public interface ISlikaService : ICRUDService<Models.Slika , SlikaSearchObject, SlikaInsertRequest , SlikaUpdateRequest>
    {
    }
}
