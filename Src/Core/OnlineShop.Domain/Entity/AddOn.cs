using OnlineShop.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Domain.Entity
{
    public class AddOn : BaseDomainEntity<int>
    {
        public string Name { get; set; }
        public decimal Price { get;  set; }

        //public ICollection<Product> Products { get; set; } 


        public AddOn()
        {
           // Products = new List<Product>();
        }

        public AddOn(string name , decimal price)
        {
            Name = name;
            Price = price;
        }


        public void Edit(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }
}
