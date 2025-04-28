using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Domain.Repositories;

/// <summary>
/// Repository interface for performing operations on Sale entities.
/// Follows the repository pattern to abstract data access logic.
/// </summary>
public interface ISaleRepository
{
    /// <summary>
    /// Creates a new sale in the repository.
    /// </summary>
    /// <param name="sale">The sale entity to create.</param>
    /// <param name="cancellationToken">A token to observe while waiting for the task to complete.</param>
    /// <returns>The created sale entity.</returns>
    Task<Sale> CreateAsync(Sale sale, CancellationToken cancellationToken = default);

    /// <summary>
    /// Deletes a sale from the repository by its unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the sale to delete.</param>
    /// <param name="cancellationToken">A token to observe while waiting for the task to complete.</param>
    /// <returns>True if the sale was deleted; false if the sale was not found.</returns>
    Task<bool> CancelAsync(Guid id, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieves a paginated list of all sales.
    /// </summary>
    /// <param name="pageNumber">The page number to retrieve. Defaults to 1.</param>
    /// <param name="pageSize">The number of sales per page. Defaults to 10.</param>
    /// <param name="cancellationToken">A token to observe while waiting for the task to complete.</param>
    /// <returns>A list of sale entities.</returns>
    Task<List<Sale>> GetAllAsync(int pageNumber = 1, int pageSize = 10, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieves a sale by its unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the sale.</param>
    /// <param name="cancellationToken">A token to observe while waiting for the task to complete.</param>
    /// <returns>The sale entity if found; otherwise, null.</returns>
    Task<Sale?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);

    /// <summary>
    /// Updates an existing sale in the repository.
    /// </summary>
    /// <param name="sale">The sale entity with updated information.</param>
    /// <param name="cancellationToken">A token to observe while waiting for the task to complete.</param>
    /// <returns>The updated sale entity.</returns>
    Task<Sale> UpdateAsync(Sale sale, CancellationToken cancellationToken = default);
    Task<Sale?> GetBySaleNumber(long saleNumber, CancellationToken cancellationToken = default);
}
