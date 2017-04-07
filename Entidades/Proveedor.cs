using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Proveedor
    {
        [Key]
        public int ProveedorId { get; set; }
        public string Sector_Comercial { get; set; }
        public string Razon_Social { get; set; }
        public int Num_Documento { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Ingreso> Relacion  { get; set; }

        public Proveedor()
        {
            Relacion = new HashSet<Ingreso>();

        }

    }
}
