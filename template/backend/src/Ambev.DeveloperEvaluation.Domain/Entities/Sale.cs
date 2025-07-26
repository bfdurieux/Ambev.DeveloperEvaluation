using Ambev.DeveloperEvaluation.Domain.Common;

namespace Ambev.DeveloperEvaluation.Domain.Entities;

public class Sale : BaseEntity
{
    public string SaleNumber { get; set; } =  string.Empty;

    public DateTime Date { get; set; }

    public Guid CustomerId { get; set; }
    
    public Guid BranchId { get; set; }

    public virtual IEnumerable<Item> Items { get; set; }

    public double TotalPrice { get; set; }
    
    public bool IsCancelled { get; set; }
}