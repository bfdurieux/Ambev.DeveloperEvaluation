using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Ambev.DeveloperEvaluation.Domain.Repositories;

public interface IBaseRepository
{
    Task<T?> GetByIdAsync<T>(int id, CancellationToken cancellationToken) where T : class;

    Task<List<T>> GetAllAsync<T>(CancellationToken cancellationToken) where T : class;

    Task<EntityEntry<T>> InsertAsync<T>(T entity, CancellationToken cancellationToken) where T : class;

    EntityEntry<T> Delete<T>(T entity) where T : class;
}