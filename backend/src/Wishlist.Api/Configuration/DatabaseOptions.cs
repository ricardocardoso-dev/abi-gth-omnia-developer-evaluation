namespace Wishlist.Api.Configuration;

public class DatabaseOptions
{
    public const string SectionName = "Database";

    public string Provider { get; init; } = "Sqlite";
    public string ConnectionString { get; init; } = "Data Source=wishlist.db";
}
