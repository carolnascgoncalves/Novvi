using Novvi.Application.DTOs;
using Novvi.Application.Interfaces.Repositories;
using Novvi.Application.Services.Interfaces;
using Recommenda.Application.Services.Interfaces;

namespace Novvi.Application.Services.Implementations;

public class ProdutoService(IProdutoRepository prodRepository) : IProdutoService
{

    public IReadOnlyCollection<ProdutoResponse> GetAll()
    {
        return prodRepository.GetAll().Select(x => new ProdutoResponse(x)).ToList();
    }
    
    public ProdutoResponse? GetById(Guid id)
    {
        var prod = prodRepository.GetById(id);
        return prod is null ? null : new ProdutoResponse(prod);
    }
    
    public ProdutoResponse Create(ProdutoRequest request)
    {
        var prod = request.ToDomain();
        prodRepository.Add(prod);
        prodRepository.SaveChanges();
        return new ProdutoResponse(prod);
    }
    
    public bool Delete(Guid id)
    {
        var prod = prodRepository.GetById(id);
        if (prod is null)
            return false;

        prodRepository.Delete(prod);
        prodRepository.SaveChanges();
        return true;
    }
}