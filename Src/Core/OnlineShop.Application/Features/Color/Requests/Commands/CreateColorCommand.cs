using MediatR;
using OnlineShop.Application.DTOs.City;

namespace OnlineShop.Application.Features.Color.Requests.Commands
{
    public class CreateColorCommand : IRequest<Unit>
    {
        public CreateColorDto CreateColorDto { get; set; }
    }
}
