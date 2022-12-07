using eBarberShop.Models.Requests;
using eBarberShop.Services.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eBarberShop.Controllers
{
    public class UlogaController : CRUDController<Models.Uloga , object , UlogaUpsertRequest , UlogaUpsertRequest>
    {
        public UlogaController(IUlogaService service):base(service)
        {

        }
    }
}
