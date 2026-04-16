using Novvi.Application.DTOs;


namespace Novvi.Application.Services.Interfaces;

public interface IEnderecoService
{
    IReadOnlyCollection<EnderecoResponse> GetAll();

    EnderecoResponse? GetById(Guid id);

    EnderecoResponse Create(EnderecoRequest request);

    bool Delete(Guid id);
    
    EnderecoResponse? Update(Guid id, EnderecoRequest enderecoRequest);
}