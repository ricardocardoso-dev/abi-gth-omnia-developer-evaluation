namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSale;

/// <summary>
/// API response model representing the details of a created sale.
/// </summary>
public record struct CreateSaleResponse
{
    /// <summary>
    /// Unique identifier for the sale.
    /// </summary>
    public Guid Id { get; }

    /// <summary>
    /// Gets or sets the unique sale number.
    /// </summary>
    public long SaleNumber { get; set; }

    /// <summary>
    /// Gets or sets the date and time when the sale was created.
    /// </summary>
    public DateTime SaleDate { get; set; }

    /// <summary>
    /// Gets or sets the unique identifier of the client involved in the sale.
    /// </summary>
    public int ClientId { get; set; }

    /// <summary>
    /// Gets or sets the name of the client involved in the sale.
    /// </summary>
    public string ClientName { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the unique identifier of the branch where the sale occurred.
    /// </summary>
    public int BranchId { get; set; }

    /// <summary>
    /// Gets or sets the name of the branch where the sale occurred.
    /// </summary>
    public string BranchName { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the total value of the sale.
    /// </summary>
    public decimal TotalValue { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the sale was cancelled.
    /// </summary>
    public bool Cancelled { get; set; }

    /// <summary>
    /// Collection of sale items.
    /// </summary>
    public List<CreateSaleItemResponse> Items { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="CreateSaleResponse"/> struct.
    /// </summary>
    public CreateSaleResponse()
    {
        Items = new List<CreateSaleItemResponse>();
    }
}
