using Novvi.Domain.Commons;

namespace Novvi.Domain.Entities;

//N:1 -> Usuario  ----
//N:1 -> Funcionario ----
//N:N -> Produto ----
public class Pedido : EntidadeBase
{
    private const double freteFixo = 9.99;
    
    //id, data, frete
    public DateTime Data { get; private set; } = DateTime.Now;
    public double Frete { get; private set; } = freteFixo;

    public Guid IdUsuario { get; private set; }
    public Guid IdFuncinario { get; private set; }
    public List<Produto> Produtos { get; private set; }

    public Pedido(Guid idUsuario, Guid idFuncinario, List<Produto> produtos)
    {
        IdUsuario = idUsuario;
        IdFuncinario = idFuncinario;
        Produtos = produtos;
    }

    public string listarProdutos()
    {
        return $"Produtos: {Produtos}";
    }

    public override string ToString()
    {
        return $"{Data} (frete: {Frete}) \nProdutos: {listarProdutos()}";
    }
    
}