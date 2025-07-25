using FluentValidation;
using ProductManagement.Application.Products.Commands;

namespace ProductManagement.Application.Products.Validation;

public class ProductCommandValidator : AbstractValidator<CreateProductCommand>
{
    public ProductCommandValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty().WithMessage("Product name is required");

        RuleFor(x => x.Price)
            .GreaterThan(0).WithMessage("Price must be greater than 0");

        RuleFor(x => x.Variants)
            .Must(v => v.Distinct().Count() == v.Count)
            .WithMessage("Duplicate variants are not allowed");

        RuleForEach(x => x.Variants).ChildRules(variant =>
        {
            variant.RuleFor(v => v.Size).NotEmpty().WithMessage("Size is required");
            variant.RuleFor(v => v.Color).NotEmpty().WithMessage("Color is required");
        });
    }
}
