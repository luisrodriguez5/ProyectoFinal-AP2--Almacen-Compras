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
    public class PresentacionBLL
    {
        public static bool Guardar(Presentacion presentacion)
        {
            using (var context = new Repository<Presentacion>())
            {
                try
                {
                    if (Buscar(p => p.PresentacionId == presentacion.PresentacionId) == null)
                    {
                        return context.Guardar(presentacion);
                    }
                    else
                    {
                        return context.Modificar(presentacion);
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
        public static Presentacion Buscar(Expression<Func<Presentacion, bool>> criterio)
        {
            using (var context = new Repository<Presentacion>())
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

        public static bool Eliminar(Presentacion presentacion)
        {
            using (var context = new Repository<Presentacion>())
            {
                try
                {
                    return context.Eliminar(presentacion);
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
        public static bool Modificar(Presentacion presentacion)
        {
            using (var context = new Repository<Presentacion>())
            {
                try
                {
                    return context.Modificar(presentacion);
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public static List<Presentacion> GetList(Expression<Func<Presentacion, bool>> criterio)
        {
            using (var context = new Repository<Presentacion>())
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

        public static List<Presentacion> GetListAll()
        {
            using (var context = new Repository<Presentacion>())
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
        public static Presentacion BuscarOtro(int id)
        {
            using (var context = new Repository<Presentacion>())
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
