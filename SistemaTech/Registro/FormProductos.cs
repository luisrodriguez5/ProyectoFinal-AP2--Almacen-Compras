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
        public List<Entidades.Productos> Lista { get; set; }
        public bool Editar = false;

        public FormProductos()
        {
            InitializeComponent();
            this.toolTip1.SetToolTip(this.nombreTextBox, "Ingrese El Nombre Del Producto");
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
            
       

            return producto;
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

        }

        //Habilitar Controles
        private void Habilitar(bool valor)
        {
            nombreTextBox.ReadOnly = !valor;
            descripcionTextBox.ReadOnly = !valor;
            codigoTextBox.ReadOnly = !valor;
            productoIdTextBox.ReadOnly = !valor;
            textBox1.ReadOnly = !valor;

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
                btnFiltrar.Enabled = true;
            }
            else
            {
                Habilitar(false);
                btnNuevo.Enabled = true;
                btnGuardar.Enabled = false ;
                btnEliminae.Enabled = false;
                btnFiltrar.Enabled = false;
            }
        }
        private void OcultarCulunas()
        {
            dataListadoProducto.Columns[0].Visible = false;
            dataListadoProducto.Columns[1].Visible = false;
            dataListadoProducto.Columns[7].Visible = false;
        }
        private void Listar()
        {

            if( comboBox1.SelectedIndex==0)
            {

                Lista = ProductosBLL.GetListAll();
               
            }
            if(comboBox1.SelectedIndex == 1)
            {
                int id = Utilidades.TOINT(textBox1.Text);
                Lista = BLL.ProductosBLL.GetList(p => p.ProductoId == id);
                
            }
            if (comboBox1.SelectedIndex == 2)
            {
                Lista = ProductosBLL.GetList(p => p.Nombre == textBox1.Text);
                
            }
            if (comboBox1.SelectedIndex == 3)
            {
                Lista = BLL.ProductosBLL.GetList(p => p.Descripcion == textBox1.Text);
               
            }

            dataListadoProducto.DataSource = Lista;
            lblTotal.Text = "Total De Registros: " + Convert.ToString(dataListadoProducto.Rows.Count);
        }



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            Listar();
            OcultarCulunas();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            IsNuevo = true;
            Botones();
            Habilitar(true);

            if (comboBox1.SelectedIndex == 0)
            {
                textBox1.Clear();
                errorProvider1.Clear();
                textBox1.Enabled = false;
                Listar();
                OcultarCulunas();
            }
            if (comboBox1.SelectedIndex == 1)
            {
                textBox1.Clear();
                errorProvider1.Clear();
                textBox1.Enabled = true;
                Listar();
                OcultarCulunas();
            }
            if (comboBox1.SelectedIndex == 2)
            {
                textBox1.Clear();
                errorProvider1.Clear();
                textBox1.Enabled = true;
                Listar();
                OcultarCulunas();
            }
            if (comboBox1.SelectedIndex == 3)
            {
                textBox1.Clear();
                errorProvider1.Clear();
                textBox1.Enabled = true;
                Listar();
                OcultarCulunas();
            }
            else
            {
              
                textBox1.Clear();
                dataListadoProducto.DataSource = null;
                
               
            }

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

        private void dataListadoProducto_DoubleClick(object sender, EventArgs e)
        {
            this.productoIdTextBox.Text = Convert.ToString(dataListadoProducto.CurrentRow.Cells["ProductoId"].Value);
            this.codigoTextBox.Text = Convert.ToString(dataListadoProducto.CurrentRow.Cells["Costo"].Value);
            this.nombreTextBox.Text = Convert.ToString(dataListadoProducto.CurrentRow.Cells["Nombre"].Value);
            this.descripcionTextBox.Text = Convert.ToString(dataListadoProducto.CurrentRow.Cells["Descripcion"].Value);
            this.tabControl1.SelectedIndex = 1;
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                this.dataListadoProducto.Columns[0].Visible = true;
            }
            else
            {
                this.dataListadoProducto.Columns[0].Visible = false;
            }
        }

        private void dataListadoProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == dataListadoProducto.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)dataListadoProducto.Rows[e.RowIndex].Cells["Eliminar"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opc;
                Opc = MessageBox.Show("Realmente desea Eliminar los registros","....Sistema De Almacen....",MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if(Opc == DialogResult.OK)
                {
                    int Codigo = Utilidades.TOINT(productoIdTextBox.Text); ;
                   
                    foreach (DataGridViewRow row in dataListadoProducto.Rows)
                    {
                        if(Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToInt32(row.Cells[1].Value);

                            if (ProductosBLL.Eliminar(ProductosBLL.Buscar(p => p.ProductoId == Codigo)))
                            {
                                MesajeOk("Se Elimino correta mente el registro");

                            }
                            else
                            {
                                MesajeError("No ah podido eliminar el registro");
                            }
                        }
                    }
                    Listar();
                }

            }
            catch (Exception)
            {

                MessageBox.Show("No se pudo eliminar");
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
    }
}
