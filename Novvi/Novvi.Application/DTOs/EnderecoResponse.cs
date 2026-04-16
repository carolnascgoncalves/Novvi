using Novvi.Domain.Entities;

namespace Novvi.Application.DTOs;

public class EnderecoResponse
{
    public Guid Id { get; set; }
    public string Cep { get; set; }
    public string Complemento { get; set; }
    public Guid IdUsuario { get; set; }

    public EnderecoResponse(Endereco endereco)
    {
        Id = endereco.Id;
        Cep = endereco.Cep;
        Complemento = endereco.Complemento;
        IdUsuario = endereco.IdUsuario;
    }
}