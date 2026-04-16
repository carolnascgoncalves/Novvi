using Novvi.Domain.Entities;

namespace Novvi.Application.DTOs;

public class ProdutoResponse
{
    public Guid Id { get; private set; }
    public bool Ativo { get; protected set; }
    public string Nome { get; private set; }
    public string Descricao { get; private set; }
    public double Preco { get; private set; }
    public List<Pedido> Pedidos { get; private set; }

    public ProdutoResponse(Produto produto)
    {
        Id = produto.Id;
        Nome = produto.Nome;
        Descricao = produto.Descricao;
        Preco = produto.Preco;
        Pedidos = new List<Pedido>();
    }
}