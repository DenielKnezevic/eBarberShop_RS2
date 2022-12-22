using eBarberShop.Models.Requests;
using eBarberShop.Models.SearchObjects;
using eBarberShop.Services.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eBarberShop.Controllers
{
    public class NovostController : CRUDController<Models.Novost , NovostSearchObject , NovostInsertRequest , NovostUpdateRequest>
    {
        public NovostController(INovostService service):base(service)
        {

        }
    }
}
