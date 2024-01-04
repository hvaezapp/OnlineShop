using OnlineShop.Application.DTOs.City;
using OnlineShop.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Application.DTOs.Color
{
    public class GetColorDto : CreateColorDto ,  IBaseDto<int> 
    {
        public  int Id { get; set; }
    }
}
