using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Productos
    {
        [Key]
        public int ProductoId { get; set; }
        public decimal Costo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int CategoriaId { get; set; }
        public string Nombre_Categoria { get; set; }
        public int PresentacionId { get; set; }

        public virtual ICollection<Detalle_Ingreso> Relacion  { get; set; }

        public Categoria Detalle { get; set; }
        //public Presentacion presentacio { get; set; }


        public Productos()
        {
            Detalle = new Categoria();
           
            //Relacion = new HashSet<Detalle_Ingreso>();
        }

        public Productos(int productoId, string descripcion, decimal costo, string nombre, string categoria)
        {
            this.ProductoId = productoId;
            this.Descripcion = descripcion;
            this.Nombre = nombre;
            this.Costo = costo;
            this.Nombre_Categoria = categoria;
         
        }

    }
}
