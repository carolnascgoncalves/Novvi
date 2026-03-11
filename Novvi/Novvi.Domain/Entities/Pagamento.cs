using Novvi.Domain.Commons;
using Novvi.Domain.Enums;

namespace Novvi.Domain.Entities;

//1:1 -> Pedido -------
public class Pagamento : EntidadeBase
{
    //id, tipo (credito ou pix), horario
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