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
    public class NarudzbaService : CRUDService<Models.Narudzba , Narudzba , object , NarudzbaInsertRequest , NarudzbaUpdateRequest> , INarudzbaService
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
    }
}
