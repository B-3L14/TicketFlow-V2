namespace TicketFlow.Contexts.Auth.DTOs
{
    public record RegisterResponse(
        string Token, 
        string Name, 
        string Role
    );
}
