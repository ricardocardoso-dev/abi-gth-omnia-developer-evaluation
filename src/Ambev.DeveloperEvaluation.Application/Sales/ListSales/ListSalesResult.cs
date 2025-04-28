namespace Ambev.DeveloperEvaluation.Application.Sales.ListSales;

/// <summary>
/// Represents an individual item in the list of sales.
/// Contains product, quantity, pricing, discount, and total value information.
/// </summary>
public record struct ListSalesResult
{
    /// <summary>
    /// Unique identifier for the sale.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Sale number.
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
    /// External identity of the branch.
    /// </summary>
    public int BranchId { get; set; }

    /// <summary>
    /// Denormalized branch name.
    /// </summary>
    public string BranchName { get; set; } = string.Empty;

    /// <summary>
    /// Total value of the sale.
    /// </summary>
    public decimal TotalValue { get; set; }

    /// <summary>
    /// Indicates whether the sale has been cancelled.
    /// </summary>
    public bool Cancelled { get; set; }

    /// <summary>
    /// Collection of sale items.
    /// </summary>
    public List<ListSalesItemResult> Items { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="ListSalesResult"/> class with an empty list of items.
    /// </summary>
    public ListSalesResult()
    {
        Items = new List<ListSalesItemResult>();
    }
}
