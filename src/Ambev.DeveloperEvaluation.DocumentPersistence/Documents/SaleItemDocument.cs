namespace Ambev.DeveloperEvaluation.DocumentPersistence.Documents;

/// <summary>
/// Represents an item within a sale document.
/// Contains product, quantity, pricing, and discount information.
/// </summary>
public class SaleItemDocument
{
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
    /// Discount applied to the item.
    /// </summary>
    public decimal Discount { get; set; }

    /// <summary>
    /// Total value of the item after applying the discount.
    /// </summary>
    public decimal TotalValue { get; set; }
}
