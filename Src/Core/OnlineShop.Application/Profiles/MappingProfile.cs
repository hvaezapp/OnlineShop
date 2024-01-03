using AutoMapper;
using OnlineShop.Application.DTOs.City;
using OnlineShop.Domain.Entity;

namespace OnlineShop.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            #region Color Mapping

            CreateMap<Color, CreateColorDto>().ReverseMap();
         
            #endregion






        }
    }
}
