namespace Ambev.DeveloperEvaluation.Application.Products.DeleteProduct;

/// <summary>
/// Response model for DeleteProduct operation
/// </summary>
public record struct DeleteProductResponse
{
    /// <summary>
    /// Indicates whether the deletion was successful
    /// </summary>
    public bool Success { get; set; }
}
