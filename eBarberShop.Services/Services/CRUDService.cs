using AutoMapper;
using eBarberShop.Services.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBarberShop.Services.Services
{
    public class CRUDService<T, TDb, TSearch, TInsertRequest, TUpdateRequest> : BaseService<T, TDb, TSearch>,
        ICRUDService<T, TDb, TSearch, TInsertRequest, TUpdateRequest> where T : class where TDb : class where TSearch : class where TInsertRequest : class where TUpdateRequest : class
    {
        public CRUDService(eBarberShopContext db,IMapper mapper) : base(db,mapper)
        {

        }
        public T Insert(TInsertRequest request)
        {
            var set = _db.Set<TDb>();

            TDb entity = _mapper.Map<TDb>(request);

            set.Add(entity);

            _db.SaveChanges();

            return _mapper.Map<T>(entity);
        }

        public T Update(TUpdateRequest request, int id)
        {
            var entity = _db.Set<TDb>().Find(id);

            _mapper.Map(request, entity);

            _db.SaveChanges();

            return _mapper.Map<T>(entity);
        }
    }
}
