using Ambev.DeveloperEvaluation.Domain.Entities;
using Xunit;

namespace Ambev.DeveloperEvaluation.Unit.Domain.Entities;

public class SaleTests
{
    [Fact]
    public void ApplyDiscountsToAllItems_AppliesDiscountsAndSetsTotalValue()
    {
        var sale = new Sale
        {
            Items = new List<SaleItem>
            {
                new SaleItem { Quantity = 4, UnitPrice = 10m },
                new SaleItem { Quantity = 6, UnitPrice = 10m },
                new SaleItem { Quantity = 12, UnitPrice = 10m }
            }
        };

        sale.ApplyDiscountsToAllItems();

        Assert.Equal(40, sale.Items[0].TotalValue);
        Assert.Equal(60 - 6, sale.Items[1].TotalValue);
        Assert.Equal(120 - 24, sale.Items[2].TotalValue);
        Assert.Equal(40 + 54 + 96, sale.TotalValue);
    }
}