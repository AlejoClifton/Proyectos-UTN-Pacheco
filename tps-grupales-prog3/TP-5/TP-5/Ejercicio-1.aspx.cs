using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


namespace TP_5
{
    
    public partial class Ejercicio_1 : System.Web.UI.Page
    {
        Conexion conexion = new Conexion();
        protected void Page_Load(object sender, EventArgs e)
        {
            string query = "select * from provincia";
            conexion.loadDdl(ddlProvincias, query, 1, 0);
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            string agregarSucursal = "insert into sucursal(NombreSucursal, DescripcionSucursal, id_ProvinciaSucursal, DireccionSucursal) Values ('" + tbxNombreSucursal.Text + "','" + tbxDescripcion.Text + "','" + ddlProvincias.SelectedValue + "','" + tbxDireccion.Text + "')";

            if (tbxNombreSucursal.Text.Trim().Length == 0 || tbxDireccion.Text.Trim().Length == 0 || tbxDescripcion.Text.Trim().Length == 0)
            {
                lblSucursalCargada.Text = "No se aceptan campos vacios";
            }
            else
            {
                int cargo = conexion.ejecutarConsulta(agregarSucursal);
                conexion.cargoBD(cargo, lblSucursalCargada);
            }

            
        }

        protected void ddlProvincias_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}