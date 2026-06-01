using TicketFlow.Contexts.Sales.Domain.Entities;
using TicketFlow.Contexts.Sales.Domain.Ports;

namespace TicketFlow.Contexts.Sales.Infrastructure.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        public Task SalvarAsync(Order pedido)
        {
            throw new NotImplementedException();
        }
    }
}
