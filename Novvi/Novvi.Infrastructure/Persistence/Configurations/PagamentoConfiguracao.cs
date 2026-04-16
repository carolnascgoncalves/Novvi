using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Novvi.Domain.Entities;

namespace Novvi.Infrastructure.Persistence.Configurations;

public class PagamentoConfiguracao : IEntityTypeConfiguration<Pagamento>
{
    public void Configure(EntityTypeBuilder<Pagamento> builder)
    {
        builder.ToTable("Pagamento");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.TipoPagamento);

        builder.Property(x => x.Horario)
            .IsRequired();
    }
}