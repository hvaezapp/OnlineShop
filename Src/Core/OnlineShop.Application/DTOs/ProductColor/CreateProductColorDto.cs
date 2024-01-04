using OnlineShop.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Application.DTOs.ProductColor
{
    public class CreateProductColorDto
    {
        public int ColorId { get; set; }
        public decimal PriceDifference { get; set; }
        public int Qty { get; set; }
    }
    public class GetProductColorDto : IBaseDto<long>
    {
        public long Id { get; set; }
        public int ColorId { get; set; }
        public string ColorName { get; set; }
        public string ColorCode { get; set; }
        public decimal PriceDifference { get; set; }
        public int Qty { get; set; }

    }
}
