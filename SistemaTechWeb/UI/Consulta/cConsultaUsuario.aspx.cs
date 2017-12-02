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
    public partial class cConsultaUsuario : System.Web.UI.Page
    {
       public static List<Usuarios> Lista { get; set; }
        public Usuarios usuarios { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            Lista = new List<Usuarios>();
            usuarios = null;

            if (!Page.IsPostBack)
            {
                Lista = BLL.UsuarioBLL.GetListAll();
               
            }
        }
        private void LlenarGriw()
        {
            UsuarioConsulta.DataSource = Lista;
            UsuarioConsulta.DataBind();
        }

        private void Filtrar()
        {
            if (FiltrarDropDownList.SelectedIndex == 0)
            {
                Lista = BLL.UsuarioBLL.GetListAll();
            }
            else if (FiltrarDropDownList.SelectedIndex != 0)
            {
                if (FiltrarDropDownList.SelectedIndex == 2)
                {
                    Lista = BLL.UsuarioBLL.GetList(p => p.Nombres == FiltrarTextBox.Text);
                }
                if (FiltrarDropDownList.SelectedIndex == 3)
                {
                    Lista = BLL.UsuarioBLL.GetList(p => p.NombreUsuario == FiltrarTextBox.Text);
                }
                if (FiltrarDropDownList.SelectedIndex == 4)
                {
                    DateTime FechaDesde = Convert.ToDateTime(FechaDesdeTextBox.Text);
                    DateTime FechaHasta = Convert.ToDateTime(FechaHastaTextBox.Text);
                    Lista = BLL.UsuarioBLL.GetList(p => p.FechaIngreso >= FechaDesde.Date && p.FechaIngreso <= FechaHasta.Date);
                }

                if (FiltrarDropDownList.SelectedIndex == 1)
                {
                    int id = Utilidades.TOINT(FiltrarTextBox.Text);
                    Lista = BLL.UsuarioBLL.GetList(p => p.UsuarioId == id);
                }
            }
            LlenarGriw();

        }




        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FiltrarTextBox.Text) && FiltrarDropDownList.SelectedIndex != 0 && FiltrarDropDownList.SelectedIndex != 4)
            {
                UsuarioConsulta.DataBind();
                //AsignarTextoAlertaInfo("Por favor digite el dato que desea filtrar.");
                ImprimirButton.Visible = false;
            }
            else if (FiltrarDropDownList.SelectedIndex == 4)
            {
                if (string.IsNullOrEmpty(FechaDesdeTextBox.Text) || string.IsNullOrEmpty(FechaHastaTextBox.Text))
                {
                    UsuarioConsulta.DataBind();
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

        protected void UsuarioConsulta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ImprimirButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Reportes/UsuariosReporte.aspx");
        }
    }
}