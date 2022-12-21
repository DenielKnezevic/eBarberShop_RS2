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
    public class RezervacijaService : CRUDService<Models.Rezervacija, Rezervacija, RezervacijaSearchObject, RezervacijaUpsertRequest , RezervacijaUpsertRequest> , IRezervacijaService
    {
        public RezervacijaService(eBarberShopContext db , IMapper mapper):base(db,mapper)
        {

        }

        public override IQueryable<Rezervacija> AddInclude(IQueryable<Rezervacija> entity)
        {
            entity = entity.Include(x => x.Termin).Include(y => y.Korisnik); 

            return entity;
        }

        public override IQueryable<Rezervacija> AddFilter(IQueryable<Rezervacija> entity, RezervacijaSearchObject obj)
        {
            if(obj.DatumOd.HasValue && obj.DatumDo.HasValue)
            {
                entity = entity.Where(x => x.Termin.DatumTermina.Date >= obj.DatumOd && x.Termin.DatumTermina.Date <= obj.DatumDo);
            }

            if(obj.KorisnikID.HasValue)
            {
                entity = entity.Where(x => x.KorisnikID == obj.KorisnikID);
            }

            if(obj.IsArchived == true)
            {
                entity = entity.Where(x =>x.IsArchived == obj.IsArchived);
            }

            if (obj.IsArchived == false)
            {
                entity = entity.Where(x => x.IsArchived == obj.IsArchived);
            }

            return entity;
        }
    }
}
