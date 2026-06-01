using TicketFlow.Contexts.Auth.Enums;

namespace TicketFlow.Contexts.Auth.DTOs;

public record RegisterRequest(
    string Name,
    string Email,
    string Cpf,
    Roles Role,
    string Password
);