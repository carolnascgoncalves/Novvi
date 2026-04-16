using Novvi.Application.DTOs;


namespace Recommenda.Application.Services.Interfaces;

public interface IUsuarioService
{
    IReadOnlyCollection<UsuarioResponse> GetAll();

    UsuarioResponse? GetById(Guid id);

    UsuarioResponse Create(UsuarioRequest request);

    bool Delete(Guid id);
}