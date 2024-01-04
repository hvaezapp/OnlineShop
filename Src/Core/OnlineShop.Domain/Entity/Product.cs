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
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public PriceType PriceType { get; set; }
        public decimal? DiscountAmount { get; set; }
        public DateTime? DiscountExpireAt { get; set; }



       // public ICollection<Size> Sizes { get; set; }
       // public ICollection<Color> Colors { get; set; }
       // public ICollection<AddOn> AddOns { get; set; }



        public Product()
        {
            PriceType = PriceType.Const;

            //Sizes =  new List<Size>();
           // Colors = new List<Color>();
            //AddOns = new List<AddOn>();
        }

        public Product(string title, decimal price,
                    string imageUrl, PriceType priceType,
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
