using MediatR;
using OnlineShop.Application.DTOs.Color;

namespace OnlineShop.Application.Features.Color.Requests.Commands
{
    public class CreateColorCommand : IRequest<Unit>
    {
        public CreateColorDto CreateColorDto { get; set; }
    }
}
