namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales;

public class CreateSaleRequest
{
    public string SaleNumber { get; set; } =  string.Empty;

    public DateTime Date { get; private set; }

    public Guid CustomerId { get; private set; }
    
    public Guid BranchId { get; set; }

    public IEnumerable<Item> _items;
    //do this to make setter private?
    //private readonly List<SaleItem> _items = new List<SaleItem>();
    //public IReadOnlyCollection<SaleItem> Items => _items.AsReadOnly();

    public decimal TotalPrice { get; private set; }
    
    public bool IsCancelled { get; set; }
}