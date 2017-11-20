using HealthNote.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HealthNote.Data.Mappings
{
    public class MedicamentoMap : EntityTypeConfiguration<Medicamento>
    {
        public MedicamentoMap()
        {
            ToTable("Medicamento");

            HasKey(x => x.Id);
            HasKey(x => x.IdUsuario);
            Property(x => x.Nome).HasMaxLength(100).IsRequired();
            Property(x => x.Medico).HasMaxLength(100);
            Property(x => x.Indicacao).HasMaxLength(100).IsRequired();
            Property(x => x.PrincipioAtivo).HasMaxLength(100);
            Property(x => x.AcaoTerapeutica).HasMaxLength(100);
            Property(x => x.Laboratorio).HasMaxLength(50);
            Property(x => x.Obs);
        }
    }
}
