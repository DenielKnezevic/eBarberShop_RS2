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
    public class GradService : CRUDService<Models.Grad , Grad , object , GradUpsertRequest , GradUpsertRequest> , IGradService
    {
        public GradService(eBarberShopContext db , IMapper mapper):base(db , mapper)
        {

        }
    }
}
