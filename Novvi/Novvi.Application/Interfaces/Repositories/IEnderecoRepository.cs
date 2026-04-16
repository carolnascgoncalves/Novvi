using Novvi.Domain.Entities;

namespace Novvi.Application.Interfaces.Repositories;

public interface IEnderecoRepository
{
    IReadOnlyCollection<Endereco> GetAll();
    Endereco? GetById(Guid id);
    void Add(Endereco content);
    void Update(Endereco content);
    void Delete(Endereco content);
    void SaveChanges();
}
