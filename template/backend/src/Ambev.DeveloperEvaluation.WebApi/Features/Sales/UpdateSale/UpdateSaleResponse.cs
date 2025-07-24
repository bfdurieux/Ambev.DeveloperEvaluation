using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.UpdateSale;

public class UpdateSaleResponse
{
    public string SaleNumber { get; set; } = string.Empty;

    public DateTime Date { get; private set; }

    public Guid CustomerId { get; private set; }

    public Guid BranchId { get; set; }

    public IEnumerable<Item> Items;

    public double TotalPrice { get; private set; }

    public bool IsCancelled { get; set; }
}