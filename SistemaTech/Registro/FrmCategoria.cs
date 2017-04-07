using BLL;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaTech.Registro
{
    public partial class FrmCategoria : Form
    {
        public bool IsNuevo = false;
        public List<Categoria>Lista { get; set; }
        public bool Editar = false;

        public FrmCategoria()
        {
            InitializeComponent();
            this.toolTip1.SetToolTip(this.nombreTextBox, "Ingrese El Nombre De La Categoria");
            this.toolTip1.SetToolTip(this.CodigotextBox2, "Ingrese El Codigo de la Categoria");
            this.toolTip1.SetToolTip(this.descripcionTextBox, "Ingrese La Descripcion Que pertenece La Categoria");
        }

        private Categoria LlenarCampos()
        {
            Categoria categoria = new Categoria();

            categoria.CategoriaId = Utilidades.TOINT(CategoriaIdTextBox.Text);
            categoria.Descripcion = descripcionTextBox.Text;
            categoria.Nombre = nombreTextBox.Text;
            categoria.Codigo = Utilidades.TOINT(CodigotextBox2.Text);


            return categoria;
        }
        private void MesajeOk(string Mesaje)
        {
            MessageBox.Show(Mesaje, "Sistema De Almacen ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //Mostrar mesaje de Erro
        private void MesajeError(string Mesaje)
        {
            MessageBox.Show(Mesaje, "Sistema De Almacen ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void Limpiar()
        {
            nombreTextBox.Clear();
            descripcionTextBox.Clear();
            CodigotextBox2.Clear();
            CategoriaIdTextBox.Clear();

        }
        //Habilitar Controles
        private void Habilitar(bool valor)
        {
            nombreTextBox.ReadOnly = !valor;
            descripcionTextBox.ReadOnly = !valor;
            CodigotextBox2.ReadOnly = !valor;
            CategoriaIdTextBox.ReadOnly = !valor;


        }

        //Habilitar Botones
        private void Botones()
        {
            if (IsNuevo || Editar)
            {
                Habilitar(true);
                btnNuevo.Enabled = true;
                btnGuardar.Enabled = true;
                btnEliminae.Enabled = false;
            }

            else
            {
                Habilitar(false);
                btnNuevo.Enabled = true;
                btnGuardar.Enabled = false;
                btnEliminae.Enabled = false;

            }
        }
     

  


        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            Top = 0;
            Left = 0;

            Habilitar(false);
            Botones();

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

       

    
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            IsNuevo = true;

            Botones();
            Limpiar();
            Habilitar(true);
            nombreTextBox.Focus();
        }

        private bool Validar()
        {
            bool interruptor = true;

            if (string.IsNullOrEmpty(descripcionTextBox.Text))
            {
                errorProvider1.SetError(descripcionTextBox, "Por favor llenar el campo vacio.");
                interruptor = false;
            }
            if (string.IsNullOrWhiteSpace(nombreTextBox.Text))
            {
                errorProvider1.SetError(nombreTextBox, "Por favor llenar el campo vacio.");
                interruptor = false;
            }
            if (string.IsNullOrEmpty(CodigotextBox2.Text))
            {
                errorProvider1.SetError(CodigotextBox2, "Por favor llenar el campo vacio.");
                interruptor = false;
            }


            return interruptor;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria();

            if (!Validar())
            {
                MesajeError("Favor llenar los campos Vacios");
            }
            else
            {
                categoria = LlenarCampos();

                if (CategoriaBLL.Guardar(categoria))
                {
                    MesajeOk("Se Guardo con exito");
                    Limpiar();
                }
                else
                    MesajeError("Error! no se pudo guardar.");
            }

        }

  

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            btnEliminae.Enabled = true;
            btnGuardar.Enabled = true;
            if (string.IsNullOrEmpty(CategoriaIdTextBox.Text))
            {
                MessageBox.Show("Por favor insertar el id que desea buscar.");
                Limpiar();
            }
            else
            {
                int id = Utilidades.TOINT(CategoriaIdTextBox.Text);
                Categoria categoria = new Categoria();

                categoria = CategoriaBLL.Buscar(p => p.CategoriaId == id);

                if (categoria != null)
                {
                    descripcionTextBox.Text = categoria.Descripcion;
                    nombreTextBox.Text = categoria.Nombre;
                    CodigotextBox2.Text = categoria.Codigo.ToString();
                   
                }
                else
                {
                    MessageBox.Show("El Producto no exite.");
                    Limpiar();
                }
            }
        }


 

        private void btnEliminae_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CategoriaIdTextBox.Text))
            {
                MessageBox.Show("Por favor Ingrese el Id del Producto a Eliminar.");
                Limpiar();
            }
            else
            {
                DialogResult eliminar = MessageBox.Show("¿Seguro desea eliminar el producto seleccionado?", "¡Advertencia!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (eliminar == DialogResult.OK)
                {
                    int id = Utilidades.TOINT(CategoriaIdTextBox.Text);

                    if (CategoriaBLL.Eliminar(CategoriaBLL.Buscar(p => p.CategoriaId == id)))
                    {
                        Limpiar();
                        MesajeOk("Producto Eliminado con exito");
                    }
                    else
                        MesajeError("No se ah podido Eliminar el producto");
                }
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
