using OnlineShop.Domain.Common;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Domain.Entity
{
    public class ProductSize : BaseDomainEntity<long>
    {
        public long ProductId { get; private set; }
        public virtual Product Product { get; private set; }
        public int SizeId { get; private set; }
        public virtual Size Size { get; private set; }
        public decimal PriceDifference { get; private set; }
        public int Qty { get; private set; }


        public ProductSize()
        {

        }

        public ProductSize(long productId, int sizeId, decimal priceDifference, int qty)
        {
            ProductId = productId;
            SizeId = sizeId;
            PriceDifference = priceDifference;
            Qty = qty;
        }

        public void Edit(long productId, int sizeId, decimal priceDifference, int qty)
        {
            ProductId = productId;
            SizeId = sizeId;
            PriceDifference = priceDifference;
            Qty = qty;
        }
    }
}
