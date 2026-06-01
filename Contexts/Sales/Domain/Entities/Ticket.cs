using TicketFlow.Contexts.Sales.Domain.Enums;

namespace TicketFlow.Domain.Entities;

public class Ingresso
{
    public Guid Id { get; private set; }
    public string Hash { get; private set; }
    public Guid UsuarioId { get; private set; }
    public Guid EventoId { get; private set; }
    public TicketStatus Status { get; private set; }

    // Construtor vazio para o Entity Framework
    protected Ingresso() { }

    internal Ingresso(Guid usuarioId, Guid eventoId)
    {
        Id = Guid.NewGuid();
       
        Hash = Guid.NewGuid().ToString("N")[..10].ToUpper();
        UsuarioId = usuarioId;
        EventoId = eventoId;
        Status = TicketStatus.Disponivel; 
    }

    public void Cancelar()
    {
        Status = TicketStatus.Cancelado;
    }

    public void MarcarComoUsado()
    {
        Status = TicketStatus.Usado;
    }
}