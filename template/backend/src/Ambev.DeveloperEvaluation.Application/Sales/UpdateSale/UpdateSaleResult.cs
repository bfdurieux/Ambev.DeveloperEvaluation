using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Application.Sales.UpdateSale;

public class UpdateSaleResult
{
    public string SaleNumber { get; set; } = string.Empty;

    public DateTime Date { get; private set; }

    public Guid CustomerId { get; private set; }

    public Guid BranchId { get; set; }

    public IEnumerable<Item> Items { get; set; }

    public double TotalPrice { get; private set; }

    public bool IsCancelled { get; set; }

}