using Novvi.Domain.Commons;

namespace Novvi.Domain.Entities;

//1:N -> Endereco -----
//1:N - > Pedido ------
public class Usuario : EntidadeBase
{
    public string Nome { get; private set; }
    public string Email { get; private set; }
    
    public List<Endereco> Enderecos { get; private set; }
    public List<Pedido> HistoricoPedidos { get; private set; }

    public Usuario(string nome, string email, List<Endereco> enderecos)
    {
        if (nome == null || nome.Length < 2)
            throw new Exception("Nome inválido");
        Nome = nome;

        if (email == null || email.Length < 5)
            throw new Exception("Email inválido");
        Email = email;
        
        Enderecos = enderecos;
    }

    public string MostrarHistoricoPedidos()
    {
        return "Historico Pedidos: " + HistoricoPedidos;
    }

    public override string ToString()
    {
        return $"Nome: {Nome}, Email: {Email}";
    }
}
