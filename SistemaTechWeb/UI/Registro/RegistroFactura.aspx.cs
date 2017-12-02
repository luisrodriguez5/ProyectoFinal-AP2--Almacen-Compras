using BLL;
using Entidades;
using SistemaTech;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaTechWeb.UI.Registro
{
    public partial class RegistroFactura : System.Web.UI.Page
    {
       
        private Ingreso ingreso = new Ingreso();
        DataTable dt = new DataTable();
        private static List<Ingreso> Detalle;
        Entidades.Productos producto = new Entidades.Productos();


        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private void Limpiar()
        {
            ProductoIdTexBox.Text = "";
            ClienteIdTextBox.Text = "";
            ComprobanteDropDownList.Text = "";
            NombreProveedorTextBox.Text = "";
            ProductoIdTextBox.Text = "";
      
            LimpiarDatosProducto();
            LimpiarListaRelaciones();

            Response.Redirect("FacturasRegistro.aspx");
        }

        private void LimpiarDatosProducto()
        {
            CostoProductoTextBox.Text = "";
            DescripcionProductoTextBox.Text = "";
            CantidadProductoTextBox.Text = "";
        }

        private void LimpiarListaRelaciones()
        {
            Detalle = new List<Ingreso>();
            DetalleGridView.DataSource = (DataTable)ViewState["listaRelaciones"];
            DetalleGridView.DataBind();
        }

        public void BuscarDatosDetalle(List<Ingreso> CompraProducto)
        {
            foreach (var detalle in CompraProducto)
            {
                dt = (DataTable)ViewState["Detalle"];
                dt.Rows.Add(detalle.Costo_Compra, detalle.NumIngreso, detalle.Fecha_Ingreso, detalle.Fecha_Vencimiento);
                ViewState["Detalle"] = dt;
                this.BindGrid();
            }
        }


        public void AgregarDetalle(int ingresoId, int proveedor, DateTime fecha, decimal costo)
        {
            Detalle.Add(new Ingreso(ingresoId, proveedor, fecha, costo));

          
        }

        protected void BindGrid()
        {
            DetalleGridView.DataSource = (DataTable)ViewState["Detalle"];
            DetalleGridView.DataBind();
        }

        protected void BuscarProductos()
        {
            int id = Utilidades.TOINT(ProductoIdTextBox.Text);
            var producto = new Productos();

            producto = ProductosBLL.Buscar(p => p.ProductoId == id);

            if (producto != null)
            {
                DescripcionProductoTextBox.Text = producto.Descripcion;

               CostoProductoTextBox.Text = Convert.ToString(producto.Costo);

            }
            else
            {
                UtilidadesWeb.MostrarToastr(this, "Producto no existe ", "Mensaje", "error");
            }
        }

   

        protected void BuscarProbeedor()
        {
            int id = Utilidades.TOINT(ClienteIdTextBox.Text);
            var cliente = new Proveedor();

            cliente = ProveedorBLL.Buscar(p => p.ProveedorId == id);

            if (cliente != null)
            {
                NombreProveedorTextBox.Text = cliente.Razon_Social;

            }
            else
            {
                UtilidadesWeb.MostrarToastr(this, "Cliente no existe ", "Mensaje", "error");
            }

        }



        private bool Validar()
        {
            bool interruptor = true;

            if (string.IsNullOrEmpty(NombreProveedorTextBox.Text))
            {
                interruptor = false;
            }
            if (DetalleGridView.Rows.Count == 0)
            {
                interruptor = false;
            }
            if (string.IsNullOrEmpty(CostoProductoTextBox.Text))
            {
                interruptor = false;
            }

            return interruptor;
        }

        protected void BuscarProvedorButton_Click(object sender, EventArgs e)
        {
            BuscarProbeedor();
        }

        protected void BuscarProductoButton_Click(object sender, EventArgs e)
        {
            BuscarProductos();
        }

        protected void AgregarProductoButton_Click(object sender, EventArgs e)
        {
            int id = Utilidades.TOINT(ProductoIdTextBox.Text);
            producto = BLL.ProductosBLL.Buscar(p => p.ProductoId == id);

         
        
                bool agregado = false;

                foreach (GridViewRow pro in DetalleGridView.Rows)
                {
                    int prueba = Utilidades.TOINT(pro.Cells[0].Text);
                    if (producto.ProductoId == Utilidades.TOINT(pro.Cells[0].Text))
                    {
                        agregado = true;
                        break;
                    }
                }
                if (agregado)
                {

                    UtilidadesWeb.MostrarToastr(this, "El Producto ya esta Agregado -Selecione otro", "Error", "info");

                }
                else
                {
                    DataTable dt = (DataTable)ViewState["Detalle"];
                    dt.Rows.Add(ProductoIdTextBox.Text, producto.Descripcion.Trim(), producto.Costo);
                    ViewState["Detalle"] = dt;
                    this.BindGrid();
                   
                }
            
        }
    }
}