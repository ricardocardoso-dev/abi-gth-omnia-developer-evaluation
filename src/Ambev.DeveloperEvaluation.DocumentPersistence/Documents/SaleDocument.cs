namespace Ambev.DeveloperEvaluation.DocumentPersistence.Documents;

using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

/// <summary>
/// Represents a sale document stored in the document database.
/// Contains client, branch, item, and financial information.
/// </summary>
public class SaleDocument
{
    /// <summary>
    /// Unique identifier of the sale document.
    /// </summary>
    [BsonId]
    [BsonRepresentation(BsonType.String)]
    public Guid Id { get; set; }

    /// <summary>
    /// Sale number.
    /// </summary>
    public string SaleNumber { get; set; } = string.Empty;

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
    /// Total value of the sale.
    /// </summary>
    public decimal TotalValue { get; set; }

    /// <summary>
    /// Indicates whether the sale was cancelled.
    /// </summary>
    public bool Cancelled { get; set; }

    /// <summary>
    /// List of items included in the sale.
    /// </summary>
    public List<SaleItemDocument> Items { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="SaleDocument"/> class.
    /// </summary>
    public SaleDocument()
    {
        Items = new List<SaleItemDocument>();
    }
}
