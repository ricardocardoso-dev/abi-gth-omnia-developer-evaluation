using Ambev.DeveloperEvaluation.WebApi.Features.Products.Common;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.CreateProduct;

/// <summary>
/// API response model for CreateProduct operation.
/// </summary>
public record struct CreateProductResponse
{
    /// <summary>
    /// The unique identifier of the created product.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// The title of the product.
    /// </summary>
    public string Title { get; set; } = string.Empty;

    /// <summary>
    /// The price of the product.
    /// </summary>
    public decimal Price { get; set; }

    /// <summary>
    /// The description of the product.
    /// </summary>
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// The category of the product.
    /// </summary>
    public string Category { get; set; } = string.Empty;

    /// <summary>
    /// The URL of the image for the product.
    /// </summary>
    public string Image { get; set; } = string.Empty;

    /// <summary>
    /// The rating details of the product.
    /// </summary>
    public ProductRatingResponse Rating { get; set; } = new ProductRatingResponse();

    /// <summary>
    /// Initializes a new instance of the <see cref="CreateProductResponse"/> struct.
    /// </summary>
    public CreateProductResponse()
    {
    }
}