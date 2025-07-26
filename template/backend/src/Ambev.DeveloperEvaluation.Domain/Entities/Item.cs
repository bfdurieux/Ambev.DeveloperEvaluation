using Ambev.DeveloperEvaluation.Domain.Common;

namespace Ambev.DeveloperEvaluation.Domain.Entities;

public class Item : BaseEntity
{
    public Guid ProductId { get; set; }

    public Guid SaleId { get; set; }

    public int Quantity { get; set; }

    //price of qtt * product price - discount
    public double Price { get; set; }

    public double Discount { get; set; }

    public bool IsCancelled { get; set; }

    // table relationships
    public virtual Product? Product { get; set; }
}