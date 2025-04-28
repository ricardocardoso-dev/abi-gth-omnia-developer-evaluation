namespace Ambev.DeveloperEvaluation.Domain.Entities;

using System;

/// <summary>
/// Represents an item within a sale, containing product, pricing, and quantity information.
/// </summary>
public class SaleItem
{
    /// <summary>
    /// Unique identifier for the sale 
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
    /// Discount value applied to the 
    /// </summary>
    public decimal DiscountValue { get; set; }

    /// <summary>
    /// Discount percent applied to the 
    /// </summary>
    public decimal DiscountPercent { get; set; }

    /// <summary>
    /// Total value of the item after discount.
    /// </summary>
    public decimal TotalValue { get; set; }

    /// <summary>
    /// Indicates whether the sale has been cancelled.
    /// </summary>
    public bool Cancelled { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="SaleItem"/> class.
    /// </summary>
    public SaleItem()
    {
    }

    /// <summary>
    /// Calculates and sets the <see cref="TotalValue"/> of the item
    /// by multiplying the <see cref="UnitPrice"/> by the <see cref="Quantity"/>.
    /// </summary>
    public void SetTotalValue()
    {
        TotalValue = (UnitPrice * Quantity) - DiscountValue;
    }

    /// <summary>
    /// Applies a discount to the sale item based on the quantity purchased.
    /// <para>If the quantity is greater than or equal to 10, applies a 20% discount.
    /// <br>If the quantity is greater than or equal to 5, applies a 10% discount.</br>
    /// <br>Otherwise, no discount is applied.</br></para>
    /// </summary>
    /// <param name="item">The sale item to which the discount will be applied.</param>
    public void ApplyDiscount()
    {
        /// <summary>
        /// Percentage multiplier representing 10% (used for calculations).
        /// </summary>
        const decimal FACTOR_PERCENT_10 = 0.10m;

        /// <summary>
        /// Percentage multiplier representing 20% (used for calculations).
        /// </summary>
        const decimal FACTOR_PERCENT_20 = 0.20m;


        if (Quantity >= 10)
        {
            DiscountValue = TotalValue * FACTOR_PERCENT_20;
            DiscountPercent = FACTOR_PERCENT_20 * 100;
        }
        else if (Quantity >= 5)
        {
            DiscountValue = TotalValue * FACTOR_PERCENT_10;
            DiscountPercent = FACTOR_PERCENT_10 * 100;
        }
        else
        {
            DiscountValue = 0;
            DiscountPercent = 0;
        }

        SetTotalValue();
    }
}
