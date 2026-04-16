using System.ComponentModel.DataAnnotations;
using Novvi.Domain.Entities;

namespace Novvi.Application.DTOs;

public class UsuarioRequest
{
    [Required]
    [StringLength(150, MinimumLength = 2)]
    public string Name { get; set; } = string.Empty;
    
    [Required]
    [EmailAddress]
    [StringLength(200)]
    public string Email { get; set; } = string.Empty;
    
    [Required]
    public List<Endereco> Enderecos { get; set; }
    
    public Usuario ToDomain()
    {
        return new Usuario(Name, Email, Enderecos);
    }
}