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
        public long ProductId { get;  set; }
        public  Product Product { get;  set; }
        public int SizeId { get;  set; }
        public Size Size { get;  set; }
        public decimal PriceDifference { get;  set; }
        public int Qty { get;  set; }


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
