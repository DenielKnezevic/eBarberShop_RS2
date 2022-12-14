using eBarberShop.Models;
using eBarberShop.Models.Requests;
using eBarberShop.Models.SearchObjects;
using eBarberShop.Services.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace eBarberShop.Controllers
{
    public class KorisnikController : CRUDController<Models.Korisnik, KorisnikSearchObject, KorisnikInsertRequest, KorisnikUpdateRequest>
    {
        public KorisnikController(IKorisnikService service):base(service)
        {

        }

        [AllowAnonymous]
        public override Korisnik Insert([FromBody] KorisnikInsertRequest request)
        {
            return base.Insert(request);
        }
        [HttpPut("{id}/AddUloga")]
        [Authorize(Roles = "Administrator")]
        public Korisnik AddUloga(int id, [FromBody]KorisnikUpdateRequest request)
        {
            return ((IKorisnikService)_service).AddUloga(id,request);
        }
        [HttpPut("{id}/DeleteUloga")]
        [Authorize(Roles = "Administrator")]
        public Korisnik DeleteUloga(int id, [FromBody] KorisnikUpdateRequest request)
        {
            return ((IKorisnikService)_service).DeleteUloga(id, request);
        }

        [HttpGet("Authenticate")]
        [AllowAnonymous]
        public Korisnik Authenticate()
        {
            string authorization = HttpContext.Request.Headers["Authorization"];

            string encodedHeader = authorization["Basic ".Length..].Trim();

            Encoding encoding = Encoding.GetEncoding("iso-8859-1");
            string usernamePassword = encoding.GetString(Convert.FromBase64String(encodedHeader));

            int seperatorIndex = usernamePassword.IndexOf(':');

            return ((IKorisnikService)_service).Login(usernamePassword.Substring(0, seperatorIndex), usernamePassword[(seperatorIndex + 1)..]);
        }
    }
}
