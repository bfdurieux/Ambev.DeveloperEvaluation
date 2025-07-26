using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using AutoMapper;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Branches.ListBranches;

public class ListBranchesHandler : IRequestHandler<ListBranchesCommand, ListBranchesResult>
{
    private readonly IBranchRepository _repository;
    private readonly IMapper _mapper;

    public ListBranchesHandler(IBranchRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<ListBranchesResult> Handle(ListBranchesCommand request, CancellationToken cancellationToken)
    {
        var branches = await _repository.GetAllAsync<Branch>(cancellationToken);
        return new ListBranchesResult
        {
            Branches = branches
        };
    }
}