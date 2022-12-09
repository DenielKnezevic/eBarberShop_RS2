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
    public class NarudzbaService : CRUDService<Models.Narudzba , Narudzba , NarudzbaSearchObject, NarudzbaInsertRequest , NarudzbaUpdateRequest> , INarudzbaService
    {
        public NarudzbaService(eBarberShopContext db , IMapper mapper):base(db , mapper)
        {

        }

        public override Models.Narudzba Insert(NarudzbaInsertRequest request)
        {
            var entity = base.Insert(request);

            foreach (var proizvod in request.ProizvodiID)
            {
                Database.NarudzbaProizvodi Proizvod = new Database.NarudzbaProizvodi();

                Proizvod.ProizvodID = proizvod;
                Proizvod.NarudzbaID = entity.NarudzbaID;

                _db.Add(Proizvod);
            }

            _db.SaveChanges();

            return entity;
        }

        public override IQueryable<Narudzba> AddInclude(IQueryable<Narudzba> entity)
        {
            entity = entity.Include(x => x.Korisnik).Include(x => x.NarudzbaProizvodis).ThenInclude(x => x.Proizvod).ThenInclude(x => x.VrstaProizvoda);

            return entity;
        }

        public override IQueryable<Narudzba> AddFilter(IQueryable<Narudzba> entity, NarudzbaSearchObject obj)
        {
            if(!string.IsNullOrWhiteSpace(obj.BrojNarudzbe))
            {
                entity = entity.Where(x => x.BrojNarudzbe.StartsWith(obj.BrojNarudzbe));
            }

            if(obj.KorisnikID.HasValue)
            {
                entity = entity.Where(x => x.KorisnikID == obj.KorisnikID);
            }

            if(obj.DatumNarudzbe.HasValue)
            {
                entity = entity.Where(x => x.DatumNarudzbe.Date == obj.DatumNarudzbe);
            }

            return entity;
        }
    }
}
