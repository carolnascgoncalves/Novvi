using Novvi.Domain.Commons;

namespace Novvi.Domain.Entities;

//1:N -> Pedido
public class Funcionario : EntidadeBase
{
    public string Nome { get; private set; }
    public double Salario { get; private set; }

    public List<Pedido> PedidosRealizados { get; private set; }

    public Funcionario(string nome, double salario)
    {
        if (nome.Length < 2 || nome == null) 
            throw new Exception("Nome incompleto");
        Nome = nome;
        
        if (salario < 1)
            throw new Exception("Salario inválido");
        Salario = salario;
    }
    
    public override string ToString()
    {
        return $"Funcionario: {Nome} - {Salario}";
    }
}