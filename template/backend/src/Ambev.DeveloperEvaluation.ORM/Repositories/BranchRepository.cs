using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Ambev.DeveloperEvaluation.ORM.Repositories;

public class BranchRepository : BaseRepository, IBranchRepository
{
    private readonly DefaultContext _context;

    public BranchRepository(DefaultContext context)
    {
        _context = context;
    }

    public async Task<Branch?> GetBranchAsync(string location, CancellationToken cancellationToken = default)
    {
        return await _context.Branches.FirstOrDefaultAsync(x => x.Location.ToLower().Contains(location.Trim().ToLower()), cancellationToken);
    }
}