using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP_2
{
    public partial class Ejercicio4a : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            String usuario;
            String clave;
            usuario = txtUsuario.Text;
            clave = txtClave.Text;
            if(usuario == "claudio" && clave=="casas")
            {
                Server.Transfer("Ejercicio4b.aspx");
            }
            else
            {
                Server.Transfer("Ejercicio4c.aspx");
            }
        }

        protected void txtClave_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}