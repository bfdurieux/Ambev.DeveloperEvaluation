using Ambev.DeveloperEvaluation.Domain.Entities;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Sales.UpdateSale;

public class UpdateSaleCommand : IRequest<UpdateSaleResult>
{
    public Guid Id { get; set; }

    public string SaleNumber { get; set; } = string.Empty;

    public DateTime Date { get; private set; }

    public Guid CustomerId { get; private set; }

    public Guid BranchId { get; set; }

    public IEnumerable<Item> Items { get; set; }

    public double TotalPrice { get; set; }

    public bool IsCancelled { get; set; }

}