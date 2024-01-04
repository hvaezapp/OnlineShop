using OnlineShop.Application.DTOs.Common;
using OnlineShop.Application.DTOs.ProductAddOn;
using OnlineShop.Application.DTOs.ProductColor;
using OnlineShop.Application.DTOs.ProductSize;
using OnlineShop.Infrastructure.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Application.DTOs.Product
{
    public class GetProductDto : IBaseDto<long>
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        public PriceType PriceType { get; set; }
        public decimal? DiscountAmount { get; set; }
        public DateTime? DiscountExpireAt { get; set; }


        public List<GetProductSizeDto> ProductSizes { get; set; } = new();
        public List<GetProductColorDto> ProductColors { get; set; } = new();
        public List<GetProductAddOnDto> ProductAddOns { get; set; } = new();




     

    }
}
