using Novvi.Application.DTOs;
using Novvi.Application.Interfaces.Repositories;
using Novvi.Application.Services.Interfaces;

namespace Novvi.Application.Services.Implementations;

public class PagamentoService(IPagamentoRepository repository) : IPagamentoService
{
    public IReadOnlyCollection<PagamentoResponse> GetAll()
    {
        return repository.GetAll().Select(x => new PagamentoResponse(x)).ToList();
    }

    public PagamentoResponse? GetById(Guid id)
    {
        var pag = repository.GetById(id);
        return pag is null ? null : new PagamentoResponse(pag);
    }

    public PagamentoResponse Create(PagamentoRequest request)
    {
        var pag = request.ToDomain();
        repository.Add(pag);
        repository.SaveChanges();
        return new PagamentoResponse(pag);
    }

    public bool Delete(Guid id)
    {
        var pag = repository.GetById(id);
        if (pag is null)
            return false;

        repository.Delete(pag);
        repository.SaveChanges();
        return true;
    }
}