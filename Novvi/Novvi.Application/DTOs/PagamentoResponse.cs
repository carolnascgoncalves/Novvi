using Novvi.Domain.Entities;
using Novvi.Domain.Enums;

namespace Novvi.Application.DTOs;

public class PagamentoResponse
{
    public Guid Id { get;  set; }
    public TipoPagamento? TipoPagamento { get;  set; }
    public DateTime Horario { get;  set; }
    public int PedidoId { get; set; }  

    public PagamentoResponse(Pagamento pagamento)
    {
        Id = pagamento.Id;
        TipoPagamento = pagamento.TipoPagamento;
        Horario = pagamento.Horario;
        PedidoId = pagamento.PedidoId;
    }
    
    
}