using AutoMapper;
using MediatR;
using Microsoft.Extensions.Caching.Memory;
using OnlineShop.Application.Contracts.Persistence;
using OnlineShop.Application.DTOs.Size;
using OnlineShop.Application.Features.Size.Requests.Queries;

namespace OnlineShop.Application.Features.Size.Handlers.Queries
{
    public class GetSizeListRequestHandler : IRequestHandler<GetSizeListRequest, List<GetSizeDto>>
    {
        private const string SizeListCacheKey = "SizeList";

        private readonly ISizeRepository _sizeRepository;
        private readonly IMapper _mapper;

        private readonly IMemoryCache _cache;

        public GetSizeListRequestHandler(ISizeRepository sizeRepository
            , IMapper mapper, IMemoryCache cache)
        {
            _sizeRepository = sizeRepository;
            _mapper = mapper;
            _cache = cache;
        }



        public async Task<List<GetSizeDto>> Handle(GetSizeListRequest request, CancellationToken cancellationToken)
        {

            try
            {


                if (_cache.TryGetValue(SizeListCacheKey, out IEnumerable<Domain.Entity.Size> sizes))
                {

                }
                else
                {


                    sizes = await _sizeRepository.GetAllAsync(cancellationToken);


                    _cache.Set(SizeListCacheKey, sizes, TimeSpan.FromSeconds(60));
                }

                return _mapper
                        .Map<List<GetSizeDto>>(sizes);

            }
            catch (Exception)
            {
                throw;

            }



        }
    }
}
