using BCrypt.Net;
using TicketFlow.Contexts.Auth.DTOs;
using TicketFlow.Contexts.Auth.Interfaces;
using TicketFlow.Contexts.Auth.Repositories;

namespace TicketFlow.Contexts.Auth.UseCases;

public class LoginUseCase(IUserRepository userRepository, TokenService tokenService)
{
    public async Task<LoginResponse?> ExecuteAsync(LoginRequest request)
    {
        var user = await userRepository.GetByEmailAsync(request.Email);
        if (user is null)
            return null;

        var passwordValid = BCrypt.Net.BCrypt.Verify(request.Password, user.PasswordHash);
        if (!passwordValid)
            return null;

        var token = tokenService.GenerateToken(user);
        return new LoginResponse(token, user.Name, user.Role.ToString());
    }
}