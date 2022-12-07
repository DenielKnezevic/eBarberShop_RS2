using AutoMapper;
using eBarberShop.Models.Requests;
using eBarberShop.Services.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBarberShop.Services.Services
{
    public class UlogaService : CRUDService<Models.Uloga, Uloga , object , UlogaUpsertRequest , UlogaUpsertRequest> , IUlogaService
    {
        public UlogaService(eBarberShopContext db , IMapper mapper):base(db,mapper)
        {

        }
    }
}
