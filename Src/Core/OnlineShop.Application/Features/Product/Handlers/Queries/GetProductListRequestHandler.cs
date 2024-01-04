using MediatR;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using OnlineShop.Application.Contracts.Persistence;
using OnlineShop.Application.Contracts.Service;
using OnlineShop.Application.DTOs.Product;
using OnlineShop.Application.DTOs.ProductAddOn;
using OnlineShop.Application.DTOs.ProductColor;
using OnlineShop.Application.DTOs.ProductSize;
using OnlineShop.Application.Features.Product.Requests.Queries;
using OnlineShop.Domain.Entity;

namespace OnlineShop.Application.Features.Product.Handlers.Queries
{
    public class GetProductListRequestHandler : IRequestHandler<GetProductListRequest, List<GetProductDto>>
    {
        private readonly IProductRepository _productRepository;

        private readonly IProductSizeRepository _productSizeRepository;
        private readonly IProductColorRepository _productColorRepository;
        private readonly IProductAddOnRepository _productAddOnRepository;

        public GetProductListRequestHandler(IProductRepository productRepository,
                                  IProductSizeRepository productSizeRepository,
                                  IProductColorRepository productColorRepository,
                                  IProductAddOnRepository productAddOnRepository)

        {
            _productRepository = productRepository;
            _productSizeRepository = productSizeRepository;
            _productColorRepository = productColorRepository;
            _productAddOnRepository = productAddOnRepository;
          
        }

        public async Task<List<GetProductDto>> Handle(GetProductListRequest request, CancellationToken cancellationToken)
        {
            var res = new List<GetProductDto>();

            try
            {

                var products =  await _productRepository
                               .GetAllAsync(a=>true,
                                s=>s.OrderByDescending(s=>s.Price),
                                cancellationToken);


                foreach (var product in products)
                {

                    var getProductColorDtos = new List<GetProductColorDto>();
                    var getProductSizeDtos = new List<GetProductSizeDto>();
                    var getProductAddOnDtos = new List<GetProductAddOnDto>();


                    var productColors = await _productColorRepository
                                               .GetAllAsync(a => a.ProductId == product.Id,
                                                "Color",
                                                cancellationToken);

                    foreach( var productColor in productColors)
                    {
                        getProductColorDtos.Add(new GetProductColorDto
                        {
                            ColorId = productColor.ColorId,
                            ColorName = productColor.Color.Name,
                            Id = productColor.Id,
                            ColorCode = productColor.Color.Code,
                            PriceDifference = productColor.PriceDifference,
                            Qty = productColor.Qty,
                            
                        });
                    }


                    var productSizes = await _productSizeRepository
                                          .GetAllAsync(a => a.ProductId == product.Id,
                                           "Size",
                                           cancellationToken);


                    foreach (var productSize in productSizes)
                    {
                        getProductSizeDtos.Add(new GetProductSizeDto
                        {
                           SizeName = productSize.Size.Name,
                           Id = productSize.Id,
                           PriceDifference= productSize.PriceDifference,
                           Qty= productSize.Qty,
                           SizeId = productSize.SizeId

                        });
                    }



                    var productAddOns = await _productAddOnRepository
                                          .GetAllAsync(a => a.ProductId == product.Id,
                                          "AddOn",
                                          cancellationToken);


                    foreach (var productAddOn in productAddOns)
                    {
                        getProductAddOnDtos.Add(new GetProductAddOnDto
                        {
                            Id = productAddOn.Id,
                            AddOnId = productAddOn.AddOnId,
                            Name = productAddOn.AddOn.Name,
                            Price = productAddOn.AddOn.Price,
                            
                        });
                    }



                    res.Add(new GetProductDto
                    {

                        Id = product.Id,
                        Title  = product.Title,
                        DiscountAmount = product.DiscountAmount,
                        DiscountExpireAt = product.DiscountExpireAt,
                        Image = product.ImageUrl,
                        Price = product.Price,
                        PriceType = product.PriceType,
                        ProductAddOns = getProductAddOnDtos,
                        ProductColors = getProductColorDtos,
                        ProductSizes = getProductSizeDtos
                        
                    });;


                }


                return res;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
