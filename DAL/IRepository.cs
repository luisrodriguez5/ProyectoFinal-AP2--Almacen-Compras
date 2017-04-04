using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IRepository<TEntity>:IDisposable where TEntity : class
    {
        bool Guardar(TEntity nuevo);
        bool Eliminar(TEntity Id);
        bool Modificar(TEntity criterio);
        TEntity Buscar(Expression<Func<TEntity, bool>> criterio);
        TEntity BuscarOtro(int id);
        List<TEntity> GetListTodo();
        List<TEntity> GetList(Expression<Func<TEntity, bool>> buscar);

    }
}
