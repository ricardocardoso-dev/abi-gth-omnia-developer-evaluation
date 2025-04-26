using Ambev.DeveloperEvaluation.Application.Products.ListProducts;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.GetProduct;

/// <summary>
/// Profile for mapping GetProduct feature requests to commands
/// </summary>
public class GetProductProfile : Profile
{
    /// <summary>
    /// Initializes the mappings for GetProduct feature
    /// </summary>
    public GetProductProfile()
    {
        CreateMap<Guid, Application.Products.ListProducts.GetProductQuery>()
            .ConstructUsing(id => new Application.Products.ListProducts.GetProductQuery(id));

        CreateMap<GetProductResult, GetProductResponse>();

        CreateMap<Domain.ValueObjects.Rating, Common.ProductRatingResponse>()
            .ForMember(dest => dest.Rate, opt => opt.MapFrom(src => (double)src.Rate))
            .ForMember(dest => dest.Count, opt => opt.MapFrom(src => src.Count));
    }
}