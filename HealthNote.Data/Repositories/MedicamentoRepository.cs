using HealthNote.Data.DataContexts;
using HealthNote.Domain;
using HealthNote.Domain.Contracts;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace HealthNote.Data.Repositories
{
    public class MedicamentoRepository : IMedicamentoRepository
    {
        private readonly HealthNoteDataContext db;
        
        public MedicamentoRepository()
        {
            db = new HealthNoteDataContext();
        }

        #region Interface
        public void Create(Medicamento entity)
        {
            db.Medicamentos.Add(entity);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            db.Medicamentos.Remove(db.Medicamentos.Find(id));
            db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
        }

        public Medicamento Get(int id)
        {
            return db.Medicamentos.Find(id);
        }

        public List<Medicamento> Get(int skip = 0, int take = 25)
        {
            return db.Medicamentos.OrderBy(m => m.Nome).Skip(skip).Take(take).ToList();
        }

        public void Update(Medicamento entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            db.SaveChanges();
        }
        #endregion
    }
}
