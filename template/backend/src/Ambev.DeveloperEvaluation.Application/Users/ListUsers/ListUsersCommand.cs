using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Users.ListUsers;

/// <summary>
/// Command for retrieving a user by their ID
/// </summary>
public record ListUsersCommand : IRequest<ListUsersResult>
{
   
}
