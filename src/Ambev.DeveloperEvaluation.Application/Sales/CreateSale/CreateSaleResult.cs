namespace Ambev.DeveloperEvaluation.Application.Sales.CreateSale;

/// <summary>
/// Result returned after creating a sale.
/// Contains basic information about the created sale.
/// </summary>
public record struct CreateSaleResult
{
    /// <summary>
    /// Unique sale number.
    /// </summary>
    public long SaleNumber { get; set; }

    /// <summary>
    /// Date and time when the sale was created.
    /// </summary>
    public DateTime SaleDate { get; set; }

    /// <summary>
    /// Unique identifier of the client involved in the sale.
    /// </summary>
    public int ClientId { get; set; }

    /// <summary>
    /// Name of the client involved in the sale.
    /// </summary>
    public string ClientName { get; set; } = string.Empty;

    /// <summary>
    /// Unique identifier of the branch where the sale occurred.
    /// </summary>
    public int BranchId { get; set; }

    /// <summary>
    /// Name of the branch where the sale occurred.
    /// </summary>
    public string BranchName { get; set; } = string.Empty;

    /// <summary>
    /// Total value of the sale.
    /// </summary>
    public decimal TotalValue { get; set; }

    /// <summary>
    /// Indicates whether the sale was cancelled.
    /// </summary>
    public bool Cancelled { get; set; }

    /// <summary>
    /// Collection of sale items.
    /// </summary>
    public List<CreateSaleItemResult> Items { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="CreateSaleResult"/> class with an empty list of items.
    /// </summary>
    public CreateSaleResult()
    {
        Items = new List<CreateSaleItemResult>();
    }
}
