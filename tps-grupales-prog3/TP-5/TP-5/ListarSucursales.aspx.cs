using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace TP_5
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Conexion con = new Conexion();
                string query = "Select S.Id_Sucursal, S.NombreSucursal, S.DescripcionSucursal, P.DescripcionProvincia as Provincia, S.DireccionSucursal from Sucursal as S inner join Provincia as P on P.Id_Provincia = S.Id_ProvinciaSucursal";

                con.mostrarGridView(gdSucursales, query, "Sucursal");
            }
        }
        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            int a;
            bool x;
            if (x=int.TryParse(txtIdSucursal.Text,out a))
            {
                a = int.Parse(txtIdSucursal.Text);
                Conexion con = new Conexion();
                string query = "Select S.Id_Sucursal, S.NombreSucursal, S.DescripcionSucursal, P.DescripcionProvincia as Provincia, S.DireccionSucursal from Sucursal as S inner join Provincia as P on P.Id_Provincia = S.Id_ProvinciaSucursal where Id_Sucursal = " + a.ToString();

                con.mostrarGridView(gdSucursales, query, "Sucursal");
            }
        }
        protected void txtIdSucursal_TextChanged(object sender, EventArgs e)
        {

        }
        protected void btnMostrarTodo_Click(object sender, EventArgs e)
        {
            Conexion con = new Conexion();
            string query = "Select S.Id_Sucursal, S.NombreSucursal, S.DescripcionSucursal, P.DescripcionProvincia as Provincia, S.DireccionSucursal from Sucursal as S inner join Provincia as P on P.Id_Provincia = S.Id_ProvinciaSucursal";


            con.mostrarGridView(gdSucursales, query, "Sucursal");
        }
    }
}