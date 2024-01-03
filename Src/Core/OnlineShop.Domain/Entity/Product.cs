using OnlineShop.Domain.Common;
using OnlineShop.Infrastructure.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Domain.Entity
{
    public class Product : BaseDomainEntity<long>
    {
        public string Title { get;  private set; }
        public decimal Price { get; private set; }
        public string ImageUrl { get; private set; }
        public PriceType PriceType { get; private set; }
        public decimal? DiscountAmount { get; private set; }
        public DateTime? DiscountExpireAt { get; private set; }



        public virtual ICollection<Size> Sizes { get; set; } 
        public virtual ICollection<Color> Colors { get; set; }
        public virtual ICollection<AddOn> AddOns { get; set; }



        public Product()
        {
            PriceType = PriceType.Const;

            Sizes = new List<Size>();
            Colors = new List<Color>();
            AddOns = new List<AddOn>();
        }

        public Product(string title , decimal price ,
                    string imageUrl , PriceType priceType,
                    decimal? discountAmount, DateTime? discountExpireAt)
        {

            Title = title;
            Price = price;
            ImageUrl = imageUrl;
            PriceType = priceType;
            DiscountAmount = discountAmount;
            DiscountExpireAt = discountExpireAt;

        }


    }

   
}
