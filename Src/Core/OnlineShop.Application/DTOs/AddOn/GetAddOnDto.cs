using OnlineShop.Application.DTOs.Common;
using OnlineShop.Application.DTOs.Size;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Application.DTOs.AddOn
{
    public class GetAddOnDto : CreateAddOnDto , IBaseDto<int>
    {
        public int Id { get; set; }
    }
}
