using Ambev.DeveloperEvaluation.Domain.Entities;
using Bogus;

namespace Ambev.DeveloperEvaluation.Unit.Domain.Entities.TestData;

/// <summary>
/// Provides methods for generating test data for SaleItem using the Bogus library.
/// Centralizes valid and invalid data generation for SaleItem tests.
/// </summary>
public static class SaleItemTestData
{
    private static readonly Faker<SaleItem> SaleItemFaker = new Faker<SaleItem>()
        .RuleFor(i => i.ProductId, f => f.Random.Int(1, 1000))
        .RuleFor(i => i.ProductDescription, f => f.Commerce.ProductName())
        .RuleFor(i => i.Quantity, f => f.Random.Int(1, 20))
        .RuleFor(i => i.UnitPrice, f => f.Random.Decimal(1, 100))
        .RuleFor(i => i.Cancelled, f => false);

    /// <summary>
    /// Generates a valid SaleItem with random data.
    /// </summary>
    /// <returns>A valid SaleItem entity.</returns>
    public static SaleItem GenerateValidSaleItem()
    {
        return SaleItemFaker.Generate();
    }

    /// <summary>
    /// Generates a SaleItem with a quantity above the allowed maximum (invalid).
    /// </summary>
    /// <returns>An invalid SaleItem entity (quantity > 20).</returns>
    public static SaleItem GenerateInvalidSaleItem_QuantityAboveLimit()
    {
        var item = SaleItemFaker.Generate();
        item.Quantity = 21;
        return item;
    }

    /// <summary>
    /// Generates a SaleItem with a quantity in the discount range (5-9).
    /// </summary>
    public static SaleItem GenerateSaleItemWith10PercentDiscount()
    {
        var item = SaleItemFaker.Generate();
        item.Quantity = new Faker().Random.Int(5, 9);
        return item;
    }

    /// <summary>
    /// Generates a SaleItem with a quantity in the 20% discount range (10-20).
    /// </summary>
    public static SaleItem GenerateSaleItemWith20PercentDiscount()
    {
        var item = SaleItemFaker.Generate();
        item.Quantity = new Faker().Random.Int(10, 20);
        return item;
    }
}