using Ambev.DeveloperEvaluation.DocumentPersistence.Documents;
using Ambev.DeveloperEvaluation.DocumentPersistence.Settings;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace Ambev.DeveloperEvaluation.DocumentPersistence;

public class DocumentContext
{
    private readonly IMongoDatabase _database;

    public DocumentContext(IOptions<DocumentDbSettings> settings)
    {
        var client = new MongoClient(settings.Value.ConnectionString);
        _database = client.GetDatabase(settings.Value.DatabaseName);
    }

    public IMongoCollection<SaleDocument> SaleDocuments => _database.GetCollection<SaleDocument>("SaleDocuments");

}
