using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBarberShop.Services.Services
{
    public interface ICRUDService<T,TDb,TSearch,TInsertRequest,TUpdateRequest> : IBaseService<T,TDb,TSearch>
    {
        T Insert(TInsertRequest request);
        T Update(TUpdateRequest request, int id);
    }
}
