using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Products.ListProducts;

/// <summary>
/// Query for retrieving a paginated list of products
/// </summary>
public record ListProductsQuery(int Page = 1, int PageSize = 10) : IRequest<List<ListProductsItem>>;
