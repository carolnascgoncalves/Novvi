using Novvi.Application.Interfaces.Repositories;
using Novvi.Domain.Entities;
using Novvi.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

public class ProdutoRepository : IProdutoRepository
{
    private readonly AppDbContext _context;

    public ProdutoRepository(AppDbContext context)
    {
        _context = context;
    }

    public void Add(Produto produto)
    {
        _context.Produtos.Add(produto);
    }

    public void Update(Produto produto)
    {
        _context.Produtos.Update(produto);
    }

    public void Delete(Produto produto)
    {
        _context.Produtos.Remove(produto);
    }

    public IReadOnlyCollection<Produto> GetAll()
    {
        return _context.Produtos.ToList();
    }

    public Produto? GetById(Guid id)
    {
        return _context.Produtos.FirstOrDefault(p => p.Id == id);
    }

    public void SaveChanges()
    {
        _context.SaveChanges();
    }
}