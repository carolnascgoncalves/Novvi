using Novvi.Domain.Commons;
using Novvi.Domain.Enums;

namespace Novvi.Domain.Entities;

//1:1 -> Pedido -------
public class Pagamento 
{
    //id, tipo (credito ou pix), horario
    public Guid Id { get;  private set; } = Guid.NewGuid();
    public TipoPagamento? TipoPagamento { get;  private set; }
    public DateTime Horario { get;  private set; } = DateTime.Now;

    public int PedidoId { get; private set; }  
    
    private Pagamento() { }
    
    public Pagamento(int pedidoId, TipoPagamento? tipoPagamento = Enums.TipoPagamento.Cartao)
    {
        TipoPagamento = tipoPagamento;
        PedidoId = pedidoId;
    }

    public override string ToString()
    {
        return $"Horario: {Horario:dd/MM/yyyy} - {TipoPagamento}";
    }
}
