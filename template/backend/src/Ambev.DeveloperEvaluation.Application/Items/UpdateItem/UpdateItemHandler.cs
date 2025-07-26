using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using AutoMapper;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Items.UpdateItem;

public class UpdateItemHandler : IRequestHandler<UpdateItemCommand, UpdateItemResult>
{
    private readonly IMapper _mapper;
    private readonly IItemRepository _itemRepository;

    public UpdateItemHandler(IMapper mapper, IItemRepository itemRepository)
    {
        _mapper = mapper;
        _itemRepository = itemRepository;
    }

    public async Task<UpdateItemResult> Handle(UpdateItemCommand request, CancellationToken cancellationToken)
    {
        var item = _mapper.Map<Item>(request);
        var response = await _itemRepository.UpdateItemAsync(item, cancellationToken);
        return _mapper.Map<UpdateItemResult>(response);
    }
}