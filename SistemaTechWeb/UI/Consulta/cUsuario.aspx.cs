using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaTechWeb.UI.Consulta
{
    public partial class cUsuario : System.Web.UI.Page
    {
        public static List<Entidades.Usuarios> Lista { get; set; }
        public static Entidades.Usuarios Usuario = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Lista = BLL.UsuarioBLL.GetListAll();

            }
        }

        private void CargarListaUsuario()
        {
            UsuariosConsultaGridView.DataSource = Lista;
            UsuariosConsultaGridView.DataBind();
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
                    Lista = BLL.UsuarioBLL.GetList(p => p.Nombres == FiltroTextBox.Text);
                }
                if (FiltrarDropDownList.SelectedIndex == 3)
                {
                    Lista = BLL.UsuarioBLL.GetList(p => p.NombreUsuario == FiltroTextBox.Text);
                }
                if (FiltrarDropDownList.SelectedIndex == 4)
                {
                    DateTime FechaDesde = Convert.ToDateTime(FechaDesdeTextBox.Text);
                    DateTime FechaHasta = Convert.ToDateTime(FechaHastaTextBox.Text);
                    Lista = BLL.UsuarioBLL.GetList(p => p.FechaIngreso >= FechaDesde.Date && p.FechaIngreso <= FechaHasta.Date);
                }

                if (FiltrarDropDownList.SelectedIndex == 1)
                {
                    int id = SistemaTech.Utilidades.TOINT(FiltroTextBox.Text);
                    Lista = BLL.UsuarioBLL.GetList(p => p.UsuarioId == id);
                }
            }
        }
        protected void FiltroButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FiltroTextBox.Text) && FiltrarDropDownList.SelectedIndex != 0 && FiltrarDropDownList.SelectedIndex != 4)
            {
                UsuariosConsultaGridView.DataBind();
                
            }
            else if (FiltrarDropDownList.SelectedIndex == 4)
            {
                if (string.IsNullOrEmpty(FechaDesdeTextBox.Text) || string.IsNullOrEmpty(FechaHastaTextBox.Text))
                {
                    UsuariosConsultaGridView.DataBind();
                    
                }
                else
                {
                    Filtrar();
                    
                }
            }
        }
    }
}