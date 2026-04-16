using Novvi.Domain.Entities;

namespace Novvi.Application.Interfaces.Repositories;

public interface IProdutoRepository
{
    IReadOnlyCollection<Produto> GetAll();
    Produto? GetById(Guid id);
    void Add(Produto content);
    void Update(Produto content);
    void Delete(Produto content);
    void SaveChanges();
}