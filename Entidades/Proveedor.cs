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

        public Proveedor()
        {

        }

        

        public Proveedor(int proveedor, string sector_comercia, string razon_social, string direccion, string telefono, string email)
        {
            this.ProveedorId = proveedor;
            this.Sector_Comercial = sector_comercia;
            this.Razon_Social = razon_social;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.Email = email;

        }

  
    }
}
