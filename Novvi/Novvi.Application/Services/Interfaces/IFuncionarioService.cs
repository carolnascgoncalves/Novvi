using Novvi.Application.DTOs;


namespace Novvi.Application.Services.Interfaces;

public interface IFuncionarioService
{
    IReadOnlyCollection<FuncionarioResponse> GetAll();

    FuncionarioResponse? GetById(Guid id);

    FuncionarioResponse Create(FuncionarioRequest request);

    bool Delete(Guid id);
}