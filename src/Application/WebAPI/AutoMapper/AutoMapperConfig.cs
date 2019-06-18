using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.AutoMapper
{
    public class AutoMapperConfig
    {
        [Obsolete]
        public static void RegisterMappings()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile<AutoMapperDomainToDtoProfiles>();
                x.AddProfile<AutoMapperDtoToDomainProfiles>();
            });
        }
    }
}
