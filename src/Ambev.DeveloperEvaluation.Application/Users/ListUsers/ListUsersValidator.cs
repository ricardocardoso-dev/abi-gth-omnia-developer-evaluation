using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Users.ListUsers;

/// <summary>
/// Validator for ListUsersQuery
/// </summary>
public class ListUsersValidator : AbstractValidator<ListUsersQuery>
{
    /// <summary>
    /// Initializes validation rules for ListUsersQuery
    /// </summary>
    public ListUsersValidator()
    {

    }
}
