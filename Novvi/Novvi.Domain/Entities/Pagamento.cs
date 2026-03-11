using Novvi.Domain.Commons;
using Novvi.Domain.Enums;

namespace Novvi.Domain.Entities;

//1:1 -> Pedido -------
public class Pagamento 
{
    //id, tipo (credito ou pix), horario
    public Guid Id { get; private set; } = Guid.NewGuid();
    public TipoPagamento TipoPagamento { get; private set; }
    public DateTime Horario { get; private set; } = DateTime.Now;

    public Pagamento(TipoPagamento tipoPagamento)
    {
        TipoPagamento = tipoPagamento;
    }

    public override string ToString()
    {
        return $"Horario: {Horario:dd/MM/yyyy} - {TipoPagamento}";
    }
}