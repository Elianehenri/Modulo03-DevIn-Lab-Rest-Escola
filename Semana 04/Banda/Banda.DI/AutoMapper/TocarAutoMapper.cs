using AutoMapper;
using Banda.Domain.DTOs;
using Banda.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banda.DI.AutoMapper
{
    public class TocarAutoMapper : Profile
    {
        public TocarAutoMapper()
        {
            CreateMap<Tocar, TocarDTO>()
                .ReverseMap();
        }
    }
}
