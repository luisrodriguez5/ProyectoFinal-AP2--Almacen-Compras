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
    public partial class RegistroProveedores : System.Web.UI.Page
    {
        private Proveedor proveedor = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            AlertGuardar.Visible = false;
            AlerteExistencia.Visible = false;
            AlertError.Visible = false;
            Alert.Visible = false;
            //Alert.Visible = false;
            MensajeYa.Visible = false;
            //Limpiar();

        }

        public void Limpiar()
        {
            proveedor = null;
            ProveedorTexBox.Text = "";
            SectorDropDownList.Text = "";
            DireccionTextBox.Text = "";
            RarozSocialTextBox.Text = "";
            EmailTextBox.Text = "";
            //CategoriaTextBox.Text = "";
            DireccionTextBox.Text = "";
            TelefonoTextBox.Text = "";
        }

        private void LlenarCamposInstancia()
        {
            int id = 0;
            if (ProveedorTexBox.Text != "")
            {
                id = Utilidades.TOINT(ProveedorTexBox.Text);
            }
           proveedor  = new Proveedor(id, RarozSocialTextBox.Text, SectorDropDownList.Text, DireccionTextBox.Text,TelefonoTextBox.Text, EmailTextBox.Text);
        }

        private bool Validar()
        {
            bool interutor = true;
            if (string.IsNullOrWhiteSpace(DireccionTextBox.Text))
            {
                interutor = false;
            }
            if (string.IsNullOrWhiteSpace(RarozSocialTextBox.Text))
            {
                interutor = false;
            }
            
            if (string.IsNullOrWhiteSpace(TelefonoTextBox.Text))
            {
                interutor = false;
            }
            if (string.IsNullOrWhiteSpace(EmailTextBox.Text))
            {
                interutor = false;
            }
            if (string.IsNullOrWhiteSpace(SectorDropDownList.Text))
            {
                interutor = false;
            }

            return interutor;
        }

        protected void BtnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        protected void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                LlenarCamposInstancia();
                if (ProveedorBLL.Guardar(proveedor))
                {
                    ProveedorTexBox.Text = proveedor.ProveedorId.ToString();
                    MensajeGuardado.Text = "!! Guardado Con Exito";
                    AlertGuardar.Visible = true;
                    //ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['success']('Usuario guardado con exito');", addScriptTags: true);
                    //UtilidadesWeb.MostrarToastr(this, "Guardado", "Cliente", "info");
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
            int id = Utilidades.TOINT(ProveedorTexBox.Text);
            var db = new Proveedor();

            db = ProveedorBLL.Buscar(p => p.ProveedorId == id);

            if (db != null)
            {
                SectorDropDownList.Text = db.Sector_Comercial;
                DireccionTextBox.Text = db.Direccion;
                EmailTextBox.Text = db.Email;
                RarozSocialTextBox.Text = db.Razon_Social;
                TelefonoTextBox.Text = db.Telefono;


            }
            else
            {

                Limpiar();
            }

        }
    }
}