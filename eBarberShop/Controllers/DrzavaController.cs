using eBarberShop.Models;
using eBarberShop.Models.Requests;
using eBarberShop.Services.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eBarberShop.Controllers
{
    public class DrzavaController : CRUDController<Models.Drzava, object , DrzavaUpsertRequest , DrzavaUpsertRequest>
    {
        public DrzavaController(IDrzavaService service):base(service)
        {

        }

        [HttpGet]
        [AllowAnonymous]
        public override IEnumerable<Drzava> Get([FromQuery] object obj = null)
        {
            return base.Get(obj);
        }
    }
}
