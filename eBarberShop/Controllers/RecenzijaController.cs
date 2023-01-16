using eBarberShop.Models.Requests;
using eBarberShop.Models.SearchObjects;
using eBarberShop.Services.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eBarberShop.Controllers
{
    public class RecenzijaController : CRUDController<Models.Recenzija, RecenzijeSearchObject, RecenzijaInsertRequest,RecenzijaUpdateRequest>
    {
        public RecenzijaController(IRecenzijaService service):base(service)
        {

        }
    }
}
