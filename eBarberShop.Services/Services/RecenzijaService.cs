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
    public class RecenzijaService : CRUDService<Models.Recenzija,Recenzija,object,RecenzijaInsertRequest,RecenzijaUpdateRequest> , IRecenzijaService
    {
        public RecenzijaService(eBarberShopContext db , IMapper mapper):base(db ,mapper)
        {

        }

        public override IQueryable<Recenzija> AddInclude(IQueryable<Recenzija> entity)
        {
            entity = entity.Include(x => x.Korisnik);

            return entity;
        }
    }
}
