using AutoMapper;
using MediatR;
using Microsoft.Extensions.Caching.Memory;
using OnlineShop.Application.Contracts.Persistence;
using OnlineShop.Application.DTOs.AddOn;
using OnlineShop.Application.DTOs.Color;
using OnlineShop.Application.Features.AddOn.Requests.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Application.Features.AddOn.Handlers.Queries
{
    public class GetAddOnListRequestHandler : IRequestHandler<GetAddOnListRequest, List<GetAddOnDto>>
    {
        private const string AddOnListCacheKey = "AddOnList";

        private readonly IAddOnRepository _addOnRepository;
        private readonly IMapper _mapper;

        private readonly IMemoryCache _cache;

        public GetAddOnListRequestHandler(IAddOnRepository addOnRepository
            , IMapper mapper, IMemoryCache cache)
        {
            _addOnRepository = addOnRepository;
            _mapper = mapper;
            _cache = cache;
        }


        public async Task<List<GetAddOnDto>> Handle(GetAddOnListRequest request, CancellationToken cancellationToken)
        {

            try
            {


                if (_cache.TryGetValue(AddOnListCacheKey, out IEnumerable<Domain.Entity.AddOn> addons))
                {

                }
                else
                {


                    addons = await _addOnRepository.GetAllAsync(cancellationToken);


                    _cache.Set(AddOnListCacheKey, addons, TimeSpan.FromSeconds(60));
                }

                return _mapper.Map<List<GetAddOnDto>>(addons);

            }
            catch (Exception)
            {
                throw;

            }
        }
    }
}
