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
    public class TerminService : CRUDService<Models.Termin,Termin,TerminSearchObject,TerminUpsertRequest, TerminUpsertRequest> , ITerminService
    {
        public TerminService(eBarberShopContext db , IMapper mapper):base(db,mapper)
        {

        }

        public override void BeforeInsert(TerminUpsertRequest insert, Termin entity)
        {
            entity.DatumKreiranja = DateTime.Now;
        }

        public override IQueryable<Termin> AddInclude(IQueryable<Termin> entity, TerminSearchObject obj)
        {
            if(obj.IncludeKorisnik.HasValue)
            {
                entity = entity.Include(x => x.Korisnik);
            }

            return entity;
        }

        public override IQueryable<Termin> AddFilter(IQueryable<Termin> entity, TerminSearchObject obj)
        {
            if(obj.KorisnikID.HasValue)
            {
                entity = entity.Where(x => x.KorisnikID == obj.KorisnikID);
            }

            if (obj.Datum.HasValue)
            {
                entity = entity.Where(x => x.DatumTermina.Date == obj.Datum.Value);
            }

            if (obj.DatumOd.HasValue)
            {
                entity = entity.Where(x => x.DatumTermina.Date >= obj.DatumOd.Value);
            }

            if (obj.DatumDo.HasValue)
            {
                entity = entity.Where(x => x.DatumTermina.Date <= obj.DatumDo.Value);
            }

            if(obj.IsBooked.HasValue)
            {
                entity = entity.Where(x => x.IsBooked == obj.IsBooked);
            }

            return entity;
        }
    }
}
