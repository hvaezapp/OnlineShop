using AutoMapper;
using MediatR;
using Microsoft.Extensions.Caching.Memory;
using OnlineShop.Application.Contracts.Persistence;
using OnlineShop.Application.DTOs.Color;
using OnlineShop.Application.Features.Color.Requests.Queries;
using OnlineShop.Application.Responses;

namespace OnlineShop.Application.Features.Color.Handlers.Queries
{


    public class GetColorListRequestHandler : IRequestHandler<GetColorListRequest, List<GetColorDto>>
    {
        private const string ColorListCacheKey = "ColorList";

        private readonly IColorRepository _colorRepository;
        private readonly IMapper _mapper;

        private readonly IMemoryCache _cache;

        public GetColorListRequestHandler(IColorRepository colorRepository
            , IMapper mapper, IMemoryCache cache)
        {
            _colorRepository = colorRepository;
            _mapper = mapper;
            _cache = cache;
        }



        public async Task<List<GetColorDto>> Handle(GetColorListRequest request, CancellationToken cancellationToken)
        {
            var response = new BaseCommandResponse();

            try
            {


                if (_cache.TryGetValue(ColorListCacheKey, out IEnumerable<Domain.Entity.Color> colors))
                {

                }
                else
                {


                    colors = await _colorRepository.GetAllAsync(cancellationToken);


                    _cache.Set(ColorListCacheKey, colors, TimeSpan.FromSeconds(60));
                }

                return _mapper.Map<List<GetColorDto>>(colors);

            }
            catch (Exception)
            {
                throw;

            }







        }
    }
}
