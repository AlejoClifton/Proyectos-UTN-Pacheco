using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace TP_4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                SqlConnection cn = new SqlConnection("Data Source=localhost\\sqlexpress;Initial Catalog=Neptuno;Integrated Security=True");
                cn.Open();
                SqlCommand cmd = new SqlCommand("Select * from productos", cn);

                SqlDataReader dr = cmd.ExecuteReader();

                grdProductos.DataSource = dr;
                grdProductos.DataBind();

                cn.Close();
            }
            
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (txtProducto.Text.Length != 0 || txtCategoria.Text.Length != 0)
            {
                SqlCommand cmd;
                SqlConnection cn = new SqlConnection("Data Source=localhost\\sqlexpress;Initial Catalog=Neptuno;Integrated Security=True");
                cn.Open();
                string consulta = "";

                if (txtProducto.Text.Length != 0)
                {
                    if (txtCategoria.Text.Length != 0)
                    {
                        consulta = "Select * from productos where idCategoría " + ddlCategoria.SelectedValue + txtCategoria.Text + " and idProducto " + ddlProducto.SelectedValue + txtProducto.Text;
                    }
                    else
                    {
                        consulta = "Select * from productos where idProducto " + ddlProducto.SelectedValue + txtProducto.Text;
                    }
                }
                else if (txtCategoria.Text.Length != 0)
                {
                    consulta = "Select * from productos where idCategoría " + ddlCategoria.SelectedValue + txtCategoria.Text;
                }

                cmd = new SqlCommand(consulta, cn);

                SqlDataReader dr = cmd.ExecuteReader();

                grdProductos.DataSource = dr;
                grdProductos.DataBind();
                cn.Close();
            }
            else
            {
                SqlConnection cn = new SqlConnection("Data Source=localhost\\sqlexpress;Initial Catalog=Neptuno;Integrated Security=True");
                cn.Open();
                SqlCommand cmd = new SqlCommand("Select * from productos", cn);

                SqlDataReader dr = cmd.ExecuteReader();

                grdProductos.DataSource = dr;
                grdProductos.DataBind();

                cn.Close();
            }
        }

        protected void btonQuitarFiltro_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=localhost\\sqlexpress;Initial Catalog=Neptuno;Integrated Security=True");
            cn.Open();
            SqlCommand cmd = new SqlCommand("Select * from productos", cn);

            SqlDataReader dr = cmd.ExecuteReader();

            grdProductos.DataSource = dr;
            grdProductos.DataBind();

            cn.Close();
        }
    }  
}