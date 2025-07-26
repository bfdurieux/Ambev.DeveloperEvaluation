using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using AutoMapper;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Items.CreateItem;

public class CreateItemHandler : IRequestHandler<CreateItemCommand, CreateItemResult>
{
    private readonly IMapper _mapper;
    private readonly IItemRepository _itemRepository;
    private readonly IProductRepository _productRepository;

    public CreateItemHandler(IMapper mapper, IItemRepository itemRepository, IProductRepository productRepository)
    {
        _mapper = mapper;
        _itemRepository = itemRepository;
        _productRepository = productRepository;
    }

    public async Task<CreateItemResult> Handle(CreateItemCommand request, CancellationToken cancellationToken)
    {
        var item = _mapper.Map<Item>(request);
        var product = await _productRepository.GetByIdAsync<Product>(item.ProductId, cancellationToken);
        if (product == null)
            throw new Exception("Product not found");

        item.Product = product;
        item.Price = product.Price;
        item.Quantity = 1;
        var response = await _itemRepository.InsertAsync(item, cancellationToken);
        return _mapper.Map<CreateItemResult>(response.Entity);
    }
}