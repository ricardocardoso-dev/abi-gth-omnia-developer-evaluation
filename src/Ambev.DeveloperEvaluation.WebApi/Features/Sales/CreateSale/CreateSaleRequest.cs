using MediatR;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSale;

/// <summary>
/// Request model for creating a new sale.
/// Encapsulates all necessary information to register a sale, including client, branch, and item details.
/// </summary>
public record struct CreateSaleRequest : IRequest<CreateSaleResponse>
{
    /// <summary>
    /// Unique sale number.
    /// </summary>
    public string SaleNumber { get; set; } = string.Empty;

    /// <summary>
    /// Date when the sale was made.
    /// </summary>
    public DateTime SaleDate { get; set; }

    /// <summary>
    /// External identity of the client.
    /// </summary>
    public int ClientId { get; set; }

    /// <summary>
    /// Denormalized client name.
    /// </summary>
    public string ClientName { get; set; } = string.Empty;

    /// <summary>
    /// External identity of the branch (filial).
    /// </summary>
    public int BranchId { get; set; }

    /// <summary>
    /// Denormalized branch name.
    /// </summary>
    public string BranchName { get; set; } = string.Empty;

    /// <summary>
    /// List of items included in the sale.
    /// </summary>
    public List<CreateSaleItemRequest> Items { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="CreateSaleRequest"/> struct with an empty list of items.
    /// </summary>
    public CreateSaleRequest()
    {
        Items = new List<CreateSaleItemRequest>();
    }
}
