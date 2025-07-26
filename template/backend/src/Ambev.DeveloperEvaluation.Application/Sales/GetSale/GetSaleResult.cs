using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Application.Sales.GetSale;

public class GetSaleResult
{
    public string SaleNumber { get; set; } = string.Empty;

    public DateTime Date { get; private set; }

    public Guid CustomerId { get; private set; }

    public Guid BranchId { get; set; }

    public virtual IEnumerable<Item> Items { get; set; }

    public double TotalPrice { get; private set; }

    public bool IsCancelled { get; set; }
}