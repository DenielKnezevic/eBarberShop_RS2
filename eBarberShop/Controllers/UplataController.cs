using eBarberShop.Models.Requests;
using eBarberShop.Models.SearchObjects;
using eBarberShop.Services.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eBarberShop.Controllers
{
    public class UplataController : CRUDController<Models.Uplata, UplataSearchObject , UplataUpsertRequest , UplataUpsertRequest>
    {
        public UplataController(IUplataService service):base(service)
        {

        }
    }
}
