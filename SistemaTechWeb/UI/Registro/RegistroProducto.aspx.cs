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
    public partial class RegistroProducto : System.Web.UI.Page
    {
        private Productos producto = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            AlertGuardar.Visible = false;
            AlerteExistencia.Visible = false;
            AlertError.Visible = false;
            Alert.Visible = false;
            //Alert.Visible = false;
            MensajeYa.Visible = false;
            LlenarCategorias();
        }
        private void Limpiar()
        {
            producto = null;
            ProductoIdTexBox.Text = "";
            NombreTextBox.Text = "";
            CostoTextBox.Text = "";
            //CategoriaTextBox.Text = "";
            DescripcionTextBox.Text = "";
            PresentacionTextBox.Text = "";
        }

        //private void LlenarCampos()
        //{

        //    ProductoIdTexBox.Text = producto.ProductoId.ToString();
        //    NombreTextBox.Text = producto.Nombre;
        //    producto.Costo = Utilidades.TODECIMAL(CostoTextBox.Text);
        //    DropDownList1.SelectedValue = producto.CategoriaId.ToString();
        //    //CategoriaTextBox.Text = ;
        //    DescripcionTextBox.Text = "";
        //    PresentacionTextBox.Text = "";

        //}
        private void LlenarCategorias()
        {
            DropDownList1.DataSource = CategoriaBLL.GetListAll();
            DropDownList1.DataValueField = "CategoriaId";
            DropDownList1.DataTextField = "Nombre";
            DropDownList1.DataBind();
        }
        private void LlenarCamposInstancia()
        {
            int id = 0;
            if (ProductoIdTexBox.Text != "")
            {
                id = Utilidades.TOINT(ProductoIdTexBox.Text);
            }
            producto = new Productos(id, DescripcionTextBox.Text, Utilidades.TODECIMAL(CostoTextBox.Text), NombreTextBox.Text, DropDownList1.Text);
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
            else if (BLL.ProductosBLL.Buscar(p => p.Nombre == NombreTextBox.Text) != null)
            {
                Productos SameName = ProductosBLL.Buscar(U => U.Nombre == NombreTextBox.Text);
                if (ProductoIdTexBox.Text == "")
                {
                    interutor = false;
                    MensajeYa.Visible = true;


                }
                else if (ProductoIdTexBox.Text != SameName.ProductoId.ToString())
                {
                    interutor = false;
                    MensajeYa.Visible = true;

                }
            }
            if (string.IsNullOrWhiteSpace(CostoTextBox.Text))
            {
                interutor = false;
            }
            if (string.IsNullOrWhiteSpace(PresentacionTextBox.Text))
            {
                interutor = false;
            }
            if (string.IsNullOrWhiteSpace(CostoTextBox.Text))
            {
                interutor = false;
            }

            return interutor;
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
                if (ProductosBLL.Guardar(producto))
                {
                    ProductoIdTexBox.Text = producto.ProductoId.ToString();
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
            int id = Utilidades.TOINT(ProductoIdTexBox.Text);
            var db = new Productos();

            db = ProductosBLL.Buscar(p => p.ProductoId == id);

            if (db != null)
            {
                NombreTextBox.Text = db.Nombre;
                DescripcionTextBox.Text = db.Descripcion;
                CostoTextBox.Text = Convert.ToString(db.Costo);
                DropDownList1.Text = db.Nombre_Categoria;


            }
            else
            {

                Limpiar();
            }

        }
    }
}