using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Application.Branches.ListBranches;

public class ListBranchesResult
{
    public IEnumerable<Branch> Branches { get; set; }
}