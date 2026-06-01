using TicketFlow.Contexts.Sales.Domain.Entities;

namespace TicketFlow.Contexts.Sales.Domain.Ports
{
    public interface IOrderRepository
    {
        Task SalvarAsync(Order pedido);
    }
}
