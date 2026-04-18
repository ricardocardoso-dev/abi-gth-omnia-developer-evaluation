namespace Wishlist.Api.Configuration;

public class AuthOptions
{
    public const string SectionName = "Auth";

    public string Issuer { get; init; } = "wishlist-poc";
    public string Audience { get; init; } = "wishlist-poc-users";
    public string SecretKey { get; init; } = "replace-this-in-real-env";
    public int AccessTokenMinutes { get; init; } = 60;
}
