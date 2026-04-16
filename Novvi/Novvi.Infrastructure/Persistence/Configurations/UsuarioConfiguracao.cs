using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Novvi.Domain.Entities;

namespace Novvi.Infrastructure.Persistence.Configurations;

public class UsuarioConfiguracao : IEntityTypeConfiguration<Usuario>
{
    public void Configure(EntityTypeBuilder<Usuario> builder)
    {
        builder.ToTable("Usuario");
        
        
        builder.Property(x => x.Nome)
            .IsRequired()
            .HasMaxLength(150);
        
        builder.Property(x => x.Email)
            .IsRequired()
            .HasMaxLength(200);
        builder.HasIndex(x => x.Email)
            .IsUnique();
        
        
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Ativo)
            .IsRequired();
        
        
    }
}