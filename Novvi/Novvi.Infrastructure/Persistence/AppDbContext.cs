using Microsoft.EntityFrameworkCore;
using Novvi.Domain.Entities;
namespace Novvi.Infrastructure.Persistence;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Funcionario> Funcionarios { get; set; }
    public DbSet<Pedido> Pedidos { get; set; }
    public DbSet<Produto> Produtos { get; set; }
    public DbSet<Pagamento> Pagamentos { get; set; }
    public DbSet<Endereco> Enderecos { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        base.OnModelCreating(modelBuilder);
    }
    
}