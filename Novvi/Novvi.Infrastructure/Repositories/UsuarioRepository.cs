using Novvi.Application.Interfaces.Repositories;
using Novvi.Domain.Entities;
using Novvi.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

public class UsuarioRepository : IUsuarioRepository
{
    private readonly AppDbContext _context;

    public UsuarioRepository(AppDbContext context)
    {
        _context = context;
    }

    public void Add(Usuario usuario)
    {
        _context.Usuarios.Add(usuario);
    }

    public void Update(Usuario usuario)
    {
        _context.Usuarios.Update(usuario);
    }

    public void Delete(Usuario usuario)
    {
        _context.Usuarios.Remove(usuario);
    }

    public IReadOnlyCollection<Usuario> GetAll()
    {
        return _context.Usuarios.ToList();
    }

    public Usuario? GetById(Guid id)
    {
        return _context.Usuarios.FirstOrDefault(u => u.Id == id);
    }

    public Usuario? GetByEmail(string email)
    {
        return _context.Usuarios.FirstOrDefault(u => u.Email == email);
    }

    public void SaveChanges()
    {
        _context.SaveChanges();
    }
}