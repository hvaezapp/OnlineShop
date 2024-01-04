using AutoMapper;
using OnlineShop.Application.DTOs.City;
using OnlineShop.Application.DTOs.Color;
using OnlineShop.Domain.Entity;

namespace OnlineShop.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            #region Color Mapping

            CreateMap<Color, CreateColorDto>().ReverseMap();
            CreateMap<Color, GetColorDto>().ReverseMap();

            #endregion






        }
    }
}
