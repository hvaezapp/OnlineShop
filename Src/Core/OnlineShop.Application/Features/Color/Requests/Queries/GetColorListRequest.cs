using MediatR;
using OnlineShop.Application.DTOs.Color;

namespace OnlineShop.Application.Features.Color.Requests.Queries
{
    public class GetColorListRequest : IRequest<List<GetColorDto>>
    {

    }
}
