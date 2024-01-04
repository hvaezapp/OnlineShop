using OnlineShop.Infrastructure.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Application.DTOs.Product
{
    public class CreateProductDto
    {
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        public PriceType PriceType { get; set; }
        public decimal? DiscountAmount { get; set; }
        public DateTime? DiscountExpireAt { get; set; }



        public List<ProductSizeDto> ProductSizes { get; set; } = new();
        public List<ProductColorDto> ProductColors { get; set; } = new();
        public List<int> ProductAddOns { get; set; } = new();


    }

    public class ProductSizeDto
    {
        public int SizeId { get; set; }
        public decimal PriceDifference { get; set; }
        public int Qty { get; set; }
    }

    public class ProductColorDto
    {
        public int ColorId { get; set; }
        public decimal PriceDifference { get; set; }
        public int Qty { get; set; }
    }


    
}
