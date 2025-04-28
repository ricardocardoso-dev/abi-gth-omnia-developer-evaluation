namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.UpdateSale;

/// <summary>
/// Request model for updating individual sale items
/// </summary>
public class UpdateSaleItemRequest
{
    /// <summary>
    /// Product ID for the item
    /// </summary>
    public Guid ProductId { get; set; }

    /// <summary>
    /// Product description
    /// </summary>
    public string ProductDescription { get; set; } = string.Empty;

    /// <summary>
    /// Quantity of the product in the sale
    /// </summary>
    public int Quantity { get; set; }

    /// <summary>
    /// Unit price of the product
    /// </summary>
    public decimal UnitPrice { get; set; }

    /// <summary>
    /// Discount applied to the item
    /// </summary>
    public decimal Discount { get; set; }

    /// <summary>
    /// Total value of the item after discount
    /// </summary>
    public decimal TotalValue { get; set; }
}
