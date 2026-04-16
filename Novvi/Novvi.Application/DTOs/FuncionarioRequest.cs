using System.ComponentModel.DataAnnotations;
using Novvi.Domain.Entities;

namespace Novvi.Application.DTOs;

public class FuncionarioRequest
{
    [Required]
    [StringLength(150, MinimumLength = 2)]
    public string Nome { get; set; }
    
    [Required]
    public double Salario { get; set; }

    public Funcionario toDomain()
    {
        return new Funcionario(Nome, Salario);
    }
}