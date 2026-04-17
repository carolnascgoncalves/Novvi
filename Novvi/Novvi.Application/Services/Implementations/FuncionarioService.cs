using Novvi.Application.DTOs;
using Novvi.Application.Interfaces.Repositories;
using Novvi.Application.Services.Interfaces;

namespace Novvi.Application.Services.Implementations;

public class FuncionarioService(IFuncionarioRepository repository) : IFuncionarioService
{
    public IReadOnlyCollection<FuncionarioResponse> GetAll()
    {
        return repository.GetAll().Select(x => new FuncionarioResponse(x)).ToList();
    }

    public FuncionarioResponse? GetById(Guid id)
    {
        var func = repository.GetById(id);
        return func is null ? null : new FuncionarioResponse(func);
    }

    public FuncionarioResponse Create(FuncionarioRequest request)
    {
        var func = request.ToDomain();
        repository.Add(func);
        repository.SaveChanges();
        return new FuncionarioResponse(func);
    }

    public bool Delete(Guid id)
    {
        var func = repository.GetById(id);
        if (func is null)
            return false;

        repository.Delete(func);
        repository.SaveChanges();
        return true;
    }
}

