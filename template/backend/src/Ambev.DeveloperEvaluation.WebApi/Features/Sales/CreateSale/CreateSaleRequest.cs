using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSale;

public class CreateSaleRequest
{
    public string SaleNumber { get; set; } =  string.Empty;

    public DateTime Date { get; private set; }

    public Guid CustomerId { get; private set; }
    
    public Guid BranchId { get; set; }

    public IEnumerable<Item> Items { get; set; }
    //do this to make setter private?
    //private readonly List<SaleItem> Items = new List<SaleItem>();
    //public IReadOnlyCollection<SaleItem> Items => Items.AsReadOnly();

    public double TotalPrice { get; private set; }
    
    public bool IsCancelled { get; set; }
}