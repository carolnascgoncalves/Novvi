using Novvi.Domain.Entities;

namespace Novvi.Application.DTOs;

public class UserResponse
{
    public Guid Id { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public bool Ativo { get; set; }

    public List<Endereco> Enderecos { get; set; }
    
    public List<Pedido> HistoricoPedidos { get; set; }
    
    public UserResponse(Usuario usuario)
    {
        Id = usuario.Id;
        Nome = usuario.Nome;
        Email = usuario.Email;
        Enderecos = usuario.Enderecos;
        HistoricoPedidos = usuario.HistoricoPedidos;
        Ativo = usuario.Ativo;
    }
}