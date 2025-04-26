namespace Ambev.DeveloperEvaluation.WebApi.Common;

public class PaginatedRequest
{
    /// <summary>
    /// Page number (starting from 1)
    /// </summary>
    public int Page { get; set; } = 1;

    /// <summary>
    /// Number per page
    /// </summary>
    public int PageSize { get; set; } = 10;
}
