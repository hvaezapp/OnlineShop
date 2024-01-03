using OnlineShop.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Domain.Entity
{
    public class ProductAddOn : BaseDomainEntity<long>
    {
        public long ProductId { get; private set; }
        public virtual Product Product { get; private set; }

        public long AddOnId { get; private set; }
        public virtual AddOn AddOn { get; private set; }

        public ProductAddOn()
        {
            
        }

        public ProductAddOn(long productId , long addOnId)
        {
            ProductId = productId;
            AddOnId = addOnId;  
        }


        public void Edit(long productId, long addOnId)
        {
            ProductId = productId;
            AddOnId = addOnId;
        }
    }
}
