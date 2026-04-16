using Novvi.Application.DTOs;


namespace Novvi.Application.Services.Interfaces;

public interface IProdutoService
{
    IReadOnlyCollection<ProdutoResponse> GetAll();

    ProdutoResponse? GetById(Guid id);
    
    
}