using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace TP7_GRUPO2
{
    public partial class SeleccionarSucursales : System.Web.UI.Page
    {
        Conexion con = new Conexion();
        TablaSesion ts = new TablaSesion();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string consulta = "Select * from Provincia";
                string tabla = "Provincia";
                con.cargarDatosdl(dlProvincias, consulta, tabla);
            }
        }

        protected void btnSeleccionar_Command(object sender, CommandEventArgs e)
        {
            if(e.CommandName == "eventButton")
            {
                if (Session["Seleccionados"] == null)
                {
                    Session["Seleccionados"] = TablaSesion.CrearTabla();
                }
                string[] cols = e.CommandArgument.ToString().Split(',');
                TablaSesion.AgregarFila( (DataTable)Session["Seleccionados"] , cols);

            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscarSucursal.Text == "")
            {
                SqlDataSource1.SelectCommand = "SELECT [Id_Sucursal], [NombreSucursal], [DescripcionSucursal], [Id_HorarioSucursal], [Id_ProvinciaSucursal], [DireccionSucursal], [URL_Imagen_Sucursal] FROM [Sucursal] where 1=1";
            }
            else
            {
                SqlDataSource1.SelectCommand = "SELECT [Id_Sucursal], [NombreSucursal], [DescripcionSucursal], [Id_HorarioSucursal], [Id_ProvinciaSucursal], [DireccionSucursal], [URL_Imagen_Sucursal] FROM [Sucursal] where [NombreSucursal] LIKE ('%" + txtBuscarSucursal.Text + "%')";
                txtBuscarSucursal.Text = null;
            }

        }

        protected void btnProvincias_Command(object sender, CommandEventArgs e)
        {
            if (e.CommandName == "cmdBoton")
            {
                
                SqlDataSource1.SelectCommand = "SELECT [Id_Sucursal], [NombreSucursal], [DescripcionSucursal], [Id_HorarioSucursal], [Id_ProvinciaSucursal], [DireccionSucursal], [URL_Imagen_Sucursal] FROM [Sucursal] inner join Provincia on Id_Provincia=Id_ProvinciaSucursal where [descripcionProvincia] =('" + e.CommandArgument.ToString() + "')";
           
            }
        }
    }
}