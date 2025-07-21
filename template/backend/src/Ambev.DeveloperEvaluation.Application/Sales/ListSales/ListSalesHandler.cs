using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Sales.ListSales;

public class ListSalesHandler : IRequestHandler<ListSalesCommand, ListSalesResult>
{
    public Task<ListSalesResult> Handle(ListSalesCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}