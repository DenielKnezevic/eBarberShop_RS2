using eBarberShop.Models;
using eBarberShop.Models.Requests;
using eBarberShop.Services.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eBarberShop.Controllers
{
    public class GradController : CRUDController<Models.Grad , object , GradUpsertRequest , GradUpsertRequest>
    {
        public GradController(IGradService service):base(service)
        {

        }
        
        [HttpGet]
        [AllowAnonymous]
        public override IEnumerable<Grad> Get([FromQuery] object obj = null)
        {
            return base.Get(obj);
        }
    }
}
