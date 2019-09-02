using App.TailorIT.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.TailorIT.Infra.Data.Mappings
{
    public class UsuarioMapping : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(u => u.UsuarioId);

            builder.Property(u => u.Nome)
                .IsRequired()
                .HasColumnType("varchar(200)")
                .HasColumnName("Nome");

            builder.Property(u => u.DataNascimento)
                .IsRequired()
                .HasColumnType("DateTime")
                .HasColumnName("DataNascimento");

            builder.Property(u => u.Email)
                .HasColumnType("varchar(100)")
                .HasColumnName("Email");

            builder.Property(u => u.Senha)
                .HasColumnType("varchar(100)")
                .HasColumnName("Senha");

            builder.Property(u => u.Ativo)
                .HasColumnName("Ativo");

            builder.HasOne(u => u.Sexo)
                .WithOne(s => s.Usuario);

            builder.ToTable("Usuarios");

        }
    }
}
