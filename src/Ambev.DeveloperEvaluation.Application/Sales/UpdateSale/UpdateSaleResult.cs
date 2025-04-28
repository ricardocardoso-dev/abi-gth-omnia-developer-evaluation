namespace Ambev.DeveloperEvaluation.Application.Sales.UpdateSale;

/// <summary>
/// Response model for UpdateSale operation
/// </summary>
public record struct UpdateSaleResult
{
    /// <summary>
    /// Unique sale number.
    /// </summary>
    public string SaleNumber { get; } = string.Empty;

    /// <summary>
    /// Date and time when the sale was created.
    /// </summary>
    public DateTime SaleDate { get; }

    /// <summary>
    /// Unique identifier of the client involved in the sale.
    /// </summary>
    public int ClientId { get; }

    /// <summary>
    /// Name of the client involved in the sale.
    /// </summary>
    public string ClientName { get; } = string.Empty;

    /// <summary>
    /// Unique identifier of the branch where the sale occurred.
    /// </summary>
    public int BranchId { get; }

    /// <summary>
    /// Name of the branch where the sale occurred.
    /// </summary>
    public string BranchName { get; } = string.Empty;

    /// <summary>
    /// Total value of the sale.
    /// </summary>
    public decimal TotalValue { get; }

    /// <summary>
    /// Indicates whether the sale was cancelled.
    /// </summary>
    public bool Cancelled { get; }


    public UpdateSaleResult()
    {
    }
}