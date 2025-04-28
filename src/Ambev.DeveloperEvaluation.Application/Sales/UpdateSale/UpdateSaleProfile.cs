using Ambev.DeveloperEvaluation.Domain.Entities;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.Sales.UpdateSale;

/// <summary>
/// Profile for mapping between Sale entity and UpdateSaleResponse
/// </summary>
public class UpdateSaleProfile : Profile
{
    /// <summary>
    /// Initializes the mappings for UpdateSale operation
    /// </summary>
    public UpdateSaleProfile()
    {
        CreateMap<Sale, UpdateSaleResult>()
            .ConstructUsing(sale => new UpdateSaleResult(
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
                    ? sale.Items.Select(item => new UpdateSaleItemResult(
                        item.Id,
                        item.ProductId,
                        item.ProductDescription,
                        item.Quantity,
                        item.UnitPrice,
                        item.DiscountValue,
                        item.TotalValue
                    )).ToList()
                    : new List<UpdateSaleItemResult>()
            ));

        CreateMap<SaleItem, UpdateSaleItemResult>()
            .ConstructUsing(item => new UpdateSaleItemResult(
                item.Id,
                item.ProductId,
                item.ProductDescription,
                item.Quantity,
                item.UnitPrice,
                item.DiscountValue,
                item.TotalValue
            ));
    }
}
