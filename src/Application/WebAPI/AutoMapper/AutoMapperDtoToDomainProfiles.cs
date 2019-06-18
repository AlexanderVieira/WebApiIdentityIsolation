using AutoMapper;

namespace WebAPI.AutoMapper
{
    public class AutoMapperDtoToDomainProfiles:Profile
    {
        public AutoMapperDtoToDomainProfiles()
        {
            //CreateMap<UserDto, User>();
        }

        public override string ProfileName {

            get { return "DtoToDomain"; }

        }
    }
}
