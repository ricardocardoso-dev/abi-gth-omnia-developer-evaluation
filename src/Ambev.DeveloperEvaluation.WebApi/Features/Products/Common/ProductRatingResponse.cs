namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.Common;

public record struct ProductRatingResponse
{
    public double Rate { get; set; }

    public int Count { get; set; }
}
