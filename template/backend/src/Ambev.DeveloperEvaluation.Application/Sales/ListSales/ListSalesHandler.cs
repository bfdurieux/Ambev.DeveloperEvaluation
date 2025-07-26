using Ambev.DeveloperEvaluation.Domain.Repositories;
using AutoMapper;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Sales.ListSales;

public class ListSalesHandler : IRequestHandler<ListSalesCommand, ListSalesResult>
{
    private readonly IMapper _mapper;
    private readonly ISaleRepository _saleRepository;

    public ListSalesHandler(IMapper mapper, ISaleRepository saleRepository)
    {
        _mapper = mapper;
        _saleRepository = saleRepository;
    }

    public async Task<ListSalesResult> Handle(ListSalesCommand request, CancellationToken cancellationToken)
    {
        var sales = await _saleRepository.ListSalesAsync(cancellationToken);
        return new ListSalesResult { Sales = sales };
    }
}