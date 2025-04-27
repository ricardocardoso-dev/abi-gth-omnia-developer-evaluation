using Ambev.DeveloperEvaluation.Application.Products.GetProduct;
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
        CreateMap<Guid, GetProductQuery>()
            .ConstructUsing(id => new GetProductQuery(id));

        CreateMap<GetProductResult, GetProductResponse>();

        CreateMap<Domain.ValueObjects.Rating, Common.ProductRatingResponse>()
            .ForMember(dest => dest.Rate, opt => opt.MapFrom(src => (double)src.Rate))
            .ForMember(dest => dest.Count, opt => opt.MapFrom(src => src.Count));
    }
}