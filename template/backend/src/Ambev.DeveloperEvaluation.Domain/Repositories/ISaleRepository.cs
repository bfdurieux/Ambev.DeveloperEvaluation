using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Domain.Repositories;

public interface ISaleRepository : IBaseRepository
{
    Task<Sale> UpdateSale(Sale request, CancellationToken cancellationToken);
    Task<List<Sale>> ListSalesAsync(CancellationToken cancellationToken);
}