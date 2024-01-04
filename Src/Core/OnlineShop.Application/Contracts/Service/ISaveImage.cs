using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Application.Contracts.Service
{
    public interface ISaveImage
    {
        Task<string> Save(string image);

    }
}
