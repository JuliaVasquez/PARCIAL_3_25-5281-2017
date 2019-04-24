using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            double Cantidad;
            Cantidad = int.Parse(textBox3.Text);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            double Porcentaje;
            Porcentaje = int.Parse(textBox2.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
