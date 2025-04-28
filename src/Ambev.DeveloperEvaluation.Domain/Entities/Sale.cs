namespace Ambev.DeveloperEvaluation.Domain.Entities;

using System;
using System.Collections.Generic;

/// <summary>
/// Represents a sale entity containing information about the client, branch, sale items, and total value.
/// </summary>
public class Sale
{
    /// <summary>
    /// Unique identifier for the sale.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Sale number.
    /// </summary>
    public long SaleNumber { get; set; }

    /// <summary>
    /// Date when the sale was made.
    /// </summary>
    public DateTime SaleDate { get; set; }

    /// <summary>
    /// External identity of the client.
    /// </summary>
    public int ClientId { get; set; }

    /// <summary>
    /// Denormalized client name.
    /// </summary>
    public string ClientName { get; set; } = string.Empty;

    /// <summary>
    /// External identity of the branch.
    /// </summary>
    public int BranchId { get; set; }

    /// <summary>
    /// Denormalized branch name.
    /// </summary>
    public string BranchName { get; set; } = string.Empty;

    /// <summary>
    /// Collection of sale items.
    /// </summary>
    public List<SaleItem> Items { get; set; }

    /// <summary>
    /// Total value of the sale.
    /// </summary>
    public decimal TotalValue { get; set; }

    /// <summary>
    /// Indicates whether the sale has been cancelled.
    /// </summary>
    public bool Cancelled { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Sale"/> class with an empty list of items.
    /// </summary>
    public Sale()
    {
        Items = new List<SaleItem>();
    }

    public void ApplyDiscountsToAllItems()
    {
        foreach (var item in Items)
        {
            item.SetTotalValue();
            item.ApplyDiscount();
        }

        TotalValue = Items.Sum(i => i.TotalValue);
    }
}
