using Novvi.Domain.Entities;

namespace Novvi.Application.Interfaces.Repositories;

public interface IUserRepository
{
    IReadOnlyCollection<Usuario> GetAll();
    Usuario? GetById(Guid id);
    Usuario? GetByEmail(string email);
    void Add(Usuario user);
    void Update(Usuario user);
    void Delete(Usuario user);
    void SaveChanges();
}