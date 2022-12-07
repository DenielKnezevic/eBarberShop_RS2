using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eBarberShop.Models;
using eBarberShop.Models.Requests;

namespace eBarberShop.Services.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Database.Drzava, Drzava>();

            CreateMap<DrzavaUpsertRequest, Database.Drzava>();
        }
    }
}
