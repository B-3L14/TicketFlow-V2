using BCrypt.Net;
using TicketFlow.Contexts.Auth.DTOs;
using TicketFlow.Contexts.Auth.Entities;
using TicketFlow.Contexts.Auth.Interfaces;
using TicketFlow.Contexts.Auth.Repositories;

namespace TicketFlow.Contexts.Auth.UseCases;

public class RegisterUseCase(IUserRepository userRepository, TokenService tokenService)
{
    public async Task<RegisterResponse?> ExecuteAsync(RegisterRequest request)
    {
        var emailInUse = await userRepository.ExistsByEmailAsync(request.Email);
        if (emailInUse)
            return null;

        var passwordHash = BCrypt.Net.BCrypt.HashPassword(request.Password);
        var user = User.Create(request.Name, request.Email, request.Cpf, passwordHash, request.Role);

        await userRepository.AddAsync(user);

        var token = tokenService.GenerateToken(user);
        return new RegisterResponse(token, user.Name, user.Role.ToString());
    }
}