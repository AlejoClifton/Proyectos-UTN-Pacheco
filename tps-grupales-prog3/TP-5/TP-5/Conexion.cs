using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace TP_5
{
    public class Conexion
    {
        public const String ruta = "Data Source=localhost\\sqlexpress;Initial Catalog=BDsucursales;Integrated Security=True";

        public int ejecutarConsulta(String consulta)
        {
            SqlConnection conexion = new SqlConnection(ruta);
            conexion.Open();
            
            SqlCommand comando = new SqlCommand(consulta, conexion);

            int filas = comando.ExecuteNonQuery();

            conexion.Close();
            return filas;
        }

        public void cargoBD(int filas, Label lbl)
        {
            if (filas==0)
            {
                lbl.Text = "No se pudo cargar en la base de datos.";
            }
            else
            {
                lbl.Text = "Se cargaron los datos correctamente.";
            }            
        }

        public void eliminoBD(int filas, Label lbl)
        {
            if (filas == 0)
            {
                lbl.Text = "No existe la sucursal.";
            }
            else
            {
                lbl.Text = "La sucursal se a eliminado con exito";
            }
        }

        public int loadDdl(DropDownList ddl,string query,int colValue, int colId)
        {
            SqlConnection conn = new SqlConnection(Conexion.ruta);
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListItem item = new ListItem(dr[colValue] + "", dr[colId] + "");
                ddl.Items.Add(item);
            }
            conn.Close();
            return 0;
        }

        public void mostrarGridView(GridView gd ,string consulta, string tabla)
        {
                DataSet ds = new DataSet();
                SqlConnection con = new SqlConnection(ruta);
                con.Open();
                SqlDataAdapter ad = new SqlDataAdapter(consulta, con);

                ad.Fill(ds, tabla);

                gd.DataSource = ds.Tables[tabla];
                gd.DataBind();

                con.Close();
        }
    }
}