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
    public partial class FormUsuario : Form
    {
        private static Usuarios Usuario = null;
        public FormUsuario()
        {
            InitializeComponent();
            LblHora.Text = DateTime.Now.ToString();
        }
        private bool Validar()
        {
            bool interruptor = true;

            if (string.IsNullOrEmpty(this.TxtUsuario.Text))
            {
                errorProvider1.SetError(TxtUsuario, "Por favor llenar el campo vacios.");
                TxtUsuario.Focus();
                interruptor = false;
            }
            if (string.IsNullOrEmpty(TxtPassword.Text))
            {
                errorProvider1.SetError(TxtPassword, "Por favor llenar el campo vacios.");
                TxtPassword.Focus();
                interruptor = false;
            }

            return interruptor;
        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LblHora.Text = DateTime.Now.ToString();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public static Entidades.Usuarios GetUsuario()
        {
            return Usuario;
        }

        private bool ValidarSesion()
        {
            if (TxtUsuario.Text == "Admin" && Usuario == null)
            {
                Usuario = new Usuarios(1, "Luis Rodriguez", "Admin", "1234", "1234");
                UsuarioBLL.Guardar(Usuario);

            ;
            }
            else
            {
                Usuario = BLL.UsuarioBLL.Buscar(p => p.NombreUsuario == TxtUsuario.Text);
            }

            if (Usuario != null)
            {
                if (TxtPassword.Text == Usuario.Clave)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("La clave no coinside con el usuario.");
                    TxtPassword.Clear();
                    TxtPassword.Focus();
                }
            }
            else
            {
                MessageBox.Show("El usuario digitado no existe.");
                TxtPassword.Clear();
               TxtUsuario.Focus();
            }

            return false;
        }

        private void IniciarSesion()
        {
            if (!Validar())
            {
                MessageBox.Show("Por favor llenar los campos vacios");
            }
            else
            {
                if (ValidarSesion())
                {
                    new FrmPrincipal().Show();
                    this.Hide();
                }
            }
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            IniciarSesion();
        }
    }
}
