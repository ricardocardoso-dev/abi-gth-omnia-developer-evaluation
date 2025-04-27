using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Sales.ListSales;

/// <summary>
/// Validator for ListSalesQuery
/// </summary>
public class ListSalesValidator : AbstractValidator<ListSalesQuery>
{
    /// <summary>
    /// Initializes validation rules for ListSalesQuery
    /// </summary>
    public ListSalesValidator()
    {

    }
}
