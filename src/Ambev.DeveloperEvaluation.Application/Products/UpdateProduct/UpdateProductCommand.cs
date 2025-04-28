using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Products.UpdateProduct;

/// <summary>
/// Command for retrieving a product by their ID
/// </summary>
public record struct UpdateProductCommand : IRequest<UpdateProductResult>
{
    /// <summary>
    /// The unique identifier of the product to retrieve
    /// </summary>
    public Guid Id { get; }

    /// <summary>
    /// Initializes a new instance of UpdateProductCommand
    /// </summary>
    /// <param name="id">The ID of the product to retrieve</param>
    public UpdateProductCommand(Guid id)
    {
        Id = id;
    }
}
