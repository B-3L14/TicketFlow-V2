using Microsoft.AspNetCore.Identity;
using TicketFlow.Contexts.Auth.Enums;

namespace TicketFlow.Contexts.Auth.Entities;

public class User
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public string Name { get; private set; } 
    public string Email { get; private set; } 
    public string Cpf { get; private set; }
    public Roles Role { get; private set; }
    public string PasswordHash { get; private set; } 

    private User() { }

    public static User Create(string name, string email, string cpf, string passwordHash, Roles role)
    {
        return new User
        {
            Name = name,
            Email = email,
            Cpf = cpf,
            Role = role,
            PasswordHash = passwordHash
        };
    }
}