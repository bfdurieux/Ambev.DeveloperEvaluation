using Ambev.DeveloperEvaluation.Application.Branches.ListBranches;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Branches.ListBranches;

public class ListBranchesProfile : Profile
{
    public ListBranchesProfile()
    {
        CreateMap<ListBranchesResult, ListBranchesResponse>();
        CreateMap<ListBranchesResult, ListBranchesResponse>().ReverseMap();
    }
}