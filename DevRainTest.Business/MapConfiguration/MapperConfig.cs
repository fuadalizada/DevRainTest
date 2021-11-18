using AutoMapper;
using DevRainTest.Business.DTOs;
using DevRainTest.Domain.Entities;

namespace DevRainTest.Business.MapConfiguration
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            AllowNullCollections = true;
            AllowNullDestinationValues = true;

            CreateMap<UserDto,User>().ReverseMap();
            CreateMap<UserLoginAttemptDto,UserLoginAttempt>().ReverseMap();
        }
    }
}
