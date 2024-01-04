using AutoMapper;
using MediatR;
using OnlineShop.Application.Contracts.Persistence;
using OnlineShop.Application.DTOs.Size.Validators;
using OnlineShop.Application.Features.Size.Requests.Commands;
using OnlineShop.Infrastructure.Const;
using OnlineShop.Infrastructure.Exceptions;

namespace OnlineShop.Application.Features.Size.Handlers.Commands
{
    public class CreateSizeCommandHandler : IRequestHandler<CreateSizeCommand, Unit>
    {
        private readonly ISizeRepository _sizeRepository;
        private readonly IMapper _mapper;

        public CreateSizeCommandHandler(ISizeRepository sizeRepository,
            IMapper mapper)
        {
            _sizeRepository = sizeRepository;
            _mapper = mapper;
        }


        public async Task<Unit> Handle(CreateSizeCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var validator = new CreateSizeValidator();

                var validationResult = await validator.ValidateAsync(request.CreateSizeDto);

                if (!validationResult.IsValid)
                    throw new AppException(validationResult.Errors.First().ErrorMessage);
                else
                {
                    var oldSize = await _sizeRepository
                                          .GetAllAsync(a=>a.Name.Trim()
                                          .Equals(request.CreateSizeDto.Name.Trim()),
                                           cancellationToken);
                    if (oldSize.Any())
                        throw new AppException(DefaultConst.DuplicateValue);


                    var size = _mapper.Map<Domain.Entity.Size>(request.CreateSizeDto);
                    await _sizeRepository.Create(size, cancellationToken);
                    await _sizeRepository.SaveChanges(cancellationToken);

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
