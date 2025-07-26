using Ambev.DeveloperEvaluation.Application.Branches.GetBranch;
using Ambev.DeveloperEvaluation.Domain.Entities;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Branches.GetBranch;

public class GetBranchProfile : Profile
{
    
    public GetBranchProfile()
    {
        CreateMap<string, GetBranchCommand>()
            .ConstructUsing(location => new GetBranchCommand(location));
        CreateMap<GetBranchResponse, GetBranchResult>();
        CreateMap<GetBranchResponse, GetBranchResult>().ReverseMap();
        CreateMap<Branch, GetBranchResult>();
        CreateMap<Branch, GetBranchResult>().ReverseMap();
    }
}