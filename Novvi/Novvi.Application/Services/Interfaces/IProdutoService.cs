using Novvi.Application.DTOs;


namespace Novvi.Application.Services.Interfaces;

public interface IProdutoService
{
    IReadOnlyCollection<UsuarioResponse> GetAll();

    UsuarioResponse? GetById(Guid id);
    
    
}