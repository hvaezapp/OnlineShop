using FluentValidation;

namespace OnlineShop.Application.DTOs.Color.Validators
{
    public class CreateColorValidator : AbstractValidator<CreateColorDto>
    {
        public CreateColorValidator()
        {

            RuleFor(p => p.Name)
                .NotEmpty()
                .NotNull()
                .WithMessage("{PropertyName} is required.")
                .MaximumLength(50)
                .WithMessage("{PropertyName} must not exceed 50");


            RuleFor(p => p.Code)
                .NotEmpty()
                .NotNull()
                .WithMessage("{PropertyName} is required.")
                .MaximumLength(10)
                .WithMessage("{PropertyName} must not exceed 50");

        }
    }
}
