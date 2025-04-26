using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Products.ListProducts;

/// <summary>
/// Validator for ListProductsQuery
/// </summary>
public class ListProductsValidator : AbstractValidator<ListProductsQuery>
{
    /// <summary>
    /// Initializes validation rules for ListProductsQuery
    /// </summary>
    public ListProductsValidator()
    {
        
    }
}
