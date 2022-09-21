using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace TP_4
{
    public partial class Ejercicio1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string rutaViajes = "Data Source=localhost\\sqlexpress;Initial Catalog=Viajes;Integrated Security=True";
            string consultaSql = "Select * from Provincias";
            string consulta2sql = "Select * from Localidades";
            if (!IsPostBack)
            {
                SqlConnection cnViajes = new SqlConnection(rutaViajes);
                SqlCommand cmd = new SqlCommand(consultaSql, cnViajes);
                cnViajes.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ddlProvinciaInicio.Items.Add(dr["NombreProvincia"] + "");
                }
                cnViajes.Close();

                SqlConnection cnLocalidades = new SqlConnection(rutaViajes);
                SqlCommand cmd1 = new SqlCommand(consulta2sql, cnLocalidades);
                cnLocalidades.Open();
                SqlDataReader dr1 = cmd1.ExecuteReader();
                while (dr1.Read())
                {
                    if (dr1["IdProvincia"].Equals(ddlProvinciaInicio.SelectedIndex + 1) == true)
                    {
                        ddlLocalidadInicio.Items.Add(dr1["NombreLocalidad"] + "");
                    }

                }
                cnLocalidades.Close();

                string testQuery = consultaSql + " where idProvincia != 1";
                SqlConnection cnProvinciasFin = new SqlConnection(rutaViajes);
                SqlCommand cmd3 = new SqlCommand(testQuery, cnProvinciasFin);
                cnProvinciasFin.Open();
                SqlDataReader dr3 = cmd3.ExecuteReader();
                ddlProvinciaFinal.DataSource = dr3;
                ddlProvinciaFinal.DataTextField = "NombreProvincia";
                ddlProvinciaFinal.DataValueField = "IdProvincia";
                ddlProvinciaFinal.DataBind();
                cnProvinciasFin.Close();


                cargarLocalidadesFinal();
            }
        }

        protected void ddlProvinciaInicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddlLocalidadInicio.Items.Clear();
            ddlProvinciaFinal.Items.Clear();
            string rutaViajes = "Data Source=localhost\\sqlexpress;Initial Catalog=Viajes;Integrated Security=True";
            string consulta2sql = "Select * from Localidades";

            SqlConnection cnLocalidades = new SqlConnection(rutaViajes);
            SqlCommand cmd1 = new SqlCommand(consulta2sql, cnLocalidades);
            cnLocalidades.Open();
            SqlDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                if (dr1["IdProvincia"].Equals(ddlProvinciaInicio.SelectedIndex + 1) == true)
                {
                    ddlLocalidadInicio.Items.Add(dr1["NombreLocalidad"] + "");
                }

            }
            cnLocalidades.Close();


            string consultaSql = "Select * from Provincias where IdProvincia !=" + (ddlProvinciaInicio.SelectedIndex + 1);
            SqlConnection cnProvinciasFin = new SqlConnection(rutaViajes);
            SqlCommand cmd3 = new SqlCommand(consultaSql, cnProvinciasFin);
            cnProvinciasFin.Open();
            SqlDataReader dr3 = cmd3.ExecuteReader();
            ddlProvinciaFinal.DataSource = dr3;
            ddlProvinciaFinal.DataTextField = "NombreProvincia";
            ddlProvinciaFinal.DataValueField = "IdProvincia";
            ddlProvinciaFinal.DataBind();
            cnProvinciasFin.Close();

            cargarLocalidadesFinal();
        }

        protected void ddlProvinciaFinal_SelectedIndexChanged(object sender, EventArgs e)
        {

            cargarLocalidadesFinal();
        }

        protected void cargarLocalidadesFinal()
        {
            string rutaViajes = "Data Source=localhost\\sqlexpress;Initial Catalog=Viajes;Integrated Security=True";
            string consulta2sql = "Select * from Localidades where IdProvincia = " + ddlProvinciaFinal.SelectedValue;

            SqlConnection cnLocalidadesFin = new SqlConnection(rutaViajes);
            SqlCommand cmd4 = new SqlCommand(consulta2sql, cnLocalidadesFin);
            cnLocalidadesFin.Open();
            SqlDataReader dr4 = cmd4.ExecuteReader();
            ddlLocalidadFinal.DataSource = dr4;
            ddlLocalidadFinal.DataTextField = "NombreLocalidad";
            ddlLocalidadFinal.DataBind();

            cnLocalidadesFin.Close();
        }
    }
}