using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.GetSale;

public class GetSaleResponse
{
    public string SaleNumber { get; set; } = string.Empty;

    public DateTime Date { get; set; }

    public Guid CustomerId { get; set; }

    public Guid BranchId { get; set; }

    public virtual IEnumerable<Item> Items { get; set; }

    public double TotalPrice { get; set; }

    public bool IsCancelled { get; set; }
}