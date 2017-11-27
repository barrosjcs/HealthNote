using HealthNote.Data.DataContexts;
using HealthNote.Domain;
using HealthNote.Domain.Contracts;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace HealthNote.Data.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly HealthNoteDataContext db;

        public UsuarioRepository()
        {
            db = new HealthNoteDataContext();
        }

        #region Interface
        public void Create(Usuario entity)
        {
            db.Usuarios.Add(entity);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            db.Usuarios.Remove(db.Usuarios.Find(id));
            db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
        }

        public Usuario Get(int id)
        {
            return db.Usuarios.Find(id);
        }

        public List<Usuario> Get(int skip = 0, int take = 25)
        {
            return db.Usuarios.OrderBy(u => u.Id).Skip(skip).Take(take).ToList();
        }

        public void Update(Usuario entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            db.SaveChanges();
        }
        #endregion
    }
}
