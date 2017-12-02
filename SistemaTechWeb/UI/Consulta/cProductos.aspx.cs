using Entidades;
using SistemaTech;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaTechWeb.UI.Consulta
{
    public partial class cProductos : System.Web.UI.Page
    {
        public static List<Productos> Lista { get; set; }
        public Productos productos { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            Lista = new List<Productos>();
            productos = null;

            if (!Page.IsPostBack)
            {
                Lista = BLL.ProductosBLL.GetListAll();
            

            }
        }

        private void LlenarGriw()
        {
            ProductosConsulta.DataSource = Lista;
            ProductosConsulta.DataBind();
        }

        private void Filtrar()
        {
            if (FiltrarDropDownList.SelectedIndex == 0)
            {
                Lista = BLL.ProductosBLL.GetListAll();
            }
            else if (FiltrarDropDownList.SelectedIndex != 0)
            {
                if (FiltrarDropDownList.SelectedIndex == 2)
                {
                    Lista = BLL.ProductosBLL.GetList(p => p.Nombre == FiltrarTextBox.Text);
                }
                if (FiltrarDropDownList.SelectedIndex == 3)
                {
                    Lista = BLL.ProductosBLL.GetList(p => p.Descripcion == FiltrarTextBox.Text);
                }
                if (FiltrarDropDownList.SelectedIndex == 4)
                {
                    DateTime FechaDesde = Convert.ToDateTime(FechaDesdeTextBox.Text);
                    DateTime FechaHasta = Convert.ToDateTime(FechaHastaTextBox.Text);

                }

                if (FiltrarDropDownList.SelectedIndex == 1)
                {
                    int id = Utilidades.TOINT(FiltrarTextBox.Text);
                    Lista = BLL.ProductosBLL.GetList(p => p.ProductoId == id);
                }
            }
            LlenarGriw();

        }



        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FiltrarTextBox.Text) && FiltrarDropDownList.SelectedIndex != 0 && FiltrarDropDownList.SelectedIndex != 4)
            {
                ProductosConsulta.DataBind();
                //AsignarTextoAlertaInfo("Por favor digite el dato que desea filtrar.");
                ImprimirButton.Visible = false;
            }
            else if (FiltrarDropDownList.SelectedIndex == 4)
            {
                if (string.IsNullOrEmpty(FechaDesdeTextBox.Text) || string.IsNullOrEmpty(FechaHastaTextBox.Text))
                {
                    ProductosConsulta.DataBind();
                    //AsignarTextoAlertaInfo("Por favor eliga el rango de fecha que desea filtrar.");
                    ImprimirButton.Visible = false;
                }
                else
                {
                    Filtrar();
                    // BotonImprimirVisibleSiHayListas();
                }
            }
            else
            {
                // ImprimirButton.Visible = false;
                Filtrar();
                //BotonImprimirVisibleSiHayListas();
            }
        }
    }
}