using MediatR;
using OnlineShop.Application.DTOs.Size;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Application.Features.Size.Requests.Queries
{
    public class GetSizeListRequest : IRequest<List<GetSizeDto>>
    {
    }
}
