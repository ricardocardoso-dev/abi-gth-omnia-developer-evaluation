namespace Ambev.DeveloperEvaluation.Domain.Entities;

using System;

/// <summary>
/// Represents an item within a sale, containing product, pricing, and quantity information.
/// </summary>
public class SaleItem
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
    /// Discount applied to the item.
    /// </summary>
    public decimal Discount { get; set; }

    /// <summary>
    /// Total value of the item after discount.
    /// </summary>
    public decimal TotalValue { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="SaleItem"/> class.
    /// </summary>
    public SaleItem()
    {
    }
}
