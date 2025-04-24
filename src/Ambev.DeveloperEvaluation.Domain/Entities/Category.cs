using Ambev.DeveloperEvaluation.Domain.Common;

namespace Ambev.DeveloperEvaluation.Domain.Entities;

/// <summary>
/// Represents a product category in the system with a description.
/// This entity follows domain-driven design principles.
/// </summary>
public class Category : BaseEntity
{
    /// <summary>
    /// Gets the product category's description.
    /// Must not be null or empty.
    /// </summary>
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// Initializes a new instance of the Category class.
    /// </summary>
    public Category()
    {
        CreatedAt = DateTime.UtcNow;
    }
}
