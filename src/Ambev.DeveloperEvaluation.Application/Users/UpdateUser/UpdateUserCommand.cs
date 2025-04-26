using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Users.UpdateUsers;

/// <summary>
/// Command for retrieving a user by their ID
/// </summary>
public record UpdateUserCommand : IRequest<UpdateUserResult>
{
    /// <summary>
    /// The unique identifier of the user to retrieve
    /// </summary>
    public Guid Id { get; }

    /// <summary>
    /// Gets or sets the username of the user to be created.
    /// </summary>
    public string Username { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the password for the user.
    /// </summary>
    public string Password { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the phone number for the user.
    /// </summary>
    public string Phone { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the email address for the user.
    /// </summary>
    public string Email { get; set; } = string.Empty;

    ///// <summary>
    ///// Gets or sets the status of the user.
    ///// </summary>
    //public UserStatus Status { get; set; }

    ///// <summary>
    ///// Gets or sets the role of the user.
    ///// </summary>
    //public UserRole Role { get; set; }

    /// <summary>
    /// Initializes a new instance of UpdateProductCommand
    /// </summary>
    /// <param name="id">The ID of the user to retrieve</param>
    public UpdateUserCommand(Guid id)
    {
        Id = id;
    }
}
