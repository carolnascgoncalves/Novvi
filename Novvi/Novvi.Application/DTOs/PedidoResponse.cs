using Novvi.Domain.Entities;
using Novvi.Domain.Enums;

namespace Novvi.Application.DTOs;

public class PedidoResponse
{
    public Guid Id { get; set; }
    public bool Ativo { get;  set; } 
    public DateTime Data { get; set; } 
    public double Frete { get; set; }
    public Guid IdUsuario { get; set; }
    public Guid IdFuncinario { get; set; }
    public List<Produto> Produtos { get; set; }
    public Pagamento Pagamento { get; set; }

    public PedidoResponse(Pedido pedido)
    {
        Id = pedido.Id;
        Ativo = pedido.Ativo;
        Data = pedido.Data;
        Frete = pedido.Frete;
        IdUsuario = pedido.IdUsuario;
        IdFuncinario = pedido.IdFuncinario;
        Produtos = pedido.Produtos;
        Pagamento = pedido.Pagamento;
    }
}