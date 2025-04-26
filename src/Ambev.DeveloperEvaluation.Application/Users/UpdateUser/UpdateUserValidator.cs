using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Users.UpdateUsers;

/// <summary>
/// Validator for UpdateUserCommand
/// </summary>
public class UpdateUserValidator : AbstractValidator<UpdateUserCommand>
{
    /// <summary>
    /// Initializes validation rules for UpdateUserCommand
    /// </summary>
    public UpdateUserValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty()
            .WithMessage("User ID is required");
    }
}