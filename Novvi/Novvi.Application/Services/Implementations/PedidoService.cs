using Novvi.Application.DTOs;
using Novvi.Application.Interfaces.Repositories;
using Novvi.Application.Services.Interfaces;

namespace Novvi.Application.Services.Implementations;

public class PedidoService(IPedidoRepository repository) : IPedidoService
{
    public IReadOnlyCollection<PedidoResponse> GetAll()
    {
        return repository.GetAll().Select(x => new PedidoResponse(x)).ToList();
    }

    public PedidoResponse? GetById(Guid id)
    {
        var ped = repository.GetById(id);
        return ped is null ? null : new PedidoResponse(ped);
    }

    public PedidoResponse Create(PedidoRequest request)
    {
        var ped = request.ToDomain();
        repository.Add(ped);
        repository.SaveChanges();
        return new PedidoResponse(ped);
    }

    public bool Delete(Guid id)
    {
        var ped = repository.GetById(id);
        if (ped is null)
            return false;

        repository.Delete(ped);
        repository.SaveChanges();
        return true;
    }
}