using AutoMapper;
using eBarberShop.Models.Requests;
using eBarberShop.Services.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBarberShop.Services.Services
{
    public class SlikaService : CRUDService<Models.Slika , Slika , object , SlikaInsertRequest , SlikaUpdateRequest> , ISlikaService
    {
        public SlikaService(eBarberShopContext db , IMapper mapper):base(db , mapper)
        {

        }

        public override IQueryable<Slika> AddInclude(IQueryable<Slika> entity)
        {
            entity = entity.Include(x => x.Korisnik);

            return entity;
        }
    }
}
