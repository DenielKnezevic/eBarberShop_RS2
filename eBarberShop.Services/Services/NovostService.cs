using AutoMapper;
using eBarberShop.Models.Requests;
using eBarberShop.Models.SearchObjects;
using eBarberShop.Services.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBarberShop.Services.Services
{
    public class NovostService : CRUDService<Models.Novost, Novost, NovostSearchObject , NovostInsertRequest , NovostUpdateRequest> , INovostService
    {
        public NovostService(eBarberShopContext db , IMapper mapper):base(db , mapper)
        {

        }
        public override IQueryable<Novost> AddInclude(IQueryable<Novost> entity)
        {
            entity = entity.Include(x => x.Korisnik);

            return entity;
        }

        public override IQueryable<Novost> AddFilter(IQueryable<Novost> entity, NovostSearchObject obj)
        {
            if(obj.KorisnikID.HasValue)
            {
                entity = entity.Where(x => x.KorisnikID == obj.KorisnikID.Value);
            }

            if(obj.DatumOd.HasValue)
            {
                entity = entity.Where(x => x.DatumKreiranja.Date >= obj.DatumOd.Value);
            }

            if(obj.DatumDo.HasValue)
            {
                entity = entity.Where(x => x.DatumKreiranja.Date <= obj.DatumDo.Value);
            }

            return entity;
        }
    }
}
