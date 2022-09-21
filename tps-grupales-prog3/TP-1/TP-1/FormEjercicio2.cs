using System;
using System.Collections;
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
    public partial class FormEjercicio2 : Form
    {
        public FormEjercicio2()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool repetido=false;
          
            if (tbxNombre.Text.Trim().Length == 0 || tbxApellido.Text.Trim().Length == 0)
            {
                MessageBox.Show("Por favor, ingresar un nombre o apellido");
                
            }
            else
            {
                foreach (var item in listbElementos.Items)
                {
                    if ($"{tbxNombre.Text.ToUpper()} {tbxApellido.Text.ToUpper()}" == item.ToString().ToUpper())
                    {
                        repetido = true;
                        MessageBox.Show("Este Nombre ya se encuentra en la lista, ingresar otro");
                        break;
                    }
                }

                if (!repetido)
                {
                    listbElementos.Items.Add($"{tbxNombre.Text} {tbxApellido.Text}");
                }

                listbElementos.Sorted = true;

                tbxNombre.Text = "";
                tbxApellido.Text = "";
                
            }

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            listbElementos.Items.Remove(listbElementos.SelectedItem);
        }

        private void listbElementos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbxApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
