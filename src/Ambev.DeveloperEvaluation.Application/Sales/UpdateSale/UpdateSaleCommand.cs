using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Sales.UpdateSale;

/// <summary>
/// Command for updating an existing sale
/// </summary>
public record struct UpdateSaleCommand : IRequest<UpdateSaleResult>
{
    /// <summary>
    /// The unique identifier of the sale to update
    /// </summary>
    public Guid Id { get; }

    /// <summary>
    /// Sale number
    /// </summary>
    public string SaleNumber { get; }

    /// <summary>
    /// Sale date
    /// </summary>
    public DateTime SaleDate { get; }

    /// <summary>
    /// Client ID for the sale
    /// </summary>
    public int ClientId { get; }

    /// <summary>
    /// Client name
    /// </summary>
    public string ClientName { get; }

    /// <summary>
    /// Branch ID for the sale
    /// </summary>
    public int BranchId { get; }

    /// <summary>
    /// Branch name
    /// </summary>
    public string BranchName { get; }

    /// <summary>
    /// Sale items to be updated
    /// </summary>
    public List<UpdateSaleItemCommand> Items { get; }

    public UpdateSaleCommand(Guid id, string saleNumber, DateTime saleDate, int clientId, string clientName, int branchId, string branchName, List<UpdateSaleItemCommand> items)
    {
        Id = id;
        SaleNumber = saleNumber;
        SaleDate = saleDate;
        ClientId = clientId;
        ClientName = clientName;
        BranchId = branchId;
        BranchName = branchName;
        Items = items;
    }

}
