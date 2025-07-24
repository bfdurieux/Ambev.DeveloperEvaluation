namespace Ambev.DeveloperEvaluation.WebApi.Features.Items.CreateItems;

public class CreateItemRequest
{
    public Guid Id { get; set; }

    public Guid ProductId { get; private set; }

    public Guid SaleId { get; private set; }

    public int Quantity { get; private set; }

    //price of qtt * product price
    public double Price { get; private set; }

    public double Discount { get; private set; }

    public bool IsCancelled { get; set; }
}