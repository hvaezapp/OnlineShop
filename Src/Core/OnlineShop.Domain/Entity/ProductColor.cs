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
        public long ProductId { get; private set; }
        public virtual Product Product { get; private set; }
        public int ColorId { get; private set; }
        public virtual Color Color { get; private set; }
        public decimal PriceDifference { get; private set; }
        public int Qty { get; private set; }


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
