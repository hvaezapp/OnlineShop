using AutoMapper;
using OnlineShop.Application.DTOs.AddOn;
using OnlineShop.Application.DTOs.Color;
using OnlineShop.Application.DTOs.Size;
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



            #region Size Mapping

            CreateMap<Size, CreateSizeDto>().ReverseMap();
            CreateMap<Size, GetSizeDto>().ReverseMap();

            #endregion



            #region AddOn Mapping

            CreateMap<AddOn, CreateAddOnDto>().ReverseMap();
            CreateMap<AddOn, GetAddOnDto>().ReverseMap();

            #endregion






        }
    }
}
