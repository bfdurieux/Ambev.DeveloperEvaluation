using Ambev.DeveloperEvaluation.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Ambev.DeveloperEvaluation.ORM.Repositories;

public class BaseRepository : IBaseRepository
{
    private readonly DefaultContext _context;

    public BaseRepository(DefaultContext context)
    {
        _context = context;
    }

    public async Task<T?> GetByIdAsync<T>(Guid id, CancellationToken cancellationToken) where T : class
    {
        return await _context.Set<T>().FindAsync(id, cancellationToken);       
    }

    public async Task<List<T>> GetAllAsync<T>(CancellationToken cancellationToken) where T : class
    {
        return await _context.Set<T>().ToListAsync(cancellationToken);
    }

    public async Task<EntityEntry<T>> InsertAsync<T>(T entity, CancellationToken cancellationToken) where T : class
    {
        var response = await _context.Set<T>().AddAsync(entity, cancellationToken);
        await _context.SaveChangesAsync(cancellationToken);
        return response;
    }

    public EntityEntry<T> Delete<T>(T entity) where T : class
    {
        var response = _context.Set<T>().Remove(entity);
        _context.SaveChanges();
        return response;
    }
}