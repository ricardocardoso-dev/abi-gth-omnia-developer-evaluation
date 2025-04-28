using Ambev.DeveloperEvaluation.Application.Sales.ListSales;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.ListSales;

/// <summary>
/// Represents a single sale in the response.
/// </summary>
public record struct ListSalesResponse
{
    /// <summary>
    /// Unique identifier for the sale.
    /// </summary>
    public Guid Id { get; set; }

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
    public List<ListSalesItemResponse> Items { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="GetSaleResponse"/> struct.
    /// </summary>
    public ListSalesResponse()
    {
        Items = new List<ListSalesItemResponse>();
    }
}