using OnlineShop.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Domain.Entity
{
    public class Color : BaseDomainEntity<int>
    { 
        public string Name { get;  set; }
        public string Code { get; set; }

        public  ICollection<Product> Products { get; set; }

        public Color()
        {
           Products = new List<Product>();
        }

        public Color(string name, string code)
        {
            this.Name = name;
            Code = code;
        }

        public void Edit(string name)
        {
            this.Name = name;
        }
    }
}
