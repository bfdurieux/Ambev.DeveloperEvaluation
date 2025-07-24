using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Ambev.DeveloperEvaluation.ORM.Repositories;

public class SaleRepository : BaseRepository, ISaleRepository
{
    private readonly DefaultContext _context;

    public SaleRepository(DefaultContext context) : base(context)
    {
        _context = context;
    }

    public async Task<Sale> UpdateSale(Sale request, CancellationToken cancellationToken)
    {
        var sale = await _context.Sales.FindAsync(request.Id, cancellationToken);
        if (sale == null)
            throw new Exception("Sale not found");

        _context.Entry(sale).CurrentValues.SetValues(request);
        await _context.SaveChangesAsync(cancellationToken);
        return request;
    }

    public async Task<List<Sale>> ListSalesAsync(CancellationToken cancellationToken)
    {
        var items = await _context.Items.ToListAsync(cancellationToken);
        var products = await _context.Products.ToListAsync(cancellationToken);
        var sales = await _context.Sales.Include(x => x.Items).ToListAsync(cancellationToken);
        return sales;
    }
}