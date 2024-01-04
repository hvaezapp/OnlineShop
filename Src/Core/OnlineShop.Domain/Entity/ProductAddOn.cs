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
        public long ProductId { get;     set; }
        public  Product Product { get; set; }

        public  int AddOnId { get; set; }
        public  AddOn AddOn { get;   set; }


        public ProductAddOn()
        {
            
        }

        public ProductAddOn(long productId , int addOnId)
        {
            ProductId = productId;
            AddOnId = addOnId;  
        }


        public void Edit(long productId, int addOnId)
        {
            ProductId = productId;
            AddOnId = addOnId;
        }
    }
}
