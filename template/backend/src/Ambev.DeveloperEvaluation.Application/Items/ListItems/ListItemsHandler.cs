using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Items.ListItems;

public class ListItemsHandler : IRequestHandler<ListItemsCommand, ListItemsResult>
{
    public Task<ListItemsResult> Handle(ListItemsCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}