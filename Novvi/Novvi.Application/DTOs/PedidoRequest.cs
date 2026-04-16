using System.ComponentModel.DataAnnotations;
using Novvi.Domain.Entities;
using Novvi.Domain.Enums;

namespace Novvi.Application.DTOs;

public class PedidoRequest
{
    [Required]
    public Guid IdUsuario { get; set; }
    
    [Required]
    public Guid IdFuncinario { get; set; }
    
    [Required]
    public List<Produto> Produtos { get; set; }
    
    public Pagamento Pagamento { get; set; }

    public Pedido toDomain()
    {
        return new Pedido(IdUsuario, IdFuncinario, Produtos, Pagamento);
    }
}