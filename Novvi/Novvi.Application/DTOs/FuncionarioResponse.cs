using Novvi.Domain.Entities;

namespace Novvi.Application.DTOs;

public class FuncionarioResponse
{
    public Guid Id { get; set; }
    public bool Ativo { get; set; }
    public string Nome { get; private set; }
    public double Salario { get; private set; }
    public List<Pedido> PedidosRealizados { get; private set; }

    public FuncionarioResponse(Funcionario funcionario)
    {
        Id = funcionario.Id;
        Nome = funcionario.Nome;
        Salario = funcionario.Salario;
        PedidosRealizados = new List<Pedido>();
    }
    
}