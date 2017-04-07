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
    public partial class FormProductos : Form
    {
        public bool IsNuevo = false;
        public bool flag = false;
        public List<Entidades.Productos> Lista { get; set; }
        public bool Editar = false;
        private static FormProductos _Instacia;

        
        public FormProductos GetInstancia()
        {
           if(_Instacia == null)
            {
                _Instacia = new FormProductos();
            }

            return _Instacia;
        }

        public void setCategoria(string categoriId, string categoria)
        {
            
                this.texIdCategoria.Text = categoriId;
                this.textCategoria.Text = categoria;
          

        }


        public FormProductos()
        {
            InitializeComponent();
            this.toolTip1.SetToolTip(this.nombreTextBox, "Ingrese El Nombre Del Producto");
            this.textCategoria.ReadOnly = true;
            this.texIdCategoria.Visible = true;
         

            LlenarCombox();
            //OcultarCulunas();
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {
            Top = 0;
            Left = 0;

            Habilitar(false);
            Botones();
            
        }
        


        private Productos LlenarCampos()
        {
            Productos producto = new Productos();
          

            producto.ProductoId = Utilidades.TOINT(productoIdTextBox.Text);
            producto.Descripcion = descripcionTextBox.Text;
            producto.Costo = Utilidades.TODECIMAL(codigoTextBox.Text);
            producto.Nombre = nombreTextBox.Text;
            producto.Detalle.CategoriaId = Utilidades.TOINT(texIdCategoria.Text);
            producto.Detalle.Nombre = textCategoria.Text;
            

            
       

            return producto;
        }
        private void LlenarCombox()
        {
            comboBoxCategoria.DataSource = PresentacionBLL.GetListAll();
            comboBoxCategoria.ValueMember = "PresentacionId";
            comboBoxCategoria.DisplayMember = "Nombre";

        }

        //Motrar mesaje de confirmacion
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
            codigoTextBox.Clear();
            productoIdTextBox.Clear();
            textCategoria.Clear();
            texIdCategoria.Clear();

        }

        //Habilitar Controles
        private void Habilitar(bool valor)
        {
            nombreTextBox.ReadOnly = !valor;
            descripcionTextBox.ReadOnly = !valor;
            codigoTextBox.ReadOnly = !valor;
            productoIdTextBox.ReadOnly = !valor;
           
            btnBuscarCategotia.Enabled = valor;
            comboBoxCategoria.Enabled = valor;

        }
        //Habilitar Botones
        private void Botones()
        {
            if(IsNuevo || Editar)
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
                btnGuardar.Enabled = false ;
                btnEliminae.Enabled = false;
               
            }
        }
   



        private void groupBox1_Enter(object sender, EventArgs e)
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
            if (string.IsNullOrWhiteSpace (nombreTextBox.Text))
            {
                errorProvider1.SetError(nombreTextBox, "Por favor llenar el campo vacio.");
                interruptor = false;
            }
            if (string.IsNullOrEmpty(codigoTextBox.Text))
            {
                errorProvider1.SetError(codigoTextBox, "Por favor llenar el campo vacio.");
                interruptor = false;
            }
          

            return interruptor;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Productos producto = new Productos();

            if (!Validar())
            {
                MesajeError("Favor llenar los campos Vacios");
            }
            else
            {
                producto = LlenarCampos();

                if (ProductosBLL.Guardar(producto))
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
            if (string.IsNullOrEmpty(productoIdTextBox.Text))
            {
                MessageBox.Show("Por favor insertar el id que desea buscar.");
                Limpiar();
            }
            else
            {
                int id = Utilidades.TOINT(productoIdTextBox.Text);
                Productos producto = new Productos();

                producto = ProductosBLL.Buscar(p => p.ProductoId == id);

                if (producto != null)
                {
                    descripcionTextBox.Text = producto.Descripcion;
                    nombreTextBox.Text = producto.Nombre;
                    codigoTextBox.Text = producto.Costo.ToString();
                    //texIdCategoria.Text = Convert.ToString(producto.CategoriaId);
                    //textCategoria.Text = producto.Nombre_Categoria;
                    //PreciotextBox.Text = producto.Precio.ToString();
                    //fechaIngresoDateTimePicker.Value = producto.FechaIngreso;
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
            if (string.IsNullOrEmpty(productoIdTextBox.Text))
            {
                MessageBox.Show("Por favor Ingrese el Id del Producto a Eliminar.");
                Limpiar();
            }
            else
            {
                DialogResult eliminar = MessageBox.Show("¿Seguro desea eliminar el producto seleccionado?", "¡Advertencia!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (eliminar == DialogResult.OK)
                {
                    int id = Utilidades.TOINT(productoIdTextBox.Text);

                    if (ProductosBLL.Eliminar(ProductosBLL.Buscar(p => p.ProductoId == id)))
                    {
                        Limpiar();
                        MesajeOk("Producto Eliminado con exito");
                    }
                    else
                        MesajeError("No se ah podido Eliminar el producto");
                }
            }
        }

     

        private void btnBuscarCategotia_Click(object sender, EventArgs e)
        {
            FormVistaCategoria frm = new FormVistaCategoria();
            this.Hide();
            frm.ShowDialog();

            
            
        }

    }
}
