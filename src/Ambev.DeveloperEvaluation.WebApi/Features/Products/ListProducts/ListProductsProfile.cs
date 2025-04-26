using Ambev.DeveloperEvaluation.Application.Products.ListProducts;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.ListProducts;

/// <summary>
/// Profile for mapping ListProducts feature requests to commands
/// </summary>
public class ListProductsProfile : Profile
{
    /// <summary>
    /// Initializes the mappings for ListProducts feature
    /// </summary>
    public ListProductsProfile()
    {
        CreateMap<ListProductsRequest, ListProductsQuery>();
        CreateMap<ListProductsItem, ListProductsResponse>();

        CreateMap<Domain.ValueObjects.Rating, Common.ProductRatingResponse>()
           .ForMember(dest => dest.Rate, opt => opt.MapFrom(src => (double)src.Rate))
            .ForMember(dest => dest.Count, opt => opt.MapFrom(src => src.Count));
    }
}