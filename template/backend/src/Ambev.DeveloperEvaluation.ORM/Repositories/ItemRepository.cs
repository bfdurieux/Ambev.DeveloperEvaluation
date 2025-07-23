using Ambev.DeveloperEvaluation.Domain.Repositories;

namespace Ambev.DeveloperEvaluation.ORM.Repositories;

public class ItemRepository : BaseRepository, IItemRepository
{
    public ItemRepository(DefaultContext context) : base(context)
    {
    }
}