namespace TicketFlow.Contexts.Sales.Domain.Entities
{
    public class OrderItem
    {
        public Guid Id { get; private set; }
        public Guid EventoId { get; private set; }
        public int Quantidade { get; private set; }
        public decimal PrecoUnitario { get; private set; }

        public decimal ValorTotal => Quantidade * PrecoUnitario;

        protected OrderItem() { }

        internal OrderItem(Guid eventoId, int quantidade, decimal precoUnitario)
        {
            if (quantidade <= 0) throw new ArgumentException("A quantidade deve ser maior que zero.");
            if (precoUnitario < 0) throw new ArgumentException("O preço não pode ser negativo.");

            Id = Guid.NewGuid();
            EventoId = eventoId;
            Quantidade = quantidade;
            PrecoUnitario = precoUnitario;
        }
    }
}
