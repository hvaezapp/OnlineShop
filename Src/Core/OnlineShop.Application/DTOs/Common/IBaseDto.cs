using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Application.DTOs.Common
{
    public interface IBaseDto<T>
    {
        public T Id { get; set; }
    }
}
