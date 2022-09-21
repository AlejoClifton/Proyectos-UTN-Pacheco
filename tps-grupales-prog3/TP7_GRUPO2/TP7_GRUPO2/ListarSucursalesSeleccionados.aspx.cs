using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace TP7_GRUPO2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        TablaSesion ts = new TablaSesion();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Seleccionados"] != null)
            {
                TablaSesion.IngresarDatosEnGrilla(gvSucursalesSeleccionadas, (DataTable)Session["Seleccionados"]);
            }
        }
    }
}