using FluentValidation;

namespace OnlineShop.Application.DTOs.City.Validators
{
    public class CreateColorValidator : AbstractValidator<CreateColorDto>
    {
        public CreateColorValidator()
        {

            RuleFor(p => p.Name).NotEmpty().WithMessage("{PropertyName} is required.")
              .NotNull()
              .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50");

            RuleFor(p => p.Code).NotEmpty().WithMessage("{PropertyName} is required.")
            .NotNull()
            .MaximumLength(10).WithMessage("{PropertyName} must not exceed 50");

        }
    }
}
