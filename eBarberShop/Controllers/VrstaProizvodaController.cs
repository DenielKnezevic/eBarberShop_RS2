using eBarberShop.Models.Requests;
using eBarberShop.Services.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eBarberShop.Controllers
{
    public class VrstaProizvodaController : CRUDController<Models.VrstaProizvoda, object , VrstaProizvodaUpsertRequest , VrstaProizvodaUpsertRequest>
    {
        public VrstaProizvodaController(IVrstaProizvodaService service):base(service)
        {

        }
    }
}
