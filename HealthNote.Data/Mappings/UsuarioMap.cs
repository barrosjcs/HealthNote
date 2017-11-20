using HealthNote.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HealthNote.Data.Mappings
{
    public class UsuarioMap : EntityTypeConfiguration<Usuario>
    {
        public UsuarioMap()
        {
            ToTable("Usuario");

            HasKey(x => x.Id);
            Property(x => x.DocumentoId).HasMaxLength(14).IsRequired();
            Property(x => x.Nome).HasMaxLength(20).IsRequired();
            Property(x => x.Sobrenome).HasMaxLength(50).IsRequired();
            Property(x => x.Apelido).HasMaxLength(20);
            Property(x => x.Endereco).HasMaxLength(100);
            Property(x => x.Cidade).HasMaxLength(50);
            Property(x => x.Estado).HasMaxLength(50);
            Property(x => x.Pais).HasMaxLength(20).IsRequired();
            Property(x => x.CEP).HasMaxLength(8).IsRequired();
            Property(x => x.LoginUsu).HasMaxLength(15).IsRequired();
            Property(x => x.SenhaUsu).HasMaxLength(10).IsRequired();
            Property(x => x.Email).HasMaxLength(50).IsRequired();
        }
    }
}
