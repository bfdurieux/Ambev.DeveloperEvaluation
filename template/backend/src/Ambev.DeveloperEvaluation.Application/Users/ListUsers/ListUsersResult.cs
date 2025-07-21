using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Application.Users.ListUsers;

/// <summary>
/// Response model for GetUser operation
/// </summary>
public class ListUsersResult
{
   public IEnumerable<User> Users { get; set; }
}
