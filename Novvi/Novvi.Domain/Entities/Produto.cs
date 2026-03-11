using Novvi.Domain.Commons;

namespace Novvi.Domain.Entities;

//N:N -> Pedido
public class Produto : EntidadeBase
{
    public string Nome { get; private set; }
    public string Descricao { get; private set; }
    public double Preco { get; private set; }

    public List<Pedido> Pedidos { get; private set; }

    public override string ToString()
    {
        return $"{Nome} (R$ {Preco}) - {Descricao} \n";
    }
}