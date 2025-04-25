using AutoMapper;
using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Application.Products.ListProducts;

/// <summary>
/// AutoMapper profile for mapping Product entity to ListProductsResult
/// </summary>
public class ListProductsProfile : Profile
{
    public ListProductsProfile()
    {
        CreateMap<Product, ListProductsItem>()
            .ForMember(dest => dest.Category, opt => opt.MapFrom(src => src.Category.Description));
    }
}
