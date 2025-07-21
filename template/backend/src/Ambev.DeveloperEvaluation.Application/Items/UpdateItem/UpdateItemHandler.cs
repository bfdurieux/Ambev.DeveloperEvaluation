using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Items.UpdateItem;

public class UpdateItemHandler : IRequestHandler<UpdateItemCommand, UpdateItemResult>
{
    public Task<UpdateItemResult> Handle(UpdateItemCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}