namespace Ambev.DeveloperEvaluation.Application.Sales.DeleteSale;

/// <summary>
/// Response model for DeleteSale operation
/// </summary>
public record struct DeleteSaleResponse
{
    /// <summary>
    /// Indicates whether the deletion was successful
    /// </summary>
    public bool Success { get; set; }
}
