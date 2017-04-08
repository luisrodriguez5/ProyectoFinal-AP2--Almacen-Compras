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
    public partial class FormPresentaciones : Form
    {
        public bool IsNuevo = false;
       
        public bool Editar = false;
        public FormPresentaciones()
        {
            InitializeComponent();
        }

        private Presentacion LlenarCampos()
        {
            Presentacion presentacion = new Presentacion();

            presentacion.PresentacionId = Utilidades.TOINT(PresentacionIdTextBox.Text);
            presentacion.Descripcion = descripcionTextBox.Text;
            presentacion.Nombre = nombreTextBox.Text;



            return presentacion;
        }
        private void Limpiar()
        {
            nombreTextBox.Clear();
            descripcionTextBox.Clear();

            PresentacionIdTextBox.Clear();

        }


        private void Habilitar(bool valor)
        {
            nombreTextBox.ReadOnly = !valor;
            descripcionTextBox.ReadOnly = !valor;
            PresentacionIdTextBox.ReadOnly = !valor;
           

        }
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

        private void FormPresentaciones_Load(object sender, EventArgs e)
        {
            Top = 0;
            Left = 0;

            Habilitar(false);
            Botones();
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



            return interruptor;
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


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Presentacion presentacion = new Presentacion();

            if (!Validar())
            {
                MesajeError("Favor llenar los campos Vacios");
            }
            else
            {
                presentacion = LlenarCampos();

                if (PresentacionBLL.Guardar(presentacion))
                {
                    MesajeOk("Se Guardo con exito");
                    Limpiar();
                }
                else
                    MesajeError("Error! no se pudo guardar.");
            }
        }

        private void btnEliminae_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PresentacionIdTextBox.Text))
            {
                MessageBox.Show("Por favor Ingrese el Id del Producto a Eliminar.");
                Limpiar();
            }
            else
            {
                DialogResult eliminar = MessageBox.Show("¿Seguro desea eliminar el producto seleccionado?", "¡Advertencia!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (eliminar == DialogResult.OK)
                {
                    int id = Utilidades.TOINT(PresentacionIdTextBox.Text);

                    if (PresentacionBLL.Eliminar(PresentacionBLL.Buscar(p => p.PresentacionId == id)))
                    {
                        Limpiar();
                        MesajeOk("Producto Eliminado con exito");
                    }
                    else
                        MesajeError("No se ah podido Eliminar el producto");
                }
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            btnEliminae.Enabled = true;
            btnGuardar.Enabled = true;
            if (string.IsNullOrEmpty(PresentacionIdTextBox.Text))
            {
                MessageBox.Show("Por favor insertar el id que desea buscar.");
                Limpiar();
            }
            else
            {
                int id = Utilidades.TOINT(PresentacionIdTextBox.Text);
                Presentacion presentacion = new Presentacion();

                presentacion = PresentacionBLL.Buscar(p => p.PresentacionId == id);

                if (presentacion != null)
                {
                    descripcionTextBox.Text = presentacion.Descripcion;
                    nombreTextBox.Text = presentacion.Nombre;


                }
                else
                {
                    MessageBox.Show("El Producto no exite.");
                    Limpiar();
                }
            }
        }
    }
}
