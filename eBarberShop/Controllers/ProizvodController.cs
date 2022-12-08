using eBarberShop.Models.Requests;
using eBarberShop.Models.SearchObjects;
using eBarberShop.Services.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eBarberShop.Controllers
{
    public class ProizvodController : CRUDController<Models.Proizvod , ProizvodSearchObject , ProizvodInsertRequest, ProizvodUpdateRequest>
    {
        public ProizvodController(IProizvodService service ):base(service)
        {

        }
    }
}
