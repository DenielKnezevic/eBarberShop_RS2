using eBarberShop.Models.Requests;
using eBarberShop.Models.SearchObjects;
using eBarberShop.Services.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eBarberShop.Controllers
{
    public class SlikaController : CRUDController<Models.Slika,SlikaSearchObject,SlikaInsertRequest,SlikaUpdateRequest>
    {
        public SlikaController(ISlikaService service):base(service)
        {

        }
    }
}
