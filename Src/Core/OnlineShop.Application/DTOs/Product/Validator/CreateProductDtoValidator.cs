using FluentValidation;
using OnlineShop.Application.DTOs.Color;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Application.DTOs.Product.Validator
{
    public class CreateProductDtoValidator : AbstractValidator<CreateProductDto>
    {
        public CreateProductDtoValidator()
        {

            RuleFor(p => p.Title)
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
