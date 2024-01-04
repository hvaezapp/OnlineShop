using MediatR;
using OnlineShop.Application.DTOs.AddOn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Application.Features.AddOn.Requests.Commands
{
    public class CreateAddOnCommand : IRequest<Unit>
    {
        public CreateAddOnDto CreateAddOnDto { get; set; }
    }
}
