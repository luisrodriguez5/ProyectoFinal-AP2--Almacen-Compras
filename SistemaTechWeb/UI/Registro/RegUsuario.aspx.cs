using BLL;
using Entidades;
using SistemaTech;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaTechWeb.UI.Registro
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private Usuarios usuario = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            AlertGuardar.Visible = false;
            AlerteExistencia.Visible = false;
            AlertError.Visible = false;
            Alert.Visible = false;
            //Alert.Visible = false;
            MensajeYa.Visible = false;


        }
        private void Limpiar()
        {
            usuario = null;
            UsuarioIdTexBox.Text = "";
            NombreTextBox.Text = "";
            NombreUsuarioTextBox.Text = "";
            ClaveTextBox.Text = "";
            ConfirmarTextBox.Text = "";
            FechaTextBox.Text = "";
        }
        private void LlenarCampos()
        {
            UsuarioIdTexBox.Text = usuario.UsuarioId.ToString();
            NombreTextBox.Text = usuario.Nombres;
            NombreUsuarioTextBox.Text = usuario.NombreUsuario;
            ClaveTextBox.Text = usuario.Clave;
            ConfirmarTextBox.Text = usuario.Clave;
            FechaTextBox.Text = usuario.FechaIngreso.GetDateTimeFormats()[80].ToString().Substring(0, 10);
        }

        private void LlenarCamposInstancia()
        {
            int id = 0;
            if (UsuarioIdTexBox.Text != "")
            {
                id = Utilidades.TOINT(UsuarioIdTexBox.Text);
            }
            usuario = new Usuarios(id, NombreTextBox.Text, NombreUsuarioTextBox.Text, ClaveTextBox.Text, ConfirmarTextBox.Text, DateTime.Parse(FechaTextBox.Text));
        }

        private bool Validar()
        {
            bool interutor = true;
            if (string.IsNullOrWhiteSpace(NombreTextBox.Text))
            {
                interutor = false;
            }
            if (string.IsNullOrWhiteSpace(NombreUsuarioTextBox.Text))
            {
                interutor = false;
            }
            else if (UsuarioBLL.Buscar(p => p.NombreUsuario == NombreUsuarioTextBox.Text) != null)
            {
                Usuarios SameName = UsuarioBLL.Buscar(U => U.NombreUsuario == NombreUsuarioTextBox.Text);
                if (UsuarioIdTexBox.Text == "")
                {
                    interutor = false;
                    MensajeYa.Visible = true;


                }
                else if (UsuarioIdTexBox.Text != SameName.UsuarioId.ToString())
                {
                    interutor = false;
                    MensajeYa.Visible = true;

                }
            }
            if (string.IsNullOrWhiteSpace(ClaveTextBox.Text))
            {
                interutor = false;
            }
            if (string.IsNullOrWhiteSpace(ClaveTextBox.Text))
            {
                interutor = false;
            }
            else if (ConfirmarTextBox.Text != ClaveTextBox.Text)
            {
                interutor = false;
            }
            if (Utilidades.ToDateTime(FechaTextBox.Text) == new DateTime(1, 1, 1))
            {
                interutor = false;
            }
            return interutor;
        }

        protected void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                LlenarCamposInstancia();
                if (UsuarioBLL.Guardar(usuario))
                {
                    UsuarioIdTexBox.Text = usuario.UsuarioId.ToString();
                    //MensajeGuardado.Text = "Gardo";
                    AlertGuardar.Visible = true;
                    //ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['success']('Usuario guardado con exito');", addScriptTags: true);
                    UtilidadesWeb.MostrarToastr(this, "Guardado", "Usuario", "info");
                    Limpiar();




                }
                else
                {
                    AlertError.Visible = true;
                }



            }
            else
            {
                Alert.Visible = true;
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = Utilidades.TOINT(UsuarioIdTexBox.Text);
            var user = new Usuarios();

            user = UsuarioBLL.Buscar(p => p.UsuarioId == id);

            if (user != null)
            {
                NombreTextBox.Text = user.Nombres;
                NombreUsuarioTextBox.Text = user.NombreUsuario;
                ClaveTextBox.Text = user.Clave;
                ConfirmarTextBox.Text = user.Clave;
                FechaTextBox.Text = user.FechaIngreso.GetDateTimeFormats()[80].ToString().Substring(0, 10);


            }
            else
            {

                Limpiar();
            }
        }

        protected void BtnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }

        /*protected void Button1_Click(object sender, EventArgs e)
        {
            int id = Utilidades.TOINT(UsuarioIdTexBox.Text);
            var user = new Usuarios();

            user = UsuarioBLL.Buscar(p => p.UsuarioId== id);

            if (user != null)
            {
                NombreTextBox.Text = user.Nombres;
                NombreUsuarioTextBox.Text = user.NombreUsuario;
                ClaveTextBox.Text = user.Clave;
                ConfirmarTextBox.Text = user.Clave;
                FechaTextBox.Text = user.FechaIngreso.GetDateTimeFormats()[80].ToString().Substring(0, 10);


            }
            else
            {

                Limpiar();
            }
        }
        */
    
}


