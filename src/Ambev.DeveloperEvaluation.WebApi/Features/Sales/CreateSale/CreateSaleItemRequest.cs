namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSale;

/// <summary>
/// Request model representing an individual item included in a sale creation request.
/// Contains product details, quantity, pricing, and discount information.
/// </summary>
public record struct CreateSaleItemRequest
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
    /// Quantity of the product sold.
    /// </summary>
    public int Quantity { get; set; }

    /// <summary>
    /// Unit price of the product.
    /// </summary>
    public decimal UnitPrice { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="CreateSaleItemRequest"/> struct.
    /// </summary>
    public CreateSaleItemRequest()
    {
    }
}
