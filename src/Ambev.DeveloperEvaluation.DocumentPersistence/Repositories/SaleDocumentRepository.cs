namespace Ambev.DeveloperEvaluation.DocumentPersistence.Repositories;
/// <summary>
/// Repository specialized for handling SaleDocumentDto persistence.
/// </summary>
public class SaleDocumentRepository//: ISaleDocumentRepository
{
    //private readonly IMongoCollection<SaleDocument> _collection;
    //private readonly IMapper _mapper;

    //public SaleDocumentRepository(IMongoDatabase database, IMapper mapper)
    //{
    //    _collection = database.GetCollection<SaleDocument>("sales");
    //    _mapper = mapper;
    //}

    //public async Task<SaleDocumentDto> CreateAsync(SaleDocumentDto document, CancellationToken cancellationToken = default)
    //{
    //    var entity = _mapper.Map<SaleDocument>(document);
    //    await _collection.InsertOneAsync(entity, cancellationToken: cancellationToken);
    //    return document;
    //}

    //public async Task<SaleDocumentDto?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
    //{
    //    var filter = Builders<SaleDocument>.Filter.Eq(x => x.Id, id);
    //    var entity = await _collection.Find(filter).FirstOrDefaultAsync(cancellationToken);

    //    if (entity == null)
    //        return default;

    //    return _mapper.Map<SaleDocumentDto>(entity);
    //}
}
