using System.ComponentModel.DataAnnotations;
using Novvi.Domain.Entities;
using Novvi.Domain.Enums;

namespace Novvi.Application.DTOs;

public class PagamentoRequest
{
    public TipoPagamento? TipoPagamento { get;  set; }

    [Required]
    public int PedidoId { get; set; }

    public Pagamento toDomain(Pagamento pagamento)
    {
        return new Pagamento(PedidoId, TipoPagamento);
    }

    public Pagamento ToDomain()
    {
        throw new NotImplementedException();
    }
}