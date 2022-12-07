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
    public class DrzavaService : CRUDService<Models.Drzava, Drzava , object , DrzavaUpsertRequest , DrzavaUpsertRequest> , IDrzavaService
    {
        public DrzavaService(eBarberShopContext context, IMapper mapper):base(context,mapper)
        {

        }
    }
}
