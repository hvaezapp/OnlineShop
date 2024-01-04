using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnlineShop.Application.DTOs.Color;
using OnlineShop.Application.DTOs.Product;
using OnlineShop.Application.DTOs.Size;
using OnlineShop.Application.Features.Color.Requests.Commands;
using OnlineShop.Application.Features.Color.Requests.Queries;
using OnlineShop.Application.Features.Product.Requests.Commands;
using OnlineShop.Application.Features.Product.Requests.Queries;
using OnlineShop.Application.Features.Size.Requests.Commands;
using OnlineShop.Application.Features.Size.Requests.Queries;

namespace OnlineShop.Api.Controllers.v1
{
    public class ProductController : BaseController
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }


        //GET: api/<ProductController>
        [HttpGet("[action]")]
        public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
        {

            return Ok(await _mediator.Send(new GetProductListRequest(), cancellationToken));

        }



        // POST api/<ProductController>
        [HttpPost("[action]")]
        public async Task<IActionResult> Create(CreateProductDto dto, CancellationToken cancellationToken)
        {
            return Ok(await _mediator.Send(new CreateProductCommand { CreateProductDto = dto }, cancellationToken));

        }

    }
}
