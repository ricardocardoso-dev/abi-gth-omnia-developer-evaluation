using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Sales.ListSales;

/// <summary>
/// Query for retrieving a paginated list of products
/// </summary>
public record struct ListSalesQuery(int Page = 1, int PageSize = 10) : IRequest<List<ListSalesItem>>;
