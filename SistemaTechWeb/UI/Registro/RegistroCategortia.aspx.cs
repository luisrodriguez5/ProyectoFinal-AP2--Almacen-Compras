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
    public partial class RegistroCategortia : System.Web.UI.Page
    {
        private Categoria categoria = null;
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
            categoria = null;
            CategoriaIdTexBox.Text = "";
            NombreTextBox.Text = "";
            CodigoTextBox.Text = "";
            DescripcionTextBox.Text = "";

        }

        private void LlenarCampos()
        {
            CategoriaIdTexBox.Text = categoria.CategoriaId.ToString();
            NombreTextBox.Text = categoria.Nombre;
            categoria.Codigo = Utilidades.TOINT(CodigoTextBox.Text);
            //CategoriaTextBox.Text = ;
            DescripcionTextBox.Text = "";


        }

        private bool Validar()
        {
            bool interutor = true;
            if (string.IsNullOrWhiteSpace(NombreTextBox.Text))
            {
                interutor = false;
            }
            if (string.IsNullOrWhiteSpace(DescripcionTextBox.Text))
            {
                interutor = false;
            }
            else if (CategoriaBLL.Buscar(p => p.Nombre == NombreTextBox.Text) != null)
            {
                Categoria SameName = CategoriaBLL.Buscar(U => U.Nombre == NombreTextBox.Text);
                if (CategoriaIdTexBox.Text == "")
                {
                    interutor = false;
                    MensajeYa.Visible = true;


                }
                else if (CategoriaIdTexBox.Text != SameName.CategoriaId.ToString())
                {
                    interutor = false;
                    MensajeYa.Visible = true;

                }
            }
            if (string.IsNullOrWhiteSpace(CodigoTextBox.Text))
            {
                interutor = false;
            }

            return interutor;
        }

        private void LlenarCamposInstancia()
        {
            int id = 0;
            if (CategoriaIdTexBox.Text != "")
            {
                id = Utilidades.TOINT(CategoriaIdTexBox.Text);
            }
            categoria = new Categoria(id, Utilidades.TOINT(CodigoTextBox.Text), NombreTextBox.Text, DescripcionTextBox.Text);
        }

        protected void BtnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();

        }

        protected void BtnEliminar_Click(object sender, EventArgs e)
        {

        }

        protected void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                LlenarCamposInstancia();
                if (CategoriaBLL.Guardar(categoria))
                {
                    CategoriaIdTexBox.Text = categoria.CategoriaId.ToString();
                    MensajeGuardado.Text = "Gardo";
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
            int id = Utilidades.TOINT(CategoriaIdTexBox.Text);
            var cat = new Categoria();

            cat = CategoriaBLL.Buscar(p => p.CategoriaId == id);

            if (cat != null)
            {
                NombreTextBox.Text = cat.Nombre;
                DescripcionTextBox.Text = cat.Descripcion;
                CodigoTextBox.Text = Convert.ToString(cat.Codigo);



            }
            else
            {

                Limpiar();
            }

        }
    }
}