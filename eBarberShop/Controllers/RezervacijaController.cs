using eBarberShop.Models.Requests;
using eBarberShop.Models.SearchObjects;
using eBarberShop.Services.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eBarberShop.Controllers
{
    public class RezervacijaController : CRUDController<Models.Rezervacija, RezervacijaSearchObject, RezervacijaUpsertRequest , RezervacijaUpsertRequest>
    {
        public RezervacijaController(IRezervacijaService service):base(service)
        {

        }
    }
}
