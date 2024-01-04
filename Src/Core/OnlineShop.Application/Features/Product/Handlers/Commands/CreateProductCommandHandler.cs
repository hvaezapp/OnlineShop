using MediatR;
using Microsoft.Extensions.Configuration;
using OnlineShop.Application.Contracts.Persistence;
using OnlineShop.Application.Contracts.Service;
using OnlineShop.Application.Features.Product.Requests.Commands;
using OnlineShop.Domain.Entity;
using OnlineShop.Infrastructure.Enums;
using OnlineShop.Infrastructure.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Application.Features.Product.Handlers.Commands
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, Unit>
    {
        private readonly IProductRepository _productRepository;
        private readonly IProductSizeRepository _productSizeRepository;
        private readonly IProductColorRepository _productColorRepository;
        private readonly IProductAddOnRepository _productAddOnRepository;
        private readonly ISaveImage _saveImage;
        private readonly IConfiguration _configuration;


        public CreateProductCommandHandler(IProductRepository productRepository,
                                  IProductSizeRepository productSizeRepository,
                                  IProductColorRepository productColorRepository,
                                  IProductAddOnRepository productAddOnRepository,
                                  ISaveImage saveImage,
                                  IConfiguration configuration)
        {
            _productRepository = productRepository;
            _productSizeRepository = productSizeRepository;
            _productColorRepository = productColorRepository;
            _productAddOnRepository = productAddOnRepository;
            _saveImage = saveImage;
            _configuration = configuration;
        }

        public async Task<Unit> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            try
            {
                // save product image in host
                string imageName = await _saveImage
                                         .Save(request.CreateProductDto.Image);

                //create product

                var product = new Domain.Entity.Product
                {
                    Title = request.CreateProductDto.Title,
                    ImageUrl = imageName,
                    Price = request.CreateProductDto.PriceType == PriceType.FORMULA ?
                                (request.CreateProductDto.Price * (_configuration.GetSection("Dollar").Value.ToDecimal()))
                                : request.CreateProductDto.Price,
                    PriceType = request.CreateProductDto.PriceType,
                    DiscountAmount = request.CreateProductDto.DiscountAmount,
                    DiscountExpireAt = request.CreateProductDto.DiscountExpireAt,
                    
                };

                await _productRepository.Create(product, cancellationToken);
                await _productRepository.SaveChanges(cancellationToken);


                // add product color 
                if (request.CreateProductDto.ProductColors.Any())
                {
                    foreach (var item in request.CreateProductDto.ProductColors)
                    {
                        await _productColorRepository.Create(new ProductColor
                        {
                            ProductId = product.Id,
                            ColorId = item.ColorId,
                            PriceDifference = item.PriceDifference,
                            Qty = item.Qty,

                        }, cancellationToken);


                    }

                    await _productRepository.SaveChanges(cancellationToken);


                }

                // add product size
                if (request.CreateProductDto.ProductSizes.Any())
                {
                    foreach (var item in request.CreateProductDto.ProductSizes)
                    {
                        await _productSizeRepository.Create(new ProductSize
                        {
                            ProductId = product.Id,
                            SizeId = item.SizeId,
                            PriceDifference = item.PriceDifference,
                            Qty = item.Qty,

                        }, cancellationToken);


                    }

                    await _productRepository.SaveChanges(cancellationToken);
                }


                // add product addOn
                if (request.CreateProductDto.ProductAddOns.Any())
                {
                    foreach (var item in request.CreateProductDto.ProductAddOns)
                    {
                        await _productAddOnRepository.Create(new ProductAddOn
                        {
                           ProductId = product.Id,
                           AddOnId = item

                        }, cancellationToken);


                    }

                    await _productRepository.SaveChanges(cancellationToken);
                }


                return Unit.Value;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
