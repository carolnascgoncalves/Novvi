using Novvi.Domain.Entities;

namespace Novvi.Application.Interfaces.Repositories;

public interface IPagamentoRepository
{
    IReadOnlyCollection<Pagamento> GetAll();
    Pagamento? GetById(Guid id);
    void Add(Pagamento content);
    void Update(Pagamento content);
    void Delete(Pagamento content);
    void SaveChanges();
}