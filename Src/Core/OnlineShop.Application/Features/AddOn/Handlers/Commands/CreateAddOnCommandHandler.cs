using AutoMapper;
using MediatR;
using OnlineShop.Application.Contracts.Persistence;
using OnlineShop.Application.DTOs.AddOn.Validators;
using OnlineShop.Application.Features.AddOn.Requests.Commands;
using OnlineShop.Infrastructure.Const;
using OnlineShop.Infrastructure.Exceptions;

namespace OnlineShop.Application.Features.AddOn.Handlers.Commands
{
    public class CreateAddOnCommandHandler : IRequestHandler<CreateAddOnCommand, Unit>
    {
        private readonly IAddOnRepository _addOnRepository;
        private readonly IMapper _mapper;

        public CreateAddOnCommandHandler(IAddOnRepository addOnRepository,
            IMapper mapper)
        {
            _addOnRepository = addOnRepository;
            _mapper = mapper;
        }


        public async Task<Unit> Handle(CreateAddOnCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var validator = new CreateAddOnValidator();

                var validationResult = await validator.ValidateAsync(request.CreateAddOnDto);

                if (!validationResult.IsValid)
                    throw new AppException(validationResult.Errors.First().ErrorMessage);
                else
                {
                    var oldAddOn = await _addOnRepository
                                         .GetAllAsync(a => a.Name.Trim()
                                         .Equals(request.CreateAddOnDto.Name.Trim()),
                                          cancellationToken);
                    if (oldAddOn.Any())
                        throw new AppException(DefaultConst.DuplicateValue);


                    var addOn = _mapper.Map<Domain.Entity.AddOn>(request.CreateAddOnDto);
                    await _addOnRepository.Create(addOn, cancellationToken);
                    await _addOnRepository.SaveChanges(cancellationToken);

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
