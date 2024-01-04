using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnlineShop.Application.DTOs.AddOn;
using OnlineShop.Application.DTOs.Color;
using OnlineShop.Application.DTOs.Size;
using OnlineShop.Application.Features.AddOn.Requests.Commands;
using OnlineShop.Application.Features.AddOn.Requests.Queries;
using OnlineShop.Application.Features.Color.Requests.Commands;
using OnlineShop.Application.Features.Color.Requests.Queries;
using OnlineShop.Application.Features.Size.Requests.Commands;
using OnlineShop.Application.Features.Size.Requests.Queries;

namespace OnlineShop.Api.Controllers.v1
{
    public class AddOnController : BaseController
    {
        private readonly IMediator _mediator;

        public AddOnController(IMediator mediator)
        {
            _mediator = mediator;
        }


        // GET: api/<AddOnController>
        [HttpGet("[action]")]
        public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
        {

            return Ok(await _mediator.Send(new GetAddOnListRequest(), cancellationToken));;

        }



        // POST api/<AddOnController>
        [HttpPost("[action]")]
        public async Task<IActionResult> Create(CreateAddOnDto dto, CancellationToken cancellationToken)
        {
            return Ok(await _mediator.Send(new CreateAddOnCommand { CreateAddOnDto = dto }, cancellationToken));

        }

    }
}
