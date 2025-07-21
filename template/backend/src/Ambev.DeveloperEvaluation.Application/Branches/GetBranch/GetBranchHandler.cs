using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Branches.GetBranch;

public class GetBranchHandler : IRequestHandler<GetBranchCommand, GetBranchResult>
{
    public Task<GetBranchResult> Handle(GetBranchCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}