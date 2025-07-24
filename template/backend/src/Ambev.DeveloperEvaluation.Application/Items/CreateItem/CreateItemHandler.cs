using Ambev.DeveloperEvaluation.Domain.Repositories;
using AutoMapper;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Items.CreateItem;

public class CreateItemHandler : IRequestHandler<CreateItemCommand, CreateItemResult>
{
    private readonly IMapper _mapper;
    private readonly IItemRepository _itemRepository;

    public CreateItemHandler(IMapper mapper, IItemRepository itemRepository)
    {
        _mapper = mapper;
        _itemRepository = itemRepository;
    }

    public async Task<CreateItemResult> Handle(CreateItemCommand request, CancellationToken cancellationToken)
    {
        var response = await _itemRepository.InsertAsync(request, cancellationToken);
        return _mapper.Map<CreateItemResult>(response.Entity);
    }
}