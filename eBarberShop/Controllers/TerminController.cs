using eBarberShop.Models.Requests;
using eBarberShop.Models.SearchObjects;
using eBarberShop.Services.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eBarberShop.Controllers
{
    public class TerminController : CRUDController<Models.Termin , TerminSearchObject , TerminUpsertRequest, TerminUpsertRequest>
    {
        public TerminController(ITerminService service):base(service)
        {

        }
    }
}
