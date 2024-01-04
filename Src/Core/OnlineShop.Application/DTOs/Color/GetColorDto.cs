using OnlineShop.Application.DTOs.Common;

namespace OnlineShop.Application.DTOs.Color
{
    public class GetColorDto : CreateColorDto, IBaseDto<int>
    {
        public int Id { get; set; }
    }
}
