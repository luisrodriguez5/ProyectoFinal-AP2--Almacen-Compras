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
    public partial class cProveedores : System.Web.UI.Page
    {
        public static List<Proveedor> Lista { get; set; }
        public Proveedor usuarios { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void LlenarGriw()
        {
            ProveedorConsulta.DataSource = Lista;
            ProveedorConsulta.DataBind();
        }
        private void Filtrar()
        {
            if (FiltrarDropDownList.SelectedIndex == 0)
            {
                Lista = BLL.ProveedorBLL.GetListAll();
            }
            else if (FiltrarDropDownList.SelectedIndex != 0)
            {
                if (FiltrarDropDownList.SelectedIndex == 2)
                {
                    Lista = BLL.ProveedorBLL.GetList(p => p.Sector_Comercial == FiltrarTextBox.Text);
                }
                if (FiltrarDropDownList.SelectedIndex == 3)
                {
                    Lista = BLL.ProveedorBLL.GetList(p => p.Telefono == FiltrarTextBox.Text);
                }
                if (FiltrarDropDownList.SelectedIndex == 4)
                {
                    DateTime FechaDesde = Convert.ToDateTime(FechaDesdeTextBox.Text);
                    DateTime FechaHasta = Convert.ToDateTime(FechaHastaTextBox.Text);
                   
                }

                if (FiltrarDropDownList.SelectedIndex == 1)
                {
                    int id = Utilidades.TOINT(FiltrarTextBox.Text);
                    Lista = BLL.ProveedorBLL.GetList(p => p.ProveedorId == id);
                }
            }
            LlenarGriw();

        }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FiltrarTextBox.Text) && FiltrarDropDownList.SelectedIndex != 0 && FiltrarDropDownList.SelectedIndex != 4)
            {
                ProveedorConsulta.DataBind();
                //AsignarTextoAlertaInfo("Por favor digite el dato que desea filtrar.");
                ImprimirButton.Visible = false;
            }
            else if (FiltrarDropDownList.SelectedIndex == 4)
            {
                if (string.IsNullOrEmpty(FechaDesdeTextBox.Text) || string.IsNullOrEmpty(FechaHastaTextBox.Text))
                {
                    ProveedorConsulta.DataBind();
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