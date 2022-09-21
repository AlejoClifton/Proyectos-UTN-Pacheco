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
    public partial class FormEjercicio1 : Form
    {
        public FormEjercicio1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox_Izq.SelectedItems.IndexOf(listBox_Izq.SelectedItem) == -1)
                {
                    throw new Exception("No hay valores seleccionados");
                }
                listBox_Der.Items.Add(listBox_Izq.SelectedItem);
                listBox_Izq.Items.Remove(listBox_Izq.SelectedItem);

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool repetido=false;
            
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese un nombre");
                
            }
            else
            {
                foreach (var item in listBox_Izq.Items)
                {
                    if (textBox1.Text.ToUpper().Equals(item.ToString().ToUpper())) {
                        repetido = true;
                        MessageBox.Show("Ese nombre ya se encuentra en la lista izquierda");
                        break;
                    }
                };
                foreach (var item in listBox_Der.Items)
                {
                    if (textBox1.Text.ToUpper().Equals(item.ToString().ToUpper()))
                    {
                        repetido = true;
                        MessageBox.Show("Ese nombre ya se encuentra en la lista derecha");
                        break;
                    }
                };

                if (!repetido) { listBox_Izq.Items.Add(textBox1.Text); };

                textBox1.Text ="";
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox_Izq.Items.Count != 0)
            {
                foreach (var item in listBox_Izq.Items)
                {
                    listBox_Der.Items.Add(item);
                }
                listBox_Izq.Items.Clear();
            }
            else
            {
                MessageBox.Show("La lista esta en blanco");
            }
            
        }
    }
}
