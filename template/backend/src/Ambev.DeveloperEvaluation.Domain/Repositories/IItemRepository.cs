using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Domain.Repositories;

public interface IItemRepository : IBaseRepository
{
    Task<Item> UpdateItemAsync(Item item, CancellationToken cancellationToken);
}