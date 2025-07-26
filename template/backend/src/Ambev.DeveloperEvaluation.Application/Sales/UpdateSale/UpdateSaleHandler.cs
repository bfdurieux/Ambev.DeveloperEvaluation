using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using AutoMapper;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Sales.UpdateSale;

public class UpdateSaleHandler : IRequestHandler<UpdateSaleCommand, UpdateSaleResult>
{
    private readonly IMapper _mapper;
    private readonly ISaleRepository _saleRepository;
    private readonly IProductRepository _productRepository;

    public UpdateSaleHandler(IMapper mapper, ISaleRepository saleRepository, IProductRepository productRepository)
    {
        _mapper = mapper;
        _saleRepository = saleRepository;
        _productRepository = productRepository;
    }

    public async Task<UpdateSaleResult> Handle(UpdateSaleCommand request, CancellationToken cancellationToken)
    {
        foreach (var item in request.Items)
        {
            item.Product = await _productRepository.GetByIdAsync<Product>(item.ProductId, cancellationToken);
            if (item.Product == null)
                throw new ArgumentNullException($"Product with id {item.ProductId} not found.");

            if (item.Quantity > 20)
                item.Quantity = 20;

            item.Discount = item.Quantity switch
            {
                < 4 => 0,
                > 10 => 0.20,
                >= 4 => 0.10
            };


            var discount = item.Product.Price * item.Quantity * item.Discount;
            item.Price = item.Product.Price * item.Quantity - discount;
        }


        request.TotalPrice = request.Items.Where(x => x.IsCancelled == false).Sum(i => i.Price);

        var sale = _mapper.Map<Sale>(request);
        var result = await _saleRepository.UpdateSale(sale, cancellationToken);
        return await Task.FromResult(_mapper.Map<UpdateSaleResult>(result));
    }
}

/*
Purchases above 4 identical items have a 10% discount
Purchases between 10 and 20 identical items have a 20% discount
It's not possible to sell above 20 identical items
Purchases below 4 items cannot have a discount
    These business rules define quantity-based discounting tiers and limitations:

Discount Tiers:

4+ items: 10% discount
10-20 items: 20% discount
*/