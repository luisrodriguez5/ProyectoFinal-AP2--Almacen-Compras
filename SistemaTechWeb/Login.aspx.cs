using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaTechWeb
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UsuarioTextBox.Text) || string.IsNullOrWhiteSpace(ContrasenaTextBox.Text))
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['info']('Por favor llene todos los campos');", addScriptTags: true);
            }
            else
            {
                if (BLL.UsuarioBLL.Autenticar(UsuarioTextBox.Text, ContrasenaTextBox.Text))
                {
                    System.Web.Security.FormsAuthentication.RedirectFromLoginPage(UsuarioTextBox.Text, true);
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['error']('Usuario y/o contraseña incorrectos');", addScriptTags: true);
                }
            }

        }
    }
}