using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace Vista
{
    public partial class EliminarSucursal : System.Web.UI.Page
    {
        NegocioCategorias neg = new NegocioCategorias();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            if (tbxSucursal.Text.Trim().Length == 0)
            {
                lblSucursalEliminado.Text = "Ingrese id de sucursal";
            }
            else
            {
                neg.EliminarSucursal(tbxSucursal.Text);
                lblSucursalEliminado.Text = "Sucursal eliminada";
            }

        }
    }
}