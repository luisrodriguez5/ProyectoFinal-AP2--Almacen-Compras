using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public int NumIngreso { get; set; }
        public decimal Itbis { get; set; }
        public Proveedor Proveedor  { get; set; }
        public virtual ICollection<Detalle_Ingreso> Relacion  { get; set; }


        public Ingreso()
        {
            Proveedor = new Proveedor();
            Relacion = new HashSet<Detalle_Ingreso>();

        }
    }


}
