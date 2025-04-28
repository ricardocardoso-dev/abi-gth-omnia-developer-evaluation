namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSale;

/// <summary>
/// Response model for CreateSaleItemResponse
/// </summary>
public record struct CreateSaleItemResponse
{
    /// <summary>
    /// Unique identifier for the sale item.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// External identity of the product.
    /// </summary>
    public int ProductId { get; set; }

    /// <summary>
    /// Denormalized product description.
    /// </summary>
    public string ProductDescription { get; set; }

    /// <summary>
    /// Quantity of the product sold.
    /// </summary>
    public int Quantity { get; set; }

    /// <summary>
    /// Unit price of the product.
    /// </summary>
    public decimal UnitPrice { get; set; }

    /// <summary>
    /// Discount value applied to the item.
    /// </summary>
    public decimal DiscountValue { get; set; }

    /// <summary>
    /// Discount percent applied to the item.
    /// </summary>
    public decimal DiscountPercent { get; set; }

    /// <summary>
    /// Total value of the item after discount.
    /// </summary>
    public decimal TotalValue { get; set; }
}