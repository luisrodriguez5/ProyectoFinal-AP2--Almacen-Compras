using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PresentancionBLL
    {
        public static bool Guardar(Categoria categoria)
        {
            using (var context = new Repository<Categoria>())
            {
                try
                {
                    if (Buscar(p => p.CategoriaId == categoria.CategoriaId) == null)
                    {
                        return context.Guardar(categoria);
                    }
                    else
                    {
                        return context.Modificar(categoria);
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
        public static Categoria Buscar(Expression<Func<Categoria, bool>> criterio)
        {
            using (var context = new Repository<Categoria>())
            {
                try
                {
                    return context.Buscar(criterio);
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public static bool Eliminar(Categoria categoria)
        {
            using (var context = new Repository<Categoria>())
            {
                try
                {
                    return context.Eliminar(categoria);
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
        public static bool Modificar(Categoria categoria)
        {
            using (var context = new Repository<Categoria>())
            {
                try
                {
                    return context.Modificar(categoria);
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public static List<Categoria> GetList(Expression<Func<Categoria, bool>> criterio)
        {
            using (var context = new Repository<Categoria>())
            {
                try
                {
                    return context.GetList(criterio);
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public static List<Categoria> GetListAll()
        {
            using (var context = new Repository<Categoria>())
            {
                try
                {
                    return context.GetListTodo();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
        public static Categoria BuscarOtro(int id)
        {
            using (var context = new Repository<Categoria>())
            {
                try
                {
                    return context.BuscarOtro(id);
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

    }
}
