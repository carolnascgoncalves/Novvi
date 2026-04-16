using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Novvi.Domain.Entities;

namespace Novvi.Infrastructure.Persistence.Configurations;

public class EnderecoConfiguracao : IEntityTypeConfiguration<Endereco>
{
    public void Configure(EntityTypeBuilder<Endereco> builder)
    {
        builder.ToTable("Endereco");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Cep)
            .IsRequired()
            .HasMaxLength(8);
        
        builder.Property(x => x.Complemento)
            .IsRequired()
            .HasMaxLength(150);
        
        builder.HasOne<Usuario>()
            .WithMany()
            .HasForeignKey(x => x.IdUsuario)
            .OnDelete(DeleteBehavior.Cascade);
    }
}