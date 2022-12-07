using eBarberShop.Models.Requests;
using eBarberShop.Services.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eBarberShop.Controllers
{
    public class NarudzbaController : CRUDController<Models.Narudzba , object , NarudzbaInsertRequest , NarudzbaUpdateRequest>
    {
        public NarudzbaController(INarudzbaService service):base(service)
        {

        }
    }
}
