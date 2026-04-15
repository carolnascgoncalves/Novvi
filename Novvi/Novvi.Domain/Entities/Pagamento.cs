using Novvi.Domain.Commons;
using Novvi.Domain.Enums;

namespace Novvi.Domain.Entities;

//1:1 -> Pedido -------
public class Pagamento 
{
    //id, tipo (credito ou pix), horario
    public Guid Id { get;  set; } = Guid.NewGuid();
    public TipoPagamento TipoPagamento { get;  set; }
    public DateTime Horario { get;  set; } = DateTime.Now;

    public int PedidoId { get; set; }  

    public Pedido Pedido { get; set; } 
    
    public Pagamento(TipoPagamento tipoPagamento)
    {
        TipoPagamento = tipoPagamento;
    }

    public override string ToString()
    {
        return $"Horario: {Horario:dd/MM/yyyy} - {TipoPagamento}";
    }
}
