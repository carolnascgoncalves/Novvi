using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Novvi.Domain.Entities;

namespace Novvi.Infrastructure.Persistence.Configurations;

public class ProdutoConfiguracao : IEntityTypeConfiguration<Produto>
{
    public void Configure(EntityTypeBuilder<Produto> builder)
    {
        builder.ToTable("Produto");

        builder.HasKey(x => x.Id);
   
        builder.Property(x => x.Descricao)
            .IsRequired()
            .HasMaxLength(1000);

        builder.Property(x => x.Preco)
            .IsRequired();
        
        builder.Property(x => x.Nome)
            .IsRequired()
            .HasMaxLength(100);
        
        builder.Property(x => x.Ativo)
            .IsRequired();
    }
}