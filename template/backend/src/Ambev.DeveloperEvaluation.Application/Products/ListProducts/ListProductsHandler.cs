using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Products.ListProducts;

public class ListProductsHandler : IRequestHandler<ListProductsCommand, ListProductsResult>
{
    public Task<ListProductsResult> Handle(ListProductsCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}