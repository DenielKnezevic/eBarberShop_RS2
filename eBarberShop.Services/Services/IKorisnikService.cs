using eBarberShop.Models.Requests;
using eBarberShop.Models.SearchObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBarberShop.Services.Services
{
    public interface IKorisnikService : ICRUDService<Models.Korisnik, KorisnikSearchObject , KorisnikInsertRequest, KorisnikUpdateRequest>
    {
        Models.Korisnik Login(string username, string password);
        Models.Korisnik AddUloga(int id);
    }
}
