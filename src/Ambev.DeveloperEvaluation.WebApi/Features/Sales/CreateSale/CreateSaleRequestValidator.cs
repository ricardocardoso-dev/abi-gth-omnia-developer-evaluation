using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSale;

/// <summary>
/// Validator for CreateSaleRequest that defines validation rules for sale creation.
/// </summary>
public class CreateSaleRequestValidator : AbstractValidator<CreateSaleRequest>
{
    /// <summary>
    /// Initializes a new instance of the CreateSaleRequestValidator with defined validation rules.
    /// </summary>
    /// <remarks>
    /// Validation rules include:
    /// - SaleNumber: Required (not empty)
    /// - SaleDate: Required (not empty)
    /// - ClientId: Must be greater than zero
    /// - BranchId: Must be greater than zero
    /// - Items: Must not be null or empty
    /// - For each item:
    ///     - ProductId: Must be greater than zero
    ///     - ProductDescription: Required (not empty)
    ///     - Quantity: Must be greater than zero and less than or equal to 20
    ///     - UnitPrice: Must be greater than zero
    /// </remarks>
    public CreateSaleRequestValidator()
    {
        RuleFor(x => x.SaleNumber).NotEmpty().WithMessage("Sale number is required.");
        RuleFor(x => x.SaleDate).NotEmpty().WithMessage("Sale date is required.");
        RuleFor(x => x.ClientId).GreaterThan(0).WithMessage("Client ID must be greater than zero.");
        RuleFor(x => x.BranchId).GreaterThan(0).WithMessage("Branch ID must be greater than zero.");

        RuleFor(x => x.Items).NotNull().WithMessage("Sale must contain at least one item.")
                             .NotEmpty().WithMessage("Sale must contain at least one item.");

        RuleForEach(x => x.Items).ChildRules(items =>
        {
            items.RuleFor(i => i.ProductId).GreaterThan(0).WithMessage("Product ID must be greater than zero.");
            items.RuleFor(i => i.ProductDescription).NotEmpty().WithMessage("Product description is required.");
            items.RuleFor(i => i.Quantity).GreaterThan(0).WithMessage("Quantity must be greater than zero.")
                                          .LessThanOrEqualTo(20).WithMessage("Quantity must not exceed 20 units.");

            items.RuleFor(i => i.UnitPrice).GreaterThan(0).WithMessage("Unit price must be greater than zero.");
        });
    }
}
