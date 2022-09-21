using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace Vista
{
    public partial class ListadoSucursales : System.Web.UI.Page
    {
        NegocioCategorias neg= new NegocioCategorias();
        protected void Page_Load(object sender, EventArgs e)
        {
           

                if (!IsPostBack)
                { 
                
                gdSucursales.DataSource = neg.ObtenerTablaSucursales();
                gdSucursales.DataBind();
                }

            
           
        }

        protected void gdSucursales_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}