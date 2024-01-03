using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OnlineShop.Infrastructure.Enums
{
    public enum PriceType : byte
    {
        [Display(Name = "ثابت")]
        Const,
        [Display(Name = "دلار")]
        Dollar
    }

}
