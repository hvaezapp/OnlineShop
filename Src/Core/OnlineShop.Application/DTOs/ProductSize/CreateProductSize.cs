using OnlineShop.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Application.DTOs.ProductSize
{
    public class CreateProductSizeDto
    {
        public int SizeId { get; set; }
        public decimal PriceDifference { get; set; }
        public int Qty { get; set; }
    }

    public class GetProductSizeDto : IBaseDto<long>
    {
        public long Id { get; set; }
        public int SizeId { get; set; }
        public string SizeName { get; set; }
        public decimal PriceDifference { get; set; }
        public int Qty { get; set; }

    }




}
