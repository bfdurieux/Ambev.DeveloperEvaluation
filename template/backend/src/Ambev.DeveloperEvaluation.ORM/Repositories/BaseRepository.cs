using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Ambev.DeveloperEvaluation.ORM.Repositories;

public abstract class BaseRepository
{
    private readonly DefaultContext _context;
    
    public async Task<T?> GetByIdAsync<T>(int id) where T : class
    {
        return await _context.Set<T>().FindAsync(id);       
    }

    public async Task<List<T>> GetAllAsync<T>() where T : class
    {
        return await _context.Set<T>().ToListAsync();
    }

    public async Task<EntityEntry<T>> InsertAsync<T>(T entity) where T : class
    {
        return await _context.Set<T>().AddAsync(entity);
    }

    public EntityEntry<T> Delete<T>(T entity) where T : class
    {
        return _context.Set<T>().Remove(entity);
    }
}