﻿using eBarberShop.Services.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eBarberShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<T,TSearch> : ControllerBase where T : class where TSearch : class
    {
        public IBaseService<T, TSearch> _service;

        public BaseController(IBaseService<T,TSearch> service)
        {
            _service = service;
        }
        [HttpGet]
        public IEnumerable<T> Get([FromQuery]TSearch obj = null)
        {
            return _service.GetAll(obj);
        }

        [HttpGet("{id}")]
        public T GetById(int id)
        {
            return _service.GetById(id);
        }
    }
}