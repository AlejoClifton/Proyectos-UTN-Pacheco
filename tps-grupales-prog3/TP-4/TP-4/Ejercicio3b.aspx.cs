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
    public partial class Ejercicio3b : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                string tema = Request.QueryString["tema"];
                if (tema!=null) { 
                SqlConnection cn = new SqlConnection("Data Source=localhost\\sqlexpress;Initial Catalog=Libreria;Integrated Security=True");
                cn.Open();
                SqlCommand cmd = new SqlCommand("Select * from Libros where idtema ="+tema, cn);
                SqlDataReader dr = cmd.ExecuteReader();

                grdLibros.DataSource = dr;
                grdLibros.DataBind();

                cn.Close();
                }
                
            }
            
        }

        protected void lbVerLibros_Click1(object sender, EventArgs e)
        {
            Response.Redirect("Ejercicio3.aspx");
        }
    }
}