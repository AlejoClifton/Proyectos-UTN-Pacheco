using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Web.UI.WebControls;

namespace TP7_GRUPO2
{
    public class Conexion
    {
        public const String ruta = "Data Source=localhost\\sqlexpress;Initial Catalog=BDSucursales;Integrated Security=True";

        public void cargarDatosdl(DataList dl, string consulta, string tabla)
        {
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(ruta);
            con.Open();
            SqlDataAdapter ad = new SqlDataAdapter(consulta, con);

            ad.Fill(ds, tabla);

            dl.DataSource = ds.Tables[0];
            dl.DataBind();

            con.Close();
        }
    }
}