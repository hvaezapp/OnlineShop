using OnlineShop.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Domain.Entity
{
    public class ProductColor : BaseDomainEntity<long>
    {
        public long ProductId { get;     set; }
        public  Product Product { get; set; }
        public int ColorId { get; set; }
        public  Color Color { get; set; }
        public decimal PriceDifference { get;  set; }
        public int Qty { get;  set; }


        public ProductColor()
        {
            
        }

        public ProductColor(long productId , int colorId , decimal priceDifference , int qty)
        {
            ProductId = productId;
            ColorId = colorId;
            PriceDifference = priceDifference;
            Qty = qty;
        }

        public void Edit(long productId, int colorId, decimal priceDifference, int qty)
        {
            ProductId = productId;
            ColorId = colorId;
            PriceDifference = priceDifference;
            Qty = qty;
        }
    }
}
