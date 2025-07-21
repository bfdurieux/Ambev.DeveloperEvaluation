using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Users.ListUsers;

/// <summary>
/// Command for retrieving a user by their ID
/// </summary>
public record ListUsersCommand : IRequest<ListUsersResult>
{
    public int Count { get; set; }
    /// <summary>
    /// Initializes a new instance of GetUserCommand
    /// </summary>
    /// <param name="id">The ID of the user to retrieve</param>
    public ListUsersCommand(int count)
    {
        Count = count;
    }
}
