using Ambev.DeveloperEvaluation.Domain.Repositories;
using AutoMapper;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Sales.GetSale;

public class GetSaleHandler : IRequestHandler<GetSaleCommand, GetSaleResult>
{
    private readonly IMapper _mapper;
    private readonly ISaleRepository _repository;

    public GetSaleHandler(IMapper mapper, ISaleRepository repository)
    {
        _mapper = mapper;
        _repository = repository;
    }

    public async Task<GetSaleResult> Handle(GetSaleCommand request, CancellationToken cancellationToken)
    {
        var response = await _repository.GetSaleByIdAsync(request.Id, cancellationToken);

        if (!response.Items.Any())
            return await Task.FromResult(_mapper.Map<GetSaleResult>(response));

        if (response.Items.Select(x => x.Price).Any(x => x == 0))
            foreach (var responseItem in response.Items)
            {
                if (responseItem.Product == null)
                    continue;

                responseItem.Price = responseItem.Product.Price * responseItem.Quantity;
                responseItem.Price -= responseItem.Discount;
            }

        response.TotalPrice = response.Items.Where(x => x.IsCancelled == false).Sum(x => x.Price);

        return await Task.FromResult(_mapper.Map<GetSaleResult>(response));
    }
}