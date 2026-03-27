using Microsoft.EntityFrameworkCore;
using Novvi.Domain.Entities;

public class AppDbContext : DbContext
{
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Funcionario> Funcionarios { get; set; }
    public DbSet<Pedido> Pedidos { get; set; }
    public DbSet<Produto> Produtos { get; set; }
    public DbSet<Pagamento> Pagamentos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlServer("sua_connection_string");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // 1:1 -> Pedido e Pagamento
        modelBuilder.Entity<Pedido>()
            .HasOne(p => p.Pagamento)
            .WithOne(p => p.Pedido)
            .HasForeignKey<Pagamento>(p => p.PedidoId);

        // N:N -> Pedido e Produto
        modelBuilder.Entity<Pedido>()
            .HasMany(p => p.Produtos)
            .WithMany(p => p.Pedidos);

        base.OnModelCreating(modelBuilder);
    }
}