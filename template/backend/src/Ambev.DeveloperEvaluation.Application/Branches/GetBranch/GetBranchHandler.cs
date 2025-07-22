using Ambev.DeveloperEvaluation.Domain.Repositories;
using AutoMapper;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Branches.GetBranch;

public class GetBranchHandler : IRequestHandler<GetBranchCommand, GetBranchResult>
{
    private readonly IBranchRepository _repository;
    private readonly IMapper _mapper;

    public GetBranchHandler(IBranchRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }
    public async Task<GetBranchResult> Handle(GetBranchCommand request, CancellationToken cancellationToken)
    {
        var branch = await _repository.GetBranchAsync(request.Location, cancellationToken);
        if (branch == null)
            throw new KeyNotFoundException($"Branch matching location {request} not found");

        return _mapper.Map<GetBranchResult>(branch);
    }
}