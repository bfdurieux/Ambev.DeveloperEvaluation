using Ambev.DeveloperEvaluation.Domain.Common;

namespace Ambev.DeveloperEvaluation.Domain.Entities;

public class Item : BaseEntity
{
    public Guid ProductId { get; private set; }

    public Guid SaleId { get; private set; }

    public int Quantity { get; private set; }
    
    //price of qtt * product price
    public decimal Price { get; private set; }
    
    public decimal Discount { get; private set; }

    public bool IsCancelled { get; set; }

    // table relationships
    // public Product Product { get; set; }

    
    //TODO: use a design pattern for this:
    // mediator?
    
    // /// <summary>
    // /// Gets the total amount for this line item, calculated as:
    // /// <c>Quantity × UnitPrice × (1 − DiscountRate)</c>.
    // /// </summary>
    // public decimal Total => Quantity * UnitPrice * (1 - DiscountRate);

    //TODO: find a design pattern for events
    
    //
    // discount rules:
    // Purchases above 4 identical items have a 10% discount
    //     Purchases between 10 and 20 identical items have a 20% discount
    //     It's not possible to sell above 20 identical items
    // Purchases below 4 items cannot have a discount
    //     These business rules define quantity-based discounting tiers and limitations:
    //
    // Discount Tiers:
    //
    // 4+ items: 10% discount
    // 10-20 items: 20% discount
    //     Restrictions:
    //
    // Maximum limit: 20 items per product
    //     No discounts allowed for quantities below 4 items
}