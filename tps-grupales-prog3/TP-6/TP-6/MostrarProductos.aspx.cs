using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace TP_6
{
    public partial class MostrarProductos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Seleccionados"] != null)
            {
                grd_Seleccionados.DataSource = (DataTable)Session["Seleccionados"];
                grd_Seleccionados.DataBind();
            }
        }

        
    }
}