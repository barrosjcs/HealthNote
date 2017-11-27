using HealthNote.Data.Mappings;
using HealthNote.Domain;
using System.Data.Entity;

namespace HealthNote.Data.DataContexts
{
    public class HealthNoteDataContext : DbContext
    {
        public HealthNoteDataContext() : base("HealthNoteConnectionString")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<Medicamento> Medicamentos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new MedicamentoMap());
            modelBuilder.Configurations.Add(new UsuarioMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
