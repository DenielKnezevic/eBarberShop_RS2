using AutoMapper;
using eBarberShop.Models.Requests;
using eBarberShop.Models.SearchObjects;
using eBarberShop.Services.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBarberShop.Services.Services
{
    public class UplataService : CRUDService<Models.Uplata , Uplata , UplataSearchObject , UplataUpsertRequest , UplataUpsertRequest> , IUplataService
    {
        public UplataService(eBarberShopContext db , IMapper mapper):base(db,mapper)
        {

        }

        public override void BeforeInsert(UplataUpsertRequest insert, Uplata entity)
        {
            entity.DatumTransakcije = DateTime.Now;
        }

    }
}
