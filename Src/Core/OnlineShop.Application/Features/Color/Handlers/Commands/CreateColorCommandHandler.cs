using AutoMapper;
using MediatR;
using OnlineShop.Application.Contracts.Persistence;
using OnlineShop.Application.DTOs.City.Validators;
using OnlineShop.Application.Features.Color.Requests.Commands;
using OnlineShop.Application.Responses;
using OnlineShop.Infrastructure.Exceptions;

namespace OnlineShop.Application.Features.Color.Handlers.Commands
{
    public class CreateColorCommandHandler
        : IRequestHandler<CreateColorCommand, Unit>
    {
        private readonly IColorRepository _colorRepository;
        private readonly IMapper _mapper;

        public CreateColorCommandHandler(IColorRepository colorRepository,
            IMapper mapper)
        {
            _colorRepository = colorRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(CreateColorCommand request, CancellationToken cancellationToken)
        {

            try
            {
                var validator = new CreateColorValidator();

                var validationResult = await validator.ValidateAsync(request.CreateColorDto);

                if (validationResult.IsValid == false)
                {
                    throw new AppException(validationResult.Errors.First().ErrorMessage);
                }
                else
                {

                    var color = _mapper.Map<Domain.Entity.Color>(request.CreateColorDto);
                    color = await _colorRepository.Create(color, cancellationToken);
                    await _colorRepository.SaveChanges(cancellationToken);

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
