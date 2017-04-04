using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Detalle_Ingreso
    {
        [Key]
        public int Detalle_IngresoId { get; set; }
        public int IngresoId { get; set; }
        public int ProductoId { get; set; }
        public decimal Costo_Compra { get; set; }
        public int Inventario_Inicial { get; set; }
        public int Inventario_Actual { get; set; }
        public DateTime Fecha_Ingreso { get; set; }
        public DateTime Fecha_Vencimiento { get; set; }
        public Productos producto { get; set; }
        public Ingreso Ingreso { get; set; }
        public Detalle_Ingreso()
        {
            
        }

    }
}
