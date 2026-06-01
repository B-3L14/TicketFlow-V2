using TicketFlow.Contexts.Sales.Domain.Entities;
using TicketFlow.Contexts.Sales.Domain.Ports;

namespace TicketFlow.Contexts.Sales.Infrastructure.Adapters
{
    public class MercadoPagoAdapter : IPaymentGateway
    {
        public Task<bool> ProcessarPagamentoAsync(Order pedido, string tokenPagamento)
        {
            // Implementação específica do adapter para Mercado Pago
            throw new NotImplementedException();
        }
    }
}
