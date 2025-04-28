using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Events;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using AutoMapper;
using FluentValidation;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Sales.UpdateSale;

/// <summary>
/// Handler for processing UpdateSaleCommand requests
/// </summary>
public class UpdateSaleHandler : IRequestHandler<UpdateSaleCommand, UpdateSaleResult>
{
    private readonly ISaleRepository _saleRepository;
    private readonly IMapper _mapper;
    private readonly IEventPublisher _eventPublisher;

    /// <summary>
    /// Initializes a new instance of UpdateSaleHandler
    /// </summary>
    /// <param name="saleRepository">The sale repository</param>
    /// <param name="mapper">The AutoMapper instance</param>
    /// <param name="validator">The validator for UpdateSaleCommand</param>
    public UpdateSaleHandler(ISaleRepository saleRepository, IMapper mapper, IEventPublisher eventPublisher)
    {
        _saleRepository = saleRepository;
        _mapper = mapper;
        _eventPublisher = eventPublisher;
    }

    /// <summary>
    /// Handles the UpdateSaleCommand request
    /// </summary>
    /// <param name="command">The UpdateSale command</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The sale details if found</returns>
    public async Task<UpdateSaleResult> Handle(UpdateSaleCommand command, CancellationToken cancellationToken)
    {
        var validator = new UpdateSaleValidator();
        var validationResult = await validator.ValidateAsync(command, cancellationToken);

        if (!validationResult.IsValid)
            throw new ValidationException(validationResult.Errors);

        var sale = await _saleRepository.GetByIdAsync(command.Id, cancellationToken);
        if (sale is null)
            throw new KeyNotFoundException($"Sale with ID {command.Id} not found");

        sale.SaleDate = command.SaleDate;
        sale.ClientId = command.ClientId;
        sale.ClientName = command.ClientName;
        sale.BranchId = command.BranchId;
        sale.BranchName = command.BranchName;

        await CancelRemovedItemsAsync(sale, command.Items, _eventPublisher);
        UpdateOrAddItems(sale, command.Items);

        sale.ApplyDiscountsToAllItems();

        var updatedSale = await _saleRepository.UpdateAsync(sale, cancellationToken);
        updatedSale.Items = updatedSale.Items.Where(x => !x.Cancelled).ToList();

        await _eventPublisher.PublishAsync("SaleModified", updatedSale);
        //TODO: Atualizar cópia no mongoDb para leitura rápida

        return _mapper.Map<UpdateSaleResult>(updatedSale);
    }

    /// <summary>
    /// Cancels items that were removed from the sale during an update.
    /// Publishes an event for each cancelled item.
    /// </summary>
    /// <param name="sale">The sale entity being updated.</param>
    /// <param name="updatedItems">The collection of updated sale items.</param>
    /// <param name="eventPublisher">Service used to publish cancellation events.</param>
    private async Task CancelRemovedItemsAsync(Sale sale, IEnumerable<UpdateSaleItemCommand> updatedItems, IEventPublisher eventPublisher)
    {
        var updatedProductIds = updatedItems.Select(i => i.ProductId).ToHashSet();
        foreach (var existingItem in sale.Items)
        {
            if (!updatedProductIds.Contains(existingItem.ProductId) && !existingItem.Cancelled)
            {
                existingItem.Cancelled = true;
                await eventPublisher.PublishAsync("ItemCancelled", new { SaleId = sale.Id, Item = existingItem });
            }
        }
    }

    /// <summary>
    /// Updates existing sale items or adds new items to the sale based on the update request.
    /// Resets the cancellation flag for updated items.
    /// </summary>
    /// <param name="sale">The sale entity being updated.</param>
    /// <param name="updatedItems">The collection of updated sale items.</param>
    private void UpdateOrAddItems(Sale sale, IEnumerable<UpdateSaleItemCommand> updatedItems)
    {
        foreach (var item in updatedItems)
        {
            var saleItem = sale.Items.FirstOrDefault(i => i.ProductId == item.ProductId);
            if (saleItem != null)
            {
                saleItem.Quantity = item.Quantity;
                saleItem.UnitPrice = item.UnitPrice;
                saleItem.Cancelled = false;
            }
            else
            {
                sale.Items.Add(new SaleItem
                {
                    ProductId = item.ProductId,
                    ProductDescription = item.ProductDescription,
                    Quantity = item.Quantity,
                    UnitPrice = item.UnitPrice,
                    Cancelled = false
                });
            }
        }
    }

}

