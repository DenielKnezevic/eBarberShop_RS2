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

        public override Models.Rezervacija Insert(RezervacijaUpsertRequest request)
        {
            var entity = base.Insert(request);
            var termin = _db.Termins.Find(entity.TerminID);
            termin.IsBooked = true;
            entity.DatumRezervacije = DateTime.Now;
            _db.SaveChanges();
            return entity;
        }

        public override IQueryable<Rezervacija> AddInclude(IQueryable<Rezervacija> entity, RezervacijaSearchObject obj)
        {
            if(obj.IncludeTermin == true)
            {
                entity = entity.Include(x => x.Termin).ThenInclude(x => x.Korisnik);
            }

            if(obj.IncludeKorisnik == true)
            {
                entity = entity.Include(y => y.Korisnik);
            }

            if(obj.IncludeUsluga == true)
            {
                entity = entity.Include(y => y.Usluga);
            }

            return entity;
        }

        public override IQueryable<Rezervacija> AddFilter(IQueryable<Rezervacija> entity, RezervacijaSearchObject obj)
        {
            if(obj.DatumOd.HasValue)
            {
                entity = entity.Where(x => x.Termin.DatumTermina.Date >= obj.DatumOd);
            }

            if (obj.DatumDo.HasValue)
            {
                entity = entity.Where(x => x.Termin.DatumTermina.Date <= obj.DatumDo);
            }

            if (obj.KorisnikID.HasValue)
            {
                entity = entity.Where(x => x.KorisnikID == obj.KorisnikID);
            }

            if (obj.IsCanceled.HasValue)
            {
                entity = entity.Where(x => x.IsCanceled == obj.IsCanceled);
            }

            if (obj.IsArchived.HasValue)
            {
                entity = entity.Where(x =>x.IsArchived == obj.IsArchived);
            }

            return entity;
        }
    }
}
