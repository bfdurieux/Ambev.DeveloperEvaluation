using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSale;

public class CreateSaleResponse
{
    public Guid Id { get; set; }
    
    public string SaleNumber { get; set; } =  string.Empty;

    public DateTime Date { get; set; }

    public Guid CustomerId { get; set; }
    
    public Guid BranchId { get; set; }

    public IEnumerable<Item>? Items;

    public double TotalPrice { get; set; }
    
    public bool IsCancelled { get; set; }
}