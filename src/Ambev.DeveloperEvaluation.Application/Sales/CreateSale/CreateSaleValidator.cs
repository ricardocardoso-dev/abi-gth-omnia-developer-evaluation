using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Sales.CreateSale;

/// <summary>
/// Validator for CreateSaleCommand to ensure business rules are respected.
/// </summary>
public class CreateSaleValidator : AbstractValidator<CreateSaleCommand>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CreateSaleValidator"/> class.
    /// </summary>
    public CreateSaleValidator()
    {
        RuleFor(x => x.SaleNumber).NotEmpty().WithMessage("Sale number is required.");
        RuleFor(x => x.SaleDate).NotEmpty().WithMessage("Sale date is required.");
        RuleFor(x => x.ClientId).GreaterThan(0).WithMessage("Client ID must be greater than zero.");
        RuleFor(x => x.BranchId).GreaterThan(0).WithMessage("Branch ID must be greater than zero.");

        RuleFor(x => x.Items).NotNull().WithMessage("Sale must contain at least one item.")
                             .NotEmpty().WithMessage("Sale must contain at least one item.");

        RuleForEach(x => x.Items).ChildRules(items =>
        {
            items.RuleFor(i => i.ProductId).NotEmpty().WithMessage("ProductId is required.")
                                           .GreaterThan(0).WithMessage("Product ID must be greater than zero.");

            items.RuleFor(i => i.ProductDescription).NotEmpty().WithMessage("Product description is required.");

            items.RuleFor(i => i.Quantity).GreaterThan(0).WithMessage("Quantity must be greater than zero.")
                                          .LessThanOrEqualTo(20).WithMessage("Quantity must not exceed 20 units.");

            items.RuleFor(i => i.UnitPrice).GreaterThan(0).WithMessage("Unit price must be greater than zero.");
        });
    }
}
