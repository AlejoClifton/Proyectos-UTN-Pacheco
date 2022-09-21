using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP_2
{
    public partial class Ejercicio_5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ddlMemoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            float vMemoria= float.Parse(ddlMemoria.SelectedValue);
            float vComponentes = 0;
            float v;

            foreach (ListItem s in cblComponentes.Items)
            { 
                if (s.Selected)
                {
                    vComponentes += float.Parse(s.Value);
                }
            }
            v = vComponentes + vMemoria;
            lblPrecio.Text = v.ToString()  + "$";
        }
    }
}