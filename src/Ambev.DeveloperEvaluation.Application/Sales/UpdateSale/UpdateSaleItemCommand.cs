namespace Ambev.DeveloperEvaluation.Application.Sales.UpdateSale;

/// <summary>
/// Command for updating an individual item in the sale
/// </summary>
public record struct UpdateSaleItemCommand
{
    /// <summary>
    /// Product ID for the item
    /// </summary>
    public Guid ProductId { get; }

    /// <summary>
    /// Product description for the item
    /// </summary>
    public string ProductDescription { get; }

    /// <summary>
    /// Quantity of the product in the sale
    /// </summary>
    public int Quantity { get; }

    /// <summary>
    /// Unit price of the product
    /// </summary>
    public decimal UnitPrice { get; }

    /// <summary>
    /// Discount applied to the item
    /// </summary>
    public decimal Discount { get; }

    /// <summary>
    /// Total value of the item after discount
    /// </summary>
    public decimal TotalValue { get; }

    /// <summary>
    /// Initializes a new instance of UpdateSaleItemCommand
    /// </summary>
    public UpdateSaleItemCommand(Guid productId, string productDescription, int quantity, decimal unitPrice, decimal discount, decimal totalValue)
    {
        ProductId = productId;
        ProductDescription = productDescription;
        Quantity = quantity;
        UnitPrice = unitPrice;
        Discount = discount;
        TotalValue = totalValue;
    }
}
