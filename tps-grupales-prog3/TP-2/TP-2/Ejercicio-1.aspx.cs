using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP_2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGenerar_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(tbxCantidad.Text);
            int numero2 = int.Parse(tbxCantidad2.Text);
            String tabla = "<table border = '1'>";

            tabla += "<tr><th>Producto</th><th>Cantidad</th></tr>";
            tabla += "<tr>";
            tabla += "<td>" + tbxProducto.Text + "</td>";
            tabla += "<td>" + numero + "</td";
            tabla += "</tr>";
            tabla += "<tr>";
            tabla += "<td>" + tbxProducto2.Text + "</td>";
            tabla += "<td>" + numero2 + "</td";
            tabla += "</tr>";
            tabla += "<tr>";
            tabla += "<td>" + "TOTAL:" + "</td>";
            tabla += "<td>" + (numero+numero2) + "</td";
            tabla += "</tr>";

            tabla += "</table>";
            lblTabla.Text = tabla;
        }
    }
}