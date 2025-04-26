using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Domain.Repositories;

/// <summary>
/// Repository interface for performing operations on User entities.
/// Follows the repository pattern to abstract data access logic.
/// </summary>
public interface IUserRepository
{
    /// <summary>
    /// Creates a new user in the repository.
    /// </summary>
    /// <param name="user">The user entity to create.</param>
    /// <param name="cancellationToken">A token to observe while waiting for the task to complete.</param>
    /// <returns>The created user entity.</returns>
    Task<User> CreateAsync(User user, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieves a user by their unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the user.</param>
    /// <param name="cancellationToken">A token to observe while waiting for the task to complete.</param>
    /// <returns>The user entity if found; otherwise, null.</returns>
    Task<User?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieves a user by their email address.
    /// </summary>
    /// <param name="email">The email address to search for.</param>
    /// <param name="cancellationToken">A token to observe while waiting for the task to complete.</param>
    /// <returns>The user entity if found; otherwise, null.</returns>
    Task<User?> GetByEmailAsync(string email, CancellationToken cancellationToken = default);

    /// <summary>
    /// Deletes a user from the repository by their unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the user to delete.</param>
    /// <param name="cancellationToken">A token to observe while waiting for the task to complete.</param>
    /// <returns>True if the user was deleted; false if the user was not found.</returns>
    Task<bool> DeleteAsync(Guid id, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieves a paginated list of all users.
    /// </summary>
    /// <param name="pageNumber">The page number to retrieve. Defaults to 1.</param>
    /// <param name="pageSize">The number of users per page. Defaults to 10.</param>
    /// <param name="cancellationToken">A token to observe while waiting for the task to complete.</param>
    /// <returns>A list of user entities.</returns>
    Task<List<User>> GetAllAsync(int pageNumber = 1, int pageSize = 10, CancellationToken cancellationToken = default);

    /// <summary>
    /// Updates an existing user in the repository.
    /// </summary>
    /// <param name="user">The user entity with updated information.</param>
    /// <param name="cancellationToken">A token to observe while waiting for the task to complete.</param>
    /// <returns>True if the user was successfully updated; otherwise, false.</returns>
    Task<bool> UpdateAsync(User user, CancellationToken cancellationToken = default);
}
