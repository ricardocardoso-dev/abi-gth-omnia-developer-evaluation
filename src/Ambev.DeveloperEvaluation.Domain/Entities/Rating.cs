using Ambev.DeveloperEvaluation.Domain.Common;

namespace Ambev.DeveloperEvaluation.Domain.Entities;

/// <summary>
/// Represents a product rating in the system with an evaluation score and total count.
/// This entity follows domain-driven design principles.
/// </summary>
public class Rating : BaseEntity
{
    /// <summary>
    /// Gets or sets the evaluation score of the product.
    /// Must be a positive decimal value.
    /// </summary>
    public decimal Rate { get; set; }

    /// <summary>
    /// Gets or sets the total number of ratings received by the product.
    /// Must be a non-negative integer.
    /// </summary>
    public int Count { get; set; }

    /// <summary>
    /// Initializes a new instance of the Rating class.
    /// </summary>
    public Rating()
    {
        CreatedAt = DateTime.UtcNow;
    }

    public void AddRating(decimal newRate)
    {
        if (newRate < 0 || newRate > 5)
            throw new ArgumentOutOfRangeException(nameof(newRate), "Rating must be between 0 and 5.");

        Rate = ((Rate * Count) + newRate) / (Count + 1);
        Count++;
    }
}
