using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnlineShop.Application.DTOs.Color;
using OnlineShop.Application.DTOs.Size;
using OnlineShop.Application.Features.Color.Requests.Commands;
using OnlineShop.Application.Features.Color.Requests.Queries;
using OnlineShop.Application.Features.Size.Requests.Commands;
using OnlineShop.Application.Features.Size.Requests.Queries;

namespace OnlineShop.Api.Controllers.v1
{
    public class SizeController : BaseController
    {
        private readonly IMediator _mediator;

        public SizeController(IMediator mediator)
        {
            _mediator = mediator;
        }


        // GET: api/<SizeController>
        [HttpGet("[action]")]
        public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
        {

            return Ok(await _mediator.Send(new GetSizeListRequest(), cancellationToken));

        }



        // POST api/<SizeController>
        [HttpPost("[action]")]
        public async Task<IActionResult> Create(CreateSizeDto dto, CancellationToken cancellationToken)
        {
            return Ok(await _mediator.Send(new CreateSizeCommand { CreateSizeDto = dto }, cancellationToken));

        }

    }
}
