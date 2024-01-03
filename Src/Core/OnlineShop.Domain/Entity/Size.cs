using OnlineShop.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Domain.Entity
{
    public class Size : BaseDomainEntity<int>
    { 
        public string Name { get;  private set; }

        public virtual ICollection<Product> Products { get; set; }

        public Size()
        {
            Products = new List<Product>();
        }

        public Size(string name)
        {
            this.Name = name;
        }

        public void Edit(string name)
        {
            this.Name = name;
        }
    }
}
