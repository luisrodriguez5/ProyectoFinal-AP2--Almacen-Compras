using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        
        public Categoria()
        {
           

        }
        public Categoria(int id, int codigo, string nombre, string descripcion)
        {
            this.CategoriaId = id;
            this.Codigo = codigo;
            this.Descripcion = descripcion;
            this.Nombre = nombre;
     
                
        }
    }
}
