﻿using AutoMapper;
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
            entity = entity.Include(x => x.Termin).Include(y => y.Termin); 

            return entity;
        }

        public override IQueryable<Rezervacija> AddFilter(IQueryable<Rezervacija> entity, RezervacijaSearchObject obj)
        {
            if(obj.DatumRezervacije.HasValue)
            {
                entity = entity.Where(x => x.DatumRezervacije.Date == obj.DatumRezervacije);
            }

            if(obj.KorisnikID.HasValue)
            {
                entity = entity.Where(x => x.KorisnikID == obj.KorisnikID);
            }

            return entity;
        }
    }
}
