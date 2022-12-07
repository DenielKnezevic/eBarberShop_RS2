using eBarberShop.Models.Requests;
using eBarberShop.Services.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eBarberShop.Controllers
{
    public class UslugaController : CRUDController<Models.Usluga , object , UslugaUpsertRequest, UslugaUpsertRequest>
    {
        public UslugaController(IUslugaService service):base(service)
        {

        }
    }
}
