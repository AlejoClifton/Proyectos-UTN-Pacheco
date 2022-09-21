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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEjercicio1_Click(object sender, EventArgs e)
        {
            var formEj1 = new FormEjercicio1();
            formEj1.Show();
        }

        private void btnEjercicio2_Click(object sender, EventArgs e)
        {
            var formEj2 = new FormEjercicio2();
            formEj2.Show();
        }

        private void btnEjercicio3_Click(object sender, EventArgs e)
        {
            var formEj3 = new FormEjercicio3();
            formEj3.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
