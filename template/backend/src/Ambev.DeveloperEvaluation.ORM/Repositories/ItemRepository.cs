using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Ambev.DeveloperEvaluation.ORM.Repositories;

public class ItemRepository : BaseRepository, IItemRepository
{
    private readonly DefaultContext _context;

    public ItemRepository(DefaultContext context) : base(context)
    {
        _context = context;
    }

    public async Task<Item> UpdateItemAsync(Item item, CancellationToken cancellationToken)
    {
        var ctxItem = await _context.Items.FirstAsync(x => x.Id == item.Id, cancellationToken);

        if (item.Product == null)
        {
            var product = await _context.Products
                .FirstAsync(x => x.Id == item.ProductId, cancellationToken);
            item.Product = product;
        }

        item.Price = item.Product.Price * item.Quantity;
        item.Price -= item.Discount;
        _context.Entry(ctxItem).CurrentValues.SetValues(item);
        await _context.SaveChangesAsync(cancellationToken);
        return ctxItem;
    }
}