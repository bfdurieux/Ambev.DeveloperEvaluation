using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Items.CreateItem;

public class CreateItemHandler : IRequestHandler<CreateItemCommand, CreateItemResult>
{
    public Task<CreateItemResult> Handle(CreateItemCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}