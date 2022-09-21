using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_1
{
    public partial class FormEjercicio3 : Form
    {
        public FormEjercicio3()
        {
            InitializeComponent();
        }

        private void btnShowSelection_Click(object sender, EventArgs e)
        {
            string mostrar;

            mostrar = "Sexo: " + (string)(rbtnMasc.Checked ? "Hombre" : "Mujer") + "\r\n";
            mostrar += "Estado Civil: " + (string)(rbtnMarried.Checked ? "Casado" : "Soltero") + "\r\n";
            
            foreach(string item in chklbOccupation.CheckedItems)
            {
               mostrar += chklbOccupation.GetItemText(item) + "\r\n";
            }

            lblMostrarseleccion.Text = mostrar;
        }
    }
}
