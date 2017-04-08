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
       
        public Ingreso ingreso { get; set; }
       
       
        public Detalle_Ingreso()
        {
           
        }

    }
}
