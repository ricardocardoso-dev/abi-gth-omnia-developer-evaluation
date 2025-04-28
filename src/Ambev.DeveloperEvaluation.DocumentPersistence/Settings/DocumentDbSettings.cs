namespace Ambev.DeveloperEvaluation.DocumentPersistence.Settings;

/// <summary>
/// Settings for configuring DocumentDb connection.
/// </summary>
public class DocumentDbSettings
{
    /// <summary>
    /// Gets or sets the connection string to connect to MongoDB.
    /// </summary>
    public string ConnectionString { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the MongoDB database name.
    /// </summary>
    public string DatabaseName { get; set; } = string.Empty;
}
