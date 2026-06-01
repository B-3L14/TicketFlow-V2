namespace TicketFlow.Contexts.Auth.DTOs
{
    public record LoginResponse(
        string Token, 
        string Name, 
        string Role
    ); 
}
