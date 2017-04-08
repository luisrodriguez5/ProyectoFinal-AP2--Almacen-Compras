using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SistemaTechDb: DbContext
    {
        public SistemaTechDb(): base("ConStr")
        {

        }
        public DbSet<Productos> Producto  { get; set; }
        public DbSet<Proveedor> Proveedor { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Presentacion> Presentacion  { get; set; }
        public DbSet<Ingreso> Ingreso  { get; set; }
        public DbSet<Detalle_Ingreso> Detalle_Ingreso { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }

    }
}
