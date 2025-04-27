namespace Ambev.DeveloperEvaluation.Application.Sales.CreateSale;

/// <summary>
/// Command representing an individual item included in a sale creation operation.
/// Encapsulates product information.
/// </summary>
public record struct CreateSaleItemCommand
{
    /// <summary>
    /// External identity of the product.
    /// </summary>
    public int ProductId { get; set; }

    /// <summary>
    /// Denormalized description of the product.
    /// </summary>
    public string ProductDescription { get; set; } = string.Empty;

    /// <summary>
    /// Quantity of the product being sold.
    /// </summary>
    public int Quantity { get; set; }

    /// <summary>
    /// Unit price of the product.
    /// </summary>
    public decimal UnitPrice { get; set; }

    /// <summary>
    /// Discount applied to the item, if any.
    /// </summary>
    public decimal Discount { get; set; }

    /// <summary>
    /// Total value of the item after applying the discount.
    /// </summary>
    public decimal TotalValue { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="CreateSaleItemCommand"/> struct.
    /// </summary>
    public CreateSaleItemCommand()
    {
    }
}
