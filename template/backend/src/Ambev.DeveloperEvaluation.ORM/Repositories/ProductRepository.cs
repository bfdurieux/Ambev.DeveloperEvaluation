using Ambev.DeveloperEvaluation.Domain.Repositories;

namespace Ambev.DeveloperEvaluation.ORM.Repositories;

public class ProductRepository : BaseRepository, IProductRepository
{
    private readonly DefaultContext _context;

    public ProductRepository(DefaultContext context) : base(context)
    {
        _context = context;
    }
}