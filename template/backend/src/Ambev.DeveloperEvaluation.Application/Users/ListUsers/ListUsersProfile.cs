using Ambev.DeveloperEvaluation.Domain.Entities;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.Users.ListUsers;

/// <summary>
/// Profile for mapping between User entity and GetUserResponse
/// </summary>
public class ListUsersProfile : Profile
{
    /// <summary>
    /// Initializes the mappings for GetUser operation
    /// </summary>
    public ListUsersProfile()
    {
        CreateMap<List<User>, ListUsersResult>();
        CreateMap<IEnumerable<User>, ListUsersResult>();
        CreateMap<IEnumerable<User>, ListUsersResult>().ReverseMap();
        CreateMap<List<User>, ListUsersResult>().ReverseMap();
    }
}
