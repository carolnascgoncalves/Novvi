using Novvi.Application.DTOs;
using Novvi.Application.Interfaces.Repositories;
using Novvi.Application.Services.Interfaces;

namespace Novvi.Application.Services.Implementations;

public class EnderecoService(IEnderecoRepository repository) : IEnderecoService
{
    public IReadOnlyCollection<EnderecoResponse> GetAll()
    {
        return repository.GetAll().Select(x => new EnderecoResponse(x)).ToList();
    }

    public EnderecoResponse ? GetById(Guid id)
    {
        var end = repository.GetById(id);
        return end is null ? null : new EnderecoResponse(end);
        
    }

    public EnderecoResponse? Update(Guid id, EnderecoRequest request)
    {
        var endereco = repository.GetById(id);

        if (endereco is null)
            return null;
        
        var atualizado = request.ToDomain();

        repository.Update(atualizado);
        repository.SaveChanges();

        return new EnderecoResponse(atualizado);
    }
    
    public EnderecoResponse Create(EnderecoRequest request)
    {
        var end = request.ToDomain();
        repository.Add(end);
        repository.SaveChanges();
        return new EnderecoResponse(end);
    }

    public bool Delete(Guid id)
    {
        var end = repository.GetById(id);
        if (end is null)
            return false;

        repository.Delete(end);
        repository.SaveChanges();
        return true;
    }
}