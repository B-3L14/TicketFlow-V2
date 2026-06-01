namespace TicketFlow.Contexts.Auth.DTOs;

public record LoginRequest(
    string Email,
    string Password
);