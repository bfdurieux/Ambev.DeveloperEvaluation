using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Branches.ListBranches;

public class ListBranchesResponse
{
    public IEnumerable<Branch> Branches { get; set; }
}