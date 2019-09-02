using App.TailorIT.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.TailorIT.Infra.Data.Mappings
{
    public class SexoMapping : IEntityTypeConfiguration<Sexo>
    {
        public void Configure(EntityTypeBuilder<Sexo> builder)
        {
            builder.HasKey(s => s.SexoId);

            builder.Property(s => s.Descricao)
                .HasColumnType("varchar(15)")
                .HasColumnName("Descricao");

            builder.ToTable("Sexo");
        }
    }
}
