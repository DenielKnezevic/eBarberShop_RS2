using eBarberShop.Models.Requests;
using eBarberShop.Services.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eBarberShop.Controllers
{
    public class SlikaController : CRUDController<Models.Slika,object,SlikaInsertRequest,SlikaUpdateRequest>
    {
        public SlikaController(ISlikaService service):base(service)
        {

        }
    }
}
