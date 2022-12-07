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
    public class NovostService : CRUDService<Models.Novost, Novost, object , NovostInsertRequest , NovostUpdateRequest> , INovostService
    {
        public NovostService(eBarberShopContext db , IMapper mapper):base(db , mapper)
        {

        }
    }
}
