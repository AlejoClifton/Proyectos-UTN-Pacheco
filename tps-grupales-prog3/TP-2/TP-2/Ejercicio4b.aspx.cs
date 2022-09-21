using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP_2
{
    public partial class Ejercicio4b : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String Usuario;            
            Usuario = Request["txtUsuario"].ToString();
            lblNombre.Text = Usuario;
            
        }
    }
}