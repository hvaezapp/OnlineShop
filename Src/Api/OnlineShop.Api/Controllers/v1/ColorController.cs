using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnlineShop.Application.DTOs.Color;
using OnlineShop.Application.Features.Color.Requests.Commands;
using OnlineShop.Application.Features.Color.Requests.Queries;

namespace OnlineShop.Api.Controllers.v1
{
    public class ColorController : BaseController
    {
        private readonly IMediator _mediator;

        public ColorController(IMediator mediator)
        {
            _mediator = mediator;
        }


        // GET: api/<ColorController>
        [HttpGet("[action]")]
        public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
        {

            return Ok(await _mediator.Send(new GetColorListRequest(), cancellationToken));

        }



        // POST api/<ColorController>
        [HttpPost("[action]")]
        public async Task<IActionResult> Create(CreateColorDto dto, CancellationToken cancellationToken)
        {
            return Ok(await _mediator.Send(new CreateColorCommand { CreateColorDto = dto }, cancellationToken));

        }

    }
}
