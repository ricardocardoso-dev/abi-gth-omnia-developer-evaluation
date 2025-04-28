namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.UpdateSale;

/// <summary>
/// Request model for updating an existing sale
/// </summary>
public class UpdateSaleRequest
{
    /// <summary>
    /// The unique identifier of the sale to update
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Sale number
    /// </summary>
    public long SaleNumber { get; set; }

    /// <summary>
    /// Sale date
    /// </summary>
    public DateTime SaleDate { get; set; }

    /// <summary>
    /// Client ID for the sale
    /// </summary>
    public int ClientId { get; set; }

    /// <summary>
    /// Client name
    /// </summary>
    public string ClientName { get; set; } = string.Empty;

    /// <summary>
    /// Branch ID for the sale
    /// </summary>
    public int BranchId { get; set; }

    /// <summary>
    /// Branch name
    /// </summary>
    public string BranchName { get; set; } = string.Empty;

    /// <summary>
    /// Sale items to be updated
    /// </summary>
    public List<UpdateSaleItemRequest> Items { get; set; } = new List<UpdateSaleItemRequest>();
}
