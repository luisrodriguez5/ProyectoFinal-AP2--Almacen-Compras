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
    public partial class cCategoria : System.Web.UI.Page
    {
        public static List<Categoria> Lista { get; set; }
        public Entidades.Categoria categoria { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            Lista = new List<Categoria>();
            categoria = null;

            if (!Page.IsPostBack)
            {
                Lista = BLL.CategoriaBLL.GetListAll();

            }

        }

        private void LlenarGriw()
        {
            CategoriaConsulta.DataSource = Lista;
            CategoriaConsulta.DataBind();
        }

        private void Filtrar()
        {
            if (FiltrarDropDownList.SelectedIndex == 0)
            {
                Lista = BLL.CategoriaBLL.GetListAll();
            }
            else if (FiltrarDropDownList.SelectedIndex != 0)
            {
                if (FiltrarDropDownList.SelectedIndex == 2)
                {
                    Lista = BLL.CategoriaBLL.GetList(p => p.Nombre == FiltrarTextBox.Text);
                }
                if (FiltrarDropDownList.SelectedIndex == 3)
                {
                    Lista = BLL.CategoriaBLL.GetList(p => p.Descripcion == FiltrarTextBox.Text);
                }
                if (FiltrarDropDownList.SelectedIndex == 4)
                {
                    DateTime FechaDesde = Convert.ToDateTime(FechaDesdeTextBox.Text);
                    DateTime FechaHasta = Convert.ToDateTime(FechaHastaTextBox.Text);
                    
                }

                if (FiltrarDropDownList.SelectedIndex == 1)
                {
                    int id = Utilidades.TOINT(FiltrarTextBox.Text);
                    Lista = BLL.CategoriaBLL.GetList(p => p.CategoriaId == id);
                }
            }
            LlenarGriw();

        }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FiltrarTextBox.Text) && FiltrarDropDownList.SelectedIndex != 0 && FiltrarDropDownList.SelectedIndex != 4)
            {
                CategoriaConsulta.DataBind();
                //AsignarTextoAlertaInfo("Por favor digite el dato que desea filtrar.");
                ImprimirButton.Visible = false;
            }
            else if (FiltrarDropDownList.SelectedIndex == 4)
            {
                if (string.IsNullOrEmpty(FechaDesdeTextBox.Text) || string.IsNullOrEmpty(FechaHastaTextBox.Text))
                {
                    CategoriaConsulta.DataBind();
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