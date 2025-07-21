using Ambev.DeveloperEvaluation.Domain.Entities;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales;

public class CreateSaleProfile : Profile
{
    public string SaleNumber { get; set; } =  string.Empty;

    public DateTime Date { get; private set; }

    public Guid CustomerId { get; private set; }
    
    public Guid BranchId { get; set; }

    public IEnumerable<Item> _items;

    public decimal TotalPrice { get; private set; }
    
    public bool IsCancelled { get; set; }
}