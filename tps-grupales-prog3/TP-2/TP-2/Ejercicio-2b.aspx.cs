using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP_2
{
    public partial class Ejercicio_2b : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            lblName.Text = Request["TxtNombre"].ToString();
            lblLastName.Text = Request["TxtApellido"].ToString();
            lblZone.Text = Request["DropDownList1"].ToString();
            string temasAux= "<ul>";
            var temas = (CheckBoxList)PreviousPage.FindControl("chbxTemas");
            foreach( ListItem tema in temas.Items )
            {
                if (tema.Selected)
                {
                    temasAux += "<li>" + tema.Text + "</li>";
                }
            }
            lblTemas.Text = temasAux + "</ul>";
        }
    }
}