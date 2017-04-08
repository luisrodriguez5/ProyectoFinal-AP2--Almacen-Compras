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
    public partial class RegistroUsuario : Form
    {
        public RegistroUsuario()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            usuarioIdMaskedTextBox.Clear();
            nombresTextBox.Clear();
            nombreUsuarioTextBox.Clear();
            claveTextBox.Clear();
            confirmarClaveTextBox.Clear();
           
        }


        private bool Validar()
        {
            bool interruptor = true;

            if (string.IsNullOrEmpty(nombresTextBox.Text))
            {
                NombreserrorProvider.SetError(nombresTextBox, "Por favor llenar el campo vacio.");
                interruptor = false;
            }
            if (string.IsNullOrEmpty(nombreUsuarioTextBox.Text))
            {
                NombreUsuarioerrorProvider.SetError(nombreUsuarioTextBox, "Por favor llenar el campo vacio.");
                interruptor = false;
            }
            if (string.IsNullOrEmpty(claveTextBox.Text))
            {
                ClaveerrorProvider.SetError(claveTextBox, "Por favor llenar el campo vacio.");
                interruptor = false;
            }
            if (string.IsNullOrEmpty(confirmarClaveTextBox.Text))
            {
                ConfirmarClaveerrorProvider.SetError(confirmarClaveTextBox, "Por favor llenar el campo vacio.");
                interruptor = false;
            }
          

            return interruptor;
        }


        private Usuarios LlenarCampos()
        {
            Usuarios usuario = new Usuarios();

            usuario.UsuarioId = Utilidades.TOINT(usuarioIdMaskedTextBox.Text);
            usuario.Nombres = nombresTextBox.Text;
            usuario.NombreUsuario = nombreUsuarioTextBox.Text;
            usuario.Clave = claveTextBox.Text;
            usuario.ConfirmarClave = confirmarClaveTextBox.Text;
            

            return usuario;
        }

        private void RegistroUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();

            if (!Validar())
            {
                MessageBox.Show("Por favor llenar los campos vacios.");
            }
            else
            {
                usuario = LlenarCampos();

                if (claveTextBox.Text == confirmarClaveTextBox.Text)
                {
                    if (UsuarioBLL.Guardar(usuario))
                    {
                        MessageBox.Show("Guardado con exito.");
                        Limpiar();
                    }
                    else
                        MessageBox.Show("Error! no se pudo guardar.");
                }
                else
                {
                    MessageBox.Show("La clave de confirmacion es incorrecta.");
                    confirmarClaveTextBox.Clear();
                    confirmarClaveTextBox.Focus();
                }
            }

        }

        private void BuscarUsuario()
        {
            if (string.IsNullOrEmpty(usuarioIdMaskedTextBox.Text))
            {
                MessageBox.Show("Por favor insertar el id que desea buscar.");
                Limpiar();
            }
            else
            {
                int id = Utilidades.TOINT(usuarioIdMaskedTextBox.Text);
                Usuarios usuario = new Usuarios();

                usuario = UsuarioBLL.Buscar(p => p.UsuarioId == id);

                if (usuario != null)
                {
                    nombresTextBox.Text = usuario.Nombres;
                    nombreUsuarioTextBox.Text = usuario.NombreUsuario;
                    claveTextBox.Text = usuario.Clave;
                    confirmarClaveTextBox.Text = usuario.ConfirmarClave;
                   
                }
                else
                {
                    MessageBox.Show("El usuario no exite.");
                    Limpiar();
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarUsuario();
        }

        private void btnEliminae_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(usuarioIdMaskedTextBox.Text))
            {
                MessageBox.Show("Por favor insertar el id del usuario que desea eliminar.");
                Limpiar();
            }
            else
            {
                int id = Utilidades.TOINT(usuarioIdMaskedTextBox.Text);

                if (id != 1)
                {
                    DialogResult eliminar = MessageBox.Show("¿Seguro desea eliminar el usuario seleccionado?", "¡Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (eliminar == DialogResult.Yes)
                    {
                        if (UsuarioBLL.Eliminar(UsuarioBLL.Buscar(p => p.UsuarioId == id)))
                        {
                            Limpiar();
                            MessageBox.Show("Usuario eliminado con exito.");
                        }
                        else
                            MessageBox.Show("No se pudo eliminar el usuario.");
                    }
                }
                else
                {
                    MessageBox.Show("No se puede eliminar el usuario porque es el pilar.");
                }
            }
        }
    }
}
