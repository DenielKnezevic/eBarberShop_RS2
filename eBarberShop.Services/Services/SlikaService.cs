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
    public class SlikaService : CRUDService<Models.Slika , Slika , SlikaSearchObject , SlikaInsertRequest , SlikaUpdateRequest> , ISlikaService
    {
        public SlikaService(eBarberShopContext db , IMapper mapper):base(db , mapper)
        {

        }

        public override IQueryable<Slika> AddInclude(IQueryable<Slika> entity, SlikaSearchObject obj)
        {
            if(obj.IncludeKorisnik == true)
            {
                entity = entity.Include(x => x.Korisnik);
            }

            return entity;
        }
        public override IQueryable<Slika> AddFilter(IQueryable<Slika> entity, SlikaSearchObject obj)
        {
            if(obj.KorisnikID.HasValue)
            {
                entity = entity.Where(x => x.KorisnikID == obj.KorisnikID.Value);
            }

            return entity;
        }
    }
}
