namespace Ambev.DeveloperEvaluation.Domain.Enums;

/// <summary>
/// Enum representing different user statuses.
/// </summary>
public enum UserStatus : byte
{
    /// <summary>
    /// The status is unknown or not set.
    /// </summary>
    Unknown = 0,

    /// <summary>
    /// The user is active.
    /// </summary>
    Active = 1,

    /// <summary>
    /// The user is inactive.
    /// </summary>
    Inactive = 2,

    /// <summary>
    /// The user is suspended.
    /// </summary>
    Suspended = 3
}
