using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Presentacion
    {
        [Key]
        public int PresentacionId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
       

        public Presentacion()
        {
           
                
        }
    }
}
