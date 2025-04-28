using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Ambev.DeveloperEvaluation.ORM.Repositories;

/// <summary>
/// Implementation of ISaleRepository using Entity Framework Core.
/// </summary>
public class SaleRepository : ISaleRepository
{
    private readonly DefaultContext _context;

    /// <summary>
    /// Initializes a new instance of SaleRepository.
    /// </summary>
    /// <param name="context">The database context.</param>
    public SaleRepository(DefaultContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Creates a new sale in the database.
    /// </summary>
    /// <param name="sale">The sale to create.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>The created sale.</returns>
    public async Task<Sale> CreateAsync(Sale sale, CancellationToken cancellationToken = default)
    {
        await _context.Sales.AddAsync(sale, cancellationToken);
        await _context.SaveChangesAsync(cancellationToken);
        return sale;
    }

    /// <summary>
    /// Retrieves a sale by its unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the sale.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>The sale if found, null otherwise.</returns>
    public async Task<Sale?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        return await _context.Sales.Include(s => s.Items.Where(x => !x.Cancelled))
                                   .AsNoTracking()
                                   .FirstOrDefaultAsync(s => s.Id == id && !s.Cancelled, cancellationToken);
    }

    /// <summary>
    /// Retrieves a sale by its unique sale number.
    /// </summary>
    /// <param name="saleNumber">The unique sale number to search for.</param>
    /// <param name="cancellationToken">A token to observe while waiting for the task to complete.</param>
    /// <returns>The <see cref="Sale"/> entity if found; otherwise, <c>null</c>.</returns>
    public async Task<Sale?> GetBySaleNumber(long saleNumber, CancellationToken cancellationToken = default)
    {
        return await _context.Sales.Include(s => s.Items.Where(x => !x.Cancelled))
                                   .AsNoTracking()
                                   .FirstOrDefaultAsync(s => s.SaleNumber == saleNumber, cancellationToken);
    }

    /// <summary>
    /// Retrieves a paginated list of sales.
    /// </summary>
    /// <param name="pageNumber">The page number to retrieve. Defaults to 1.</param>
    /// <param name="pageSize">The number of sales per page. Defaults to 10.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>The paginated list of sales.</returns>
    public async Task<List<Sale>> GetAllAsync(int pageNumber = 1, int pageSize = 10, CancellationToken cancellationToken = default)
    {
        return await _context.Sales.Include(s => s.Items.Where(x => !x.Cancelled))
                                   .AsNoTracking()
                                   .Where(s => !s.Cancelled)
                                   .Skip((pageNumber - 1) * pageSize)
                                   .Take(pageSize)
                                   .ToListAsync(cancellationToken);
    }

    /// <summary>
    /// Updates an existing sale in the database.
    /// </summary>
    /// <param name="sale">The sale to update.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>The updated sale.</returns>
    public async Task<Sale> UpdateAsync(Sale sale, CancellationToken cancellationToken = default)
    {
        var existingSale = await _context.Sales.Include(s => s.Items.Where(x => !x.Cancelled))
                                               .FirstOrDefaultAsync(s => s.Id == sale.Id, cancellationToken);

        if (existingSale is null)
            throw new KeyNotFoundException($"Sale with ID {sale.Id} not found");

        _context.Entry(existingSale).CurrentValues.SetValues(sale);
        existingSale.TotalValue = sale.TotalValue;
        existingSale.Cancelled = sale.Cancelled;

        foreach (var existingItem in existingSale.Items.ToList())
        {
            if (!sale.Items.Any(i => i.Id == existingItem.Id))
                _context.Remove(existingItem);
        }

        foreach (var item in sale.Items)
        {
            var existingItem = existingSale.Items.FirstOrDefault(i => i.Id == item.Id);
            if (existingItem != null)
                _context.Entry(existingItem).CurrentValues.SetValues(item);
            else
                existingSale.Items.Add(item);
        }

        await _context.SaveChangesAsync(cancellationToken);
        return existingSale;
    }

    /// <summary>
    /// Cancel a sale from the database by its unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the sale to delete.</param>
    /// <param name="cancellationToken">Cancellation token to cancel the operation.</param>
    /// <returns>True if the sale was deleted successfully; otherwise, false if not found.</returns>
    public async Task<bool> CancelAsync(Guid id, CancellationToken cancellationToken = default)
    {
        var sale = await GetByIdAsync(id, cancellationToken);
        if (sale is null)
            return false;

        sale.Cancelled = true;
        await _context.SaveChangesAsync(cancellationToken);

        return true;
    }
}
