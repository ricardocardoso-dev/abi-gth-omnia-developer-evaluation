using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Sales.GetSale;

/// <summary>
/// Query for retrieving a sale by their ID
/// </summary>
public record struct GetSaleQuery : IRequest<GetSaleResult>
{
    /// <summary>
    /// The unique identifier of the sale to retrieve
    /// </summary>
    public Guid Id { get; private set; }

    /// <summary>
    /// Initializes a new instance of GetSaleQuery
    /// </summary>
    /// <param name="id">The ID of the sale to retrieve</param>
    public GetSaleQuery(Guid id)
    {
        Id = id;
    }
}
