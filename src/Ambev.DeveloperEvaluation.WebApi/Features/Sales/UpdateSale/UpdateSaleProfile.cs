using Ambev.DeveloperEvaluation.Application.Sales.UpdateSale;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.UpdateSale;

public class UpdateSaleProfile : Profile
{
    public UpdateSaleProfile()
    {
        CreateMap<UpdateSaleRequest, UpdateSaleCommand>()
            .ConstructUsing(src => new UpdateSaleCommand(
                src.Id,
                src.SaleNumber,
                src.SaleDate,
                src.ClientId,
                src.ClientName,
                src.BranchId,
                src.BranchName,
                src.Items.Select(item => new UpdateSaleItemCommand(
                    item.ProductId,
                    item.ProductDescription,
                    item.Quantity,
                    item.UnitPrice,
                    item.DiscountValue,
                    item.UnitPrice * item.Quantity - item.DiscountValue
                )).ToList()
            ));

        CreateMap<UpdateSaleItemRequest, UpdateSaleItemCommand>()
            .ConstructUsing(src => new UpdateSaleItemCommand(
                src.ProductId,
                src.ProductDescription,
                src.Quantity,
                src.UnitPrice,
                src.DiscountValue,
                src.UnitPrice * src.Quantity - src.DiscountValue
            ));

        CreateMap<UpdateSaleResult, UpdateSaleResponse>();
    }
}
