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
    public class ProveedorBLL
    {
        public static bool Guardar(Proveedor proveedor)
        {
            using (var context = new Repository<Proveedor>())
            {
                try
                {
                    if (Buscar(p => p.ProveedorId == proveedor.ProveedorId ) == null)
                    {
                        return context.Guardar(proveedor);
                    }
                    else
                    {
                        return context.Modificar(proveedor);
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
        public static Proveedor Buscar(Expression<Func<Proveedor, bool>> criterio)
        {
            using (var context = new Repository<Proveedor>())
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

        public static bool Eliminar(Proveedor proveedor)
        {
            using (var context = new Repository<Proveedor>())
            {
                try
                {
                    return context.Eliminar(proveedor);
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
        public static bool Modificar(Proveedor proveedor)
        {
            using (var context = new Repository<Proveedor>())
            {
                try
                {
                    return context.Modificar(proveedor);
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public static List<Proveedor> GetList(Expression<Func<Proveedor, bool>> criterio)
        {
            using (var context = new Repository<Proveedor>())
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

        public static List<Proveedor> GetListAll()
        {
            using (var context = new Repository<Proveedor>())
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
        public static Proveedor BuscarOtro(int id)
        {
            using (var context = new DAL.Repository<Proveedor>())
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
