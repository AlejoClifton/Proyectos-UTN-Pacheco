using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace TP_6
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        Conexion con = new Conexion();
       

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                string query = "Select IdProducto, NombreProducto, idProveedor, CantidadPorUnidad, PrecioUnidad from Productos";

                con.cargarGridView(gvProductos, query, "Producto");
            }
        }
        protected void gvProductos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            string query = "Select IdProducto, NombreProducto, idProveedor, CantidadPorUnidad, PrecioUnidad from Productos";

            gvProductos.PageIndex = e.NewPageIndex;

            con.cargarGridView(gvProductos, query, "Producto");
        }

        protected void gvProductos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void grdProducto_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            bool repetido = false;
            string s_IdProducto = ((Label)gvProductos.Rows[e.NewSelectedIndex].FindControl("lbl_IdProducto")).Text;
            if (Session["Seleccionados"] == null)
            {
                Session["Seleccionados"] = CrearTabla();
            }
            foreach (DataRow check in ((DataTable)Session["Seleccionados"]).Rows)
            {
                if (check["IdProducto"].ToString() == s_IdProducto)
                {
                    repetido = true;
                    lbl_Repetido.Text = "Ya seleccionaste este producto";
                }
                
            }
            if (!repetido)
            {
                lbl_Repetido.Text= "";
                string s_NombreProducto = ((Label)gvProductos.Rows[e.NewSelectedIndex].FindControl("lbl_NombreProducto")).Text;
                string s_IdProveedor = ((Label)gvProductos.Rows[e.NewSelectedIndex].FindControl("lbl_IdProveedor")).Text;
                string s_CantidadPorUnidad = ((Label)gvProductos.Rows[e.NewSelectedIndex].FindControl("lbl_CantidadPorUnidad")).Text;
                string s_PrecioUnidad = ((Label)gvProductos.Rows[e.NewSelectedIndex].FindControl("lbl_PrecioUnidad")).Text;
                lbl_Agregado.Text += "<br/>" + s_NombreProducto;

                String[] Producto = { s_IdProducto, s_NombreProducto, s_IdProveedor, s_CantidadPorUnidad, s_PrecioUnidad };
                
                AgregarFila((DataTable)Session["Seleccionados"], Producto);
            }            
                      
        }
   
        public static DataTable CrearTabla()
        {
            DataTable dt = new DataTable();
            DataColumn columna = new DataColumn("IdProducto", System.Type.GetType("System.String"));
            dt.Columns.Add(columna);
            columna = new DataColumn("NombreProducto", System.Type.GetType("System.String"));
            dt.Columns.Add(columna);
            columna = new DataColumn("IdProveedor", System.Type.GetType("System.String"));
            dt.Columns.Add(columna);
            columna = new DataColumn("CantidadPorUnidad", System.Type.GetType("System.String"));
            dt.Columns.Add(columna);
            columna = new DataColumn("PrecioUnidad", System.Type.GetType("System.String"));
            dt.Columns.Add(columna);

            return dt;
        }
        public void AgregarFila(DataTable tabla, String[] Datos)
        {
            DataRow dr = tabla.NewRow();
            dr["IdProducto"] = Datos[0];
            dr["NombreProducto"] = Datos[1];
            dr["IdProveedor"] = Datos[2];
            dr["CantidadPorUnidad"] = Datos[3];
            dr["PrecioUnidad"] = Datos[4];

            tabla.Rows.Add(dr);
        }

    }
}