using Novvi.Application.DTOs;
using Novvi.Application.Interfaces.Repositories;
using Novvi.Application.Services.Interfaces;
using Recommenda.Application.Services.Interfaces;

namespace Novvi.Application.Services.Implementations;

public class UsuarioService(IUsuarioRepository usuarRepository) : IUsuarioService
{

    public IReadOnlyCollection<UsuarioResponse> GetAll()
    {
        return usuarRepository.GetAll().Select(x => new UsuarioResponse(x)).ToList();
    }
    
    public UsuarioResponse? GetById(Guid id)
    {
        var user = usuarRepository.GetById(id);
        return user is null ? null : new UsuarioResponse(user);
    }
    
    public UsuarioResponse Create(UsuarioRequest request)
    {
        var existingUser = usuarRepository.GetByEmail(request.Email);
        if (existingUser is not null)
            throw new InvalidOperationException("Email já cadastrado");

        var user = request.ToDomain();
        usuarRepository.Add(user);
        usuarRepository.SaveChanges();
        return new UsuarioResponse(user);
    }
    
    public bool Delete(Guid id)
    {
        var user = usuarRepository.GetById(id);
        if (user is null)
            return false;

        usuarRepository.Delete(user);
        usuarRepository.SaveChanges();
        return true;
    }
}