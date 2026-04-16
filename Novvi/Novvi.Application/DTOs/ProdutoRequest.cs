using System.ComponentModel.DataAnnotations;
using Novvi.Domain.Entities;

namespace Novvi.Application.DTOs;

public class ProdutoRequest
{
    [Required]
    [StringLength(150, MinimumLength = 2)]
    public string Nome { get; set; } = string.Empty;
    
    
    [Required]
    [StringLength(1000, MinimumLength = 2)]
    public string Descricao { get; set; } = string.Empty;
    
    [Required]
    public double Preco { get; set; }
    
    [Required]
    public List<Pedido> Pedidos { get; set; }

    public Produto ToDomain()
    {
        return new Produto(Nome, Descricao, Preco, Pedidos);
    }
}