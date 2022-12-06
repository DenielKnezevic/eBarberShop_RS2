﻿using AutoMapper;
using eBarberShop.Services.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBarberShop.Services.Services
{
    public class BaseService<T, TDb, TSearch> : IBaseService<T, TDb, TSearch> where T : class where TDb : class where TSearch : class
    {
        public eBarberShopContext _db;
        public IMapper _mapper;
        public BaseService(eBarberShopContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public IEnumerable<T> GetAll(TSearch obj)
        {
            var entity = _db.Set<TDb>().AsQueryable();

            entity = AddFilter(entity,obj);

            entity = AddInclude(entity);

            return _mapper.Map<IEnumerable<T>>(entity); 
        }

        public T GetById(int id)
        {
            var entity = _db.Set<TDb>().Find(id);

            return _mapper.Map<T>(entity);
        }


        public virtual IQueryable<TDb> AddFilter(IQueryable<TDb> entity, TSearch obj)
        {
            return entity;
        }

        public virtual IQueryable<TDb> AddInclude(IQueryable<TDb> entity)
        {
            return entity;
        }
    }
}