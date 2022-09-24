using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banda.DI.AutoMapper
{
    public class AutoMapperConfig
    {
        public static IMapper Configure()
        {
            var ConfigMap = new MapperConfiguration(config =>
            {
                config.AddProfile(new TocarAutoMapper());
            });

            return ConfigMap.CreateMapper();

        }
    }
}
