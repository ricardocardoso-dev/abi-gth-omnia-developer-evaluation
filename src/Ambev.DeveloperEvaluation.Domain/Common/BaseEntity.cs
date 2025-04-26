using Ambev.DeveloperEvaluation.Common.Validation;

namespace Ambev.DeveloperEvaluation.Domain.Common;

/// <summary>
/// Represents the base entity for all domain entities.
/// This class includes common properties and methods for entity management and validation.
/// </summary>
public class BaseEntity : IComparable<BaseEntity>
{
    /// <summary>
    /// Gets or sets the unique identifier for the entity.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Gets or sets the date and time when the entity was created.
    /// </summary>
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// Gets or sets the date and time of the last update to the entity's information.
    /// </summary>
    public DateTime? UpdatedAt { get; set; }

    /// <summary>
    /// Asynchronously validates the entity using the specified validator.
    /// </summary>
    /// <returns>
    /// A task that represents the asynchronous validation operation.
    /// The task result contains a collection of <see cref="ValidationErrorDetail"/> objects representing the validation errors, if any.
    /// </returns>
    public Task<IEnumerable<ValidationErrorDetail>> ValidateAsync()
    {
        return Validator.ValidateAsync(this);
    }

    /// <summary>
    /// Compares the current entity with another entity.
    /// </summary>
    /// <param name="other">The entity to compare with the current entity.</param>
    /// <returns>
    /// A 32-bit signed integer that indicates the relative order of the entities being compared.
    /// The return value has the following meanings:
    /// - Less than zero: This entity is less than the <paramref name="other"/> entity.
    /// - Zero: This entity is equal to the <paramref name="other"/> entity.
    /// - Greater than zero: This entity is greater than the <paramref name="other"/> entity.
    /// </returns>
    public int CompareTo(BaseEntity? other)
    {
        if (other == null)
        {
            return 1;
        }

        return other.Id.CompareTo(Id);
    }
}
