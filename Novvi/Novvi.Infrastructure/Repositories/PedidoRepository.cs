using Novvi.Application.Interfaces.Repositories;
using Novvi.Domain.Entities;
using Novvi.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

public class PedidoRepository : IPedidoRepository
{
    private readonly AppDbContext _context;

    public PedidoRepository(AppDbContext context)
    {
        _context = context;
    }

    public void Add(Pedido pedido)
    {
        _context.Pedidos.Add(pedido);
    }

    public void Update(Pedido pedido)
    {
        _context.Pedidos.Update(pedido);
    }

    public void Delete(Pedido pedido)
    {
        _context.Pedidos.Remove(pedido);
    }

    public IReadOnlyCollection<Pedido> GetAll()
    {
        return _context.Pedidos.ToList();
    }

    public Pedido? GetById(Guid id)
    {
        return _context.Pedidos.FirstOrDefault(p => p.Id == id);
    }

    public void SaveChanges()
    {
        _context.SaveChanges();
    }
}