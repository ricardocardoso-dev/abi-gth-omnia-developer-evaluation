namespace Ambev.DeveloperEvaluation.Application.Sales.UpdateSale;

/// <summary>
/// Response model for UpdateSale operation
/// </summary>
public record struct UpdateSaleResult
{
    /// <summary>
    /// Unique identifier for the sale.
    /// </summary>
    public Guid Id { get; }

    /// <summary>
    /// Unique sale number.
    /// </summary>
    public long SaleNumber { get; }

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

    public List<UpdateSaleItemResult> Items { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="UpdateSaleResult"/> struct.
    /// </summary>
    public UpdateSaleResult(Guid id, long saleNumber, DateTime saleDate, int clientId, string clientName, int branchId, string branchName, decimal totalValue, bool cancelled, List<UpdateSaleItemResult> items)
    {
        Id = id;
        SaleNumber = saleNumber;
        SaleDate = saleDate;
        ClientId = clientId;
        ClientName = clientName;
        BranchId = branchId;
        BranchName = branchName;
        TotalValue = totalValue;
        Cancelled = cancelled;
        Items = items;
    }
}