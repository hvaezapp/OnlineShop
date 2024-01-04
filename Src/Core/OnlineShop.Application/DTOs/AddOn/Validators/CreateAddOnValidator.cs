using FluentValidation;
using OnlineShop.Application.DTOs.Size;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Application.DTOs.AddOn.Validators
{
    public class CreateAddOnValidator : AbstractValidator<CreateAddOnDto>
    {
        public CreateAddOnValidator()
        {

            RuleFor(p => p.Name)
                 .NotEmpty()
                 .NotNull()
                 .WithMessage("{PropertyName} is required.")
                 .MaximumLength(50)
                 .WithMessage("{PropertyName} must not exceed 50");


            RuleFor(p => p.Price)
                     .NotEmpty()
                     .NotNull()
                     .WithMessage("{PropertyName} is required.");
                      



        }
    }
}
