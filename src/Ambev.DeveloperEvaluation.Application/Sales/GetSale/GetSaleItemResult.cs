namespace Ambev.DeveloperEvaluation.Application.Sales.GetSale;

/// <summary>
/// Response model for GetSale operation
/// </summary>
public record struct GetSaleItemResult
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

    public GetSaleItemResult(Guid id, int productId, string productDescription, int quantity, decimal unitPrice, decimal discountValue, decimal discountPercent, decimal totalValue)
    {
        Id = id;
        ProductId = productId;
        ProductDescription = productDescription;
        Quantity = quantity;
        UnitPrice = unitPrice;
        DiscountValue = discountValue;
        DiscountPercent = discountPercent;
        TotalValue = totalValue;
    }
}