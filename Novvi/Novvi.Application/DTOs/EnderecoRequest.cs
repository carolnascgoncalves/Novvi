using System.ComponentModel.DataAnnotations;
using Novvi.Domain.Entities;

namespace Novvi.Application.DTOs;

public class EnderecoRequest
{
    [Required]
    [MaxLength(8)]
    public string Cep { get; set; }
    
    [Required]
    [StringLength(150, MinimumLength = 2)]
    public string Complemento { get; set; }
    
    [Required]
    public Guid IdUsuario { get; set; }

    public Endereco toDomain()
    {
        return new Endereco(Cep, Complemento, IdUsuario);
    }
}