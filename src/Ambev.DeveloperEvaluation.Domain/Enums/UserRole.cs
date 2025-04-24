namespace Ambev.DeveloperEvaluation.Domain.Enums;

/// <summary>
/// Enum representing different user roles.
/// </summary>
public enum UserRole : byte
{
    /// <summary>
    /// No role assigned.
    /// </summary>
    None = 0,

    /// <summary>
    /// Customer role.
    /// </summary>
    Customer = 1,

    /// <summary>
    /// Manager role.
    /// </summary>
    Manager = 2,

    /// <summary>
    /// Admin role.
    /// </summary>
    Admin = 3,
}