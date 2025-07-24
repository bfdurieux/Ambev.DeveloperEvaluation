using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Products.ListProducts;

public class ListProductsCommand : IRequest<ListProductsResult>
{
    public int Count { get; set; }

    public ListProductsCommand(int count)
    {
        Count = count;
    }
}