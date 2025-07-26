using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Customers.GetCustomer;

public class GetCustomerHandler : IRequestHandler<GetCustomerCommand, GetCustomerResult>
{
    public Task<GetCustomerResult> Handle(GetCustomerCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}