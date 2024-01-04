using MediatR;
using OnlineShop.Application.DTOs.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Application.Features.Product.Requests.Commands
{
    public class CreateProductCommand : IRequest<Unit>
    {
        public CreateProductDto CreateProductDto { get; set; }
    }
}
