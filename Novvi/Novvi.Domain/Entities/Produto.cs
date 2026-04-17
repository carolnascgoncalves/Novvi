using Novvi.Domain.Commons;

namespace Novvi.Domain.Entities;

//N:N -> Pedido
public class Produto : EntidadeBase
{
    public string Nome { get; private set; }
    public string Descricao { get; private set; }
    public double Preco { get; private set; }

    public List<Pedido> Pedidos { get; private set; }

    public Produto(string nome, string descricao, double preco, List<Pedido> pedidos)
    {
        Nome = nome;
        Descricao = descricao;
        Preco = preco;
        Pedidos = pedidos;
    }
    
    private Produto()
    {
        Pedidos = new List<Pedido>();
    }
    
    public override string ToString()
    {
        return $"{Nome} (R$ {Preco}) - {Descricao} \n";
    }
}