using Ambev.DeveloperEvaluation.Domain.Common;

namespace Ambev.DeveloperEvaluation.Domain.Entities;

/// <summary>
/// Represents a product in the system with details and status information.
/// This entity follows domain-driven design principles and includes business rules validation.
/// </summary>
public class Product : BaseEntity
{
    /// <summary>
    /// Gets the product's title.
    /// Must not be null or empty and should be a valid product title.
    /// </summary>
    public string Title { get; set; } = string.Empty;

    /// <summary>
    /// Gets the product's price.
    /// Must be a positive decimal value.
    /// </summary>
    public decimal Price { get; set; }

    /// <summary>
    /// Gets the product's description.
    /// Provides detailed information about the product.
    /// </summary>
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// Gets the product's image URL.
    /// </summary>
    public string Image { get; set; } = string.Empty;

    /// <summary>
    /// Gets the product's rating information.
    /// </summary>
    public Rating Rating { get; set; } = new Rating();

    /// <summary>
    /// Gets the product's category.
    /// Determines the category to which the product belongs.
    /// </summary>
    public Category Category { get; set; } = new Category();

    /// <summary>
    /// Initializes a new instance of the Product class.
    /// </summary>
    public Product()
    {
        CreatedAt = DateTime.UtcNow;
    }

    /// <summary>
    /// Performs validation of the product entity using the ProductValidator rules.
    /// </summary>
    /// <returns>
    /// A <see cref="ValidationResultDetail"/> containing:
    /// - IsValid: Indicates whether all validation rules passed
    /// - Errors: Collection of validation errors if any rules failed
    /// </returns>
    /// <remarks>
    /// <listheader>The validation includes checking:</listheader>
    /// <list type="bullet">Title format and length</list>
    /// <list type="bullet">Price must be a positive decimal</list>
    /// <list type="bullet">Description format</list>
    /// <list type="bullet">Category validity</list>
    /// <list type="bullet">Image URL format</list>
    /// <list type="bullet">Rating validity</list>
    /// </remarks>
    //public ValidationResultDetail Validate()
    //{
    //    var validator = new ProductValidator();
    //    var result = validator.Validate(this);
    //    return new ValidationResultDetail
    //    {
    //        IsValid = result.IsValid,
    //        Errors = result.Errors.Select(o => (ValidationErrorDetail)o)
    //    };
    //}

    /// <summary>
    /// Updates the product information.
    /// </summary>
    /// <param name="title">The new title of the product.</param>
    /// <param name="price">The new price of the product.</param>
    /// <param name="description">The new description of the product.</param>
    /// <param name="category">The new category of the product.</param>
    /// <param name="image">The new image URL of the product.</param>
    /// <param name="rating">The new rating information of the product.</param>
    public void Update(string title, decimal price, string description, string image, Rating rating)
    {
        Title = title;
        Price = price;
        Description = description;
        //Category = category;
        Image = image;
        Rating = rating;
        UpdatedAt = DateTime.UtcNow;
    }
}

/// <summary>
/// Represents the rating information of a product.
/// </summary>
