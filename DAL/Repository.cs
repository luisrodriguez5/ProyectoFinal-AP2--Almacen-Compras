using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        SistemaTechDb Conec = null;
        public Repository()
        {
            Conec = new SistemaTechDb();
        }
        private DbSet<TEntity> EntitySet
        {
            get
            {
                return Conec.Set<TEntity>();
            }
        }
        public TEntity Buscar(Expression<Func<TEntity, bool>> criterio)
        {
            try
            {
                return EntitySet.FirstOrDefault(criterio);

            }
            catch (Exception)
            {

                throw;
            }
        }

        
        public TEntity BuscarOtro(int id)
        {
            try
            {
                return EntitySet.Find(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Dispose()
        {
            if (Conec != null)
            {
                Conec.Dispose();
            }
        }

        public bool Eliminar(TEntity Id)
        {
            try
            {
                EntitySet.Attach(Id);
                EntitySet.Remove(Id);
                return Conec.SaveChanges() > 0;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> buscar)
        {
            try
            {
                return EntitySet.Where(buscar).ToList();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<TEntity> GetListTodo()
        {
            try
            {
                return EntitySet.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Guardar(TEntity nuevo)
        {
            EntitySet.Add(nuevo);
            return Conec.SaveChanges() > 0;
        }

        public bool Modificar(TEntity criterio)
        {
            EntitySet.Attach(criterio);
            Conec.Entry(criterio).State = EntityState.Modified;
            return Conec.SaveChanges() > 0;
        }
    }
}
