using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Items.CreateItem;

public class CreateItemCommand : IRequest<CreateItemResult>
{
    public Guid ProductId { get; set; }

    public Guid SaleId { get; set; }

    public int Quantity { get; set; }
}