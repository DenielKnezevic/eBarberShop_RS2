using eBarberShop.Models.Requests;
using eBarberShop.Services.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eBarberShop.Controllers
{
    public class RecenzijaController : CRUDController<Models.Recenzija,object,RecenzijaInsertRequest,RecenzijaUpdateRequest>
    {
        public RecenzijaController(IRecenzijaService service):base(service)
        {

        }
    }
}
