using OnlineShop.Application.DTOs.Common;

namespace OnlineShop.Application.DTOs.Size
{
    public class GetSizeDto : CreateSizeDto, IBaseDto<int>
    {
        public int Id { get; set; }
    }
}
