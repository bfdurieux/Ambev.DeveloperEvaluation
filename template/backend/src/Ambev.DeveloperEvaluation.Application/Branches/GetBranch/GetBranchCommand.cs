using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Branches.GetBranch;

public class GetBranchCommand : IRequest<GetBranchResult>
{
    public string Location { get; set; }
    public GetBranchCommand(string location)
    {
        Location = location;
    }
}