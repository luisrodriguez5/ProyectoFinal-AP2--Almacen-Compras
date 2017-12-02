using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ingreso
    {
        [Key]
        public int IngresoId { get; set; }
        public int ProvedorId { get; set; }
        public DateTime Fecha { get; set; }
        //public int ProductoId { get; set; }
        public int NumIngreso { get; set; }
        public decimal Itbis { get; set; }
        public decimal Costo_Compra { get; set; }
        public int Inventario_Inicial { get; set; }
        public int Inventario_Actual { get; set; }
        public DateTime Fecha_Ingreso { get; set; }
        public DateTime Fecha_Vencimiento { get; set; }

        public List<Ingreso> Detalle;
        public virtual ICollection<Detalle_Ingreso> Relacion { get; set; }
       

        public Ingreso()
        { 
            this.Relacion = new HashSet<Detalle_Ingreso>();

            //Proveedor = new Proveedor();
        }

        public Ingreso(int id, int proveedor, DateTime fecha, decimal costo)
        {
            this.IngresoId = id;
            this.ProvedorId = proveedor;
            this.Fecha = fecha;
            this.Costo_Compra = costo;
        }

        public void AgregarDetalle(int ingresoId, int proveedor, DateTime fecha, decimal costo)
        {
            Detalle.Add(new Ingreso(ingresoId, proveedor, fecha, costo));


        }

    }


}
