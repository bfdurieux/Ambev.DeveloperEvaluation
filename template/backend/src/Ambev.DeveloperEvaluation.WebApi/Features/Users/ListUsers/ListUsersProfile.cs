using Ambev.DeveloperEvaluation.Application.Users.ListUsers;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Users.ListUsers;

public class ListUsersProfile : Profile
{
    /// <summary>
    /// Initializes the mappings for ListUsers feature
    /// </summary>
    public ListUsersProfile()
    {
        CreateMap<ListUsersResult, ListUsersResponse>();
        CreateMap<ListUsersResult, ListUsersResponse>().ReverseMap();
        CreateMap<ListUsersCommand, ListUsersRequest>();
        CreateMap<ListUsersCommand, ListUsersRequest>().ReverseMap();
    }
}