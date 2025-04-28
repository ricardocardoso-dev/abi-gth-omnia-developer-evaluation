using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Users.ListUsers;

/// <summary>
/// Query for retrieving a paginated list of users
/// </summary>
public record ListUsersQuery(int Page = 1, int PageSize = 10) : IRequest<List<ListUsersItem>>;
