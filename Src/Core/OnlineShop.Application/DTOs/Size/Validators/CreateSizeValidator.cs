using FluentValidation;

namespace OnlineShop.Application.DTOs.Size.Validators
{
    public class CreateSizeValidator : AbstractValidator<CreateSizeDto>
    {
        public CreateSizeValidator()
        {

            RuleFor(p => p.Name)
                .NotEmpty()
                .NotNull()
                .WithMessage("{PropertyName} is required.")
                .MaximumLength(50)
                .WithMessage("{PropertyName} must not exceed 50");

          

        }
    }
}
