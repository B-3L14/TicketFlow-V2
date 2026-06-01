using TicketFlow.Contexts.Auth.Entities;
using TicketFlow.Contexts.Auth.Interfaces;

namespace TicketFlow.Contexts.Auth.Repositories;

public class UserRepository : IUserRepository
{
    private static readonly List<User> _users = [];

    public Task<User?> GetByEmailAsync(string email)
    {
        var user = _users.FirstOrDefault(u => u.Email == email);
        return Task.FromResult(user);
    }

    public Task<bool> ExistsByEmailAsync(string email)
    {
        var exists = _users.Any(u => u.Email == email);
        return Task.FromResult(exists);
    }

    public Task AddAsync(User user)
    {
        _users.Add(user);
        return Task.CompletedTask;
    }

    
}