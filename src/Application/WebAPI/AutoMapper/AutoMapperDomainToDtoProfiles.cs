using AutoMapper;

namespace WebAPI.AutoMapper
{
    public class AutoMapperDomainToDtoProfiles:Profile
    {
        public AutoMapperDomainToDtoProfiles()
        {
            //CreateMap<User, UserDto>();
        }

        public override string ProfileName {

            get { return "DomainToDto"; }

        }        
    }
}
