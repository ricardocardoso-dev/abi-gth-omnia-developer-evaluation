using Ambev.DeveloperEvaluation.Domain.Entities;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.Sales.GetSale;

/// <summary>
/// Profile for mapping between Sale entity and GetSaleResponse
/// </summary>
public class GetSaleProfile : Profile
{
    /// <summary>
    /// Initializes the mappings for GetSale operation
    /// </summary>
    public GetSaleProfile()
    {
        CreateMap<Sale, GetSaleResult>()
             .ConstructUsing(sale => new GetSaleResult(
                 sale.Id,
                 sale.SaleNumber,
                 sale.SaleDate,
                 sale.ClientId,
                 sale.ClientName,
                 sale.BranchId,
                 sale.BranchName,
                 sale.TotalValue,
                 sale.Cancelled,
                 sale.Items != null
                     ? sale.Items.Select(item => new GetSaleItemResult(
                         item.Id,
                         item.ProductId,
                         item.ProductDescription,
                         item.Quantity,
                         item.UnitPrice,
                         item.DiscountValue,
                         item.DiscountPercent,
                         item.TotalValue
                     )).ToList()
                     : new List<GetSaleItemResult>()
             ));

        CreateMap<SaleItem, GetSaleItemResult>()
            .ConstructUsing(item => new GetSaleItemResult(
                item.Id,
                item.ProductId,
                item.ProductDescription,
                item.Quantity,
                item.UnitPrice,
                item.DiscountValue,
                item.DiscountPercent,
                item.TotalValue
            ));
    }
}
