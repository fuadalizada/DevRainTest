using AutoMapper;
using DevRainTest.Business.DTOs;
using DevRainTest.WebApi.Models;

namespace DevRainTest.WebApi.MapConfiguration
{
    public class MapConfig : Profile
    {
        public MapConfig()
        {
            AllowNullCollections = true;
            AllowNullDestinationValues = true;

            CreateMap<FilterViewModel, FilterViewModelDto>().ReverseMap();
        }
    }
}
