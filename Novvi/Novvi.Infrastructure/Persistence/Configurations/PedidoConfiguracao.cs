using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Novvi.Domain.Entities;

namespace Novvi.Infrastructure.Persistence.Configurations;

public class PedidoConfiguracao : IEntityTypeConfiguration<Pedido>
{
    public void Configure(EntityTypeBuilder<Pedido> builder)
    {
        builder.ToTable("Pedido");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Frete);
        
        builder.Property(x => x.Data)
            .IsRequired();
        
        builder.Property(x => x.Ativo)
            .IsRequired();
        
        builder.HasMany(x => x.Produtos)
            .WithMany(x => x.Pedidos)
            .UsingEntity<Dictionary<string, object>>(
                "PJ_ContentGenre",
                right => right.HasOne<Produto>()
                    .WithMany()
                    .HasForeignKey("ProdutoId")
                    .OnDelete(DeleteBehavior.Cascade),
                left => left.HasOne<Pedido>()
                    .WithMany()
                    .HasForeignKey("PedidoId")
                    .OnDelete(DeleteBehavior.NoAction),
                join =>
                {
                    join.ToTable("Ped_Prod");
                    join.HasKey("ProdutoId", "PedidoId");
                });
        
        builder.HasOne<Funcionario>()
            .WithMany()
            .HasForeignKey(x => x.IdFuncinario)
            .OnDelete(DeleteBehavior.Cascade);
        
        builder.HasOne<Usuario>()
            .WithMany()
            .HasForeignKey(x => x.IdUsuario)
            .OnDelete(DeleteBehavior.Cascade);
    }
}