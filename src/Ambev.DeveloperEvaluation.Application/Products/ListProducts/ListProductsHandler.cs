using Ambev.DeveloperEvaluation.Domain.Repositories;
using AutoMapper;
using FluentValidation;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Products.ListProducts;

/// <summary>
/// Handler for processing ListProductsQuery requests
/// </summary>
public class ListProductsHandler : IRequestHandler<ListProductsQuery, List<ListProductsItem>>
{
    private readonly IProductRepository _productRepository;
    private readonly IMapper _mapper;

    /// <summary>
    /// Initializes a new instance of ListProductsHandler
    /// </summary>
    /// <param name="productRepository">The product repository</param>
    /// <param name="mapper">The AutoMapper instance</param>
    /// <param name="validator">The validator for ListProductsQuery</param>
    public ListProductsHandler(
        IProductRepository productRepository,
        IMapper mapper)
    {
        _productRepository = productRepository;
        _mapper = mapper;
    }

    /// <summary>
    /// Handles the ListProductsQuery request
    /// </summary>
    /// <param name="query">The query to list all products</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A list of products</returns>
    public async Task<List<ListProductsItem>> Handle(ListProductsQuery query, CancellationToken cancellationToken)
    {
        var validator = new ListProductsValidator();
        var validationResult = await validator.ValidateAsync(query, cancellationToken);

        if (!validationResult.IsValid)
            throw new ValidationException(validationResult.Errors);

        var allProducts = await _productRepository.GetAllAsync(cancellationToken);

        return _mapper.Map<List<ListProductsItem>>(allProducts);
    }
}
