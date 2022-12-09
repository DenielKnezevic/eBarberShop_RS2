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
    public class ProizvodService : CRUDService<Models.Proizvod, Proizvod , ProizvodSearchObject, ProizvodInsertRequest , ProizvodUpdateRequest> , IProizvodService
    {
        public ProizvodService(eBarberShopContext db , IMapper mapper) : base(db , mapper)
        {

        }

        public override IQueryable<Proizvod> AddInclude(IQueryable<Proizvod> entity)
        {
            entity = entity.Include(x => x.VrstaProizvoda);

            return entity;
        }

        public override IQueryable<Proizvod> AddFilter(IQueryable<Proizvod> entity, ProizvodSearchObject obj)
        {
            if(obj.VrstaProizvodaID.HasValue)
            {
                entity = entity.Where(x => x.VrstaProizvodaID == obj.VrstaProizvodaID);
            }

            if(!string.IsNullOrWhiteSpace(obj.Naziv))
            {
                entity = entity.Where(x => x.Naziv.ToLower().StartsWith(obj.Naziv.ToLower()));
            }

            return entity;
        }
    }
}
