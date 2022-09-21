using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace TP_4
{
    public partial class Ejercicio3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void lbVerLibros_Click1(object sender, EventArgs e)
        {
            Response.Redirect("Ejercicio3b.aspx?tema="+DropDownList1.SelectedValue);
        }
    }
}