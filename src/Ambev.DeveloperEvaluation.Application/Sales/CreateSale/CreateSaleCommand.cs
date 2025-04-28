using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Sales.CreateSale;

/// <summary>
/// Command to create a new sale.
/// Encapsulates all the necessary information to register a sale.
/// </summary>
public class CreateSaleCommand : IRequest<CreateSaleResult>
{
    /// <summary>
    /// Unique sale number.
    /// </summary>
    public long SaleNumber { get; set; }

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
    public List<CreateSaleItemCommand> Items { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="CreateSaleCommand"/> struct with an empty list of items.
    /// </summary>
    public CreateSaleCommand()
    {
        Items = new List<CreateSaleItemCommand>();
    }
}
