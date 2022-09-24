using Banda.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Banda.Infra.DataBase.Mapping
{
    public class BandaMap : IEntityTypeConfiguration<Tocar>
    {
        public void Configure(EntityTypeBuilder<Tocar> builder)
        {
            builder.ToTable("TOCAR");

            builder.HasKey(t => t.Id);

            builder.Property(t => t.Id)
                 .UseIdentityColumn()
                    .ValueGeneratedOnAdd();
            

            builder.Property(t => t.Descricao)
                .HasColumnName("DESCRICAO")
                .HasColumnType("VARCHAR")
                .HasMaxLength(200);

            builder.Property(t => t.NomeMusica)
                .HasColumnName("NOME_MUSICA")
                .HasColumnType("VARCHAR")
                .HasMaxLength(50);

            builder.Property(t => t.SequenciaMusica)
             .HasColumnName("SEQUENCIA_MUSICA")
             .HasColumnType("int");
        }
    }
}
