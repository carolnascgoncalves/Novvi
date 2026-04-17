using Novvi.Domain.Entities;

namespace Novvi.Application.Interfaces.Repositories;

public interface IFuncionarioRepository
{
    IReadOnlyCollection<Funcionario> GetAll();
    Funcionario? GetById(Guid id);
    void Add(Funcionario user);
    void Update(Funcionario user);
    void Delete(Funcionario user);
    void SaveChanges();
}