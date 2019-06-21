using AutoMapper;
using Infra.Identity.Core.Models;
using WebAPI.Dtos;

namespace WebAPI.AutoMapper
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<ApplicationUser, UserDto>();
        }
        
    }
}
