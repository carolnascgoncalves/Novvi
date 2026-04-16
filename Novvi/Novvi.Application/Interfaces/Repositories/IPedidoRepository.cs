using Novvi.Domain.Entities;

namespace Novvi.Application.Interfaces.Repositories;

public interface IPedidoRepository
{
    IReadOnlyCollection<Pedido> GetAll();
    Pedido? GetById(Guid id);
    void Add(Pedido content);
    void Update(Pedido content);
    void Delete(Pedido content);
    void SaveChanges();
}