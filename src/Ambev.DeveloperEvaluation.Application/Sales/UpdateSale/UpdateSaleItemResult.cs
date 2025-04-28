namespace Ambev.DeveloperEvaluation.Application.Sales.UpdateSale;

public record struct UpdateSaleItemResult
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
    public string ProductDescription { get; set; } = string.Empty;

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

    /// <summary>
    /// Initializes a new instance of the <see cref="SaleItem"/> class.
    /// </summary>
    public UpdateSaleItemResult(Guid id, int productId, string productDescription, int quantity, decimal unitPrice, decimal discountValue, decimal totalValue)
    {
        Id = id;
        ProductId = productId;
        ProductDescription = productDescription;
        Quantity = quantity;
        UnitPrice = unitPrice;
        DiscountValue = discountValue;
        TotalValue = totalValue;
    }
}
