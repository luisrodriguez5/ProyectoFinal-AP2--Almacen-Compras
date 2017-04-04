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
    public class IngresoBLL
    {
        public static bool Guardar(Ingreso ingreso)
        {
            using (var context = new Repository<Ingreso>())
            {
                try
                {
                    if (Buscar(p => p.IngresoId == ingreso.IngresoId) == null)
                    {
                        return context.Guardar(ingreso);
                    }
                    else
                    {
                        return context.Modificar(ingreso);
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
        public static Ingreso Buscar(Expression<Func<Ingreso, bool>> criterio)
        {
            using (var context = new Repository<Ingreso>())
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

        public static bool Eliminar(Ingreso ingreso)
        {
            using (var context = new Repository<Ingreso>())
            {
                try
                {
                    return context.Eliminar(ingreso);
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
        public static bool Modificar(Ingreso ingreso)
        {
            using (var context = new Repository<Ingreso>())
            {
                try
                {
                    return context.Modificar(ingreso);
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public static List<Ingreso> GetList(Expression<Func<Ingreso, bool>> criterio)
        {
            using (var context = new Repository<Ingreso>())
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

        public static List<Ingreso> GetListAll()
        {
            using (var context = new Repository<Ingreso>())
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
        public static Ingreso BuscarOtro(int id)
        {
            using (var context = new Repository<Ingreso>())
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
