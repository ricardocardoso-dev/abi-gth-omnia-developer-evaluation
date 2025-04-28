using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Unit.Domain.Entities.TestData;
using Xunit;

namespace Ambev.DeveloperEvaluation.Unit.Domain.Entities;

public class SaleItemTests
{
    [Fact]
    public void ApplyDiscount_AppliesNoDiscount_WhenQuantityLessThan5()
    {
        var item = new SaleItem { Quantity = 4, UnitPrice = 10m };
        item.SetTotalValue();
        item.ApplyDiscount();
        Assert.Equal(0, item.DiscountValue);
        Assert.Equal(40, item.TotalValue);
    }

    [Fact]
    public void ApplyDiscount_Applies10PercentDiscount_WhenQuantityBetween5And9()
    {
        var item = SaleItemTestData.GenerateSaleItemWith10PercentDiscount();
        item.SetTotalValue();
        item.ApplyDiscount();
        Assert.Equal(item.UnitPrice * item.Quantity * 0.10m, item.DiscountValue, 2);
    }

    [Fact]
    public void ApplyDiscount_Applies20PercentDiscount_WhenQuantityBetween10And20()
    {
        var item = new SaleItem { Quantity = 15, UnitPrice = 10m };
        item.SetTotalValue();
        item.ApplyDiscount();
        Assert.Equal(15 * 10 * 0.20m, item.DiscountValue);
        Assert.Equal(150 - 30, item.TotalValue);
    }


}