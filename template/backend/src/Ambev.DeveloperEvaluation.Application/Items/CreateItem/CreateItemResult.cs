namespace Ambev.DeveloperEvaluation.Application.Items.CreateItem;

public class CreateItemResult
{
    public Guid Id { get; set; }

    public Guid ProductId { get; set; }

    public Guid SaleId { get; set; }

    public int Quantity { get; set; }

    //price of qtt * product price
    public double Price { get; set; }

    public double Discount { get; set; }

    public bool IsCancelled { get; set; }
}