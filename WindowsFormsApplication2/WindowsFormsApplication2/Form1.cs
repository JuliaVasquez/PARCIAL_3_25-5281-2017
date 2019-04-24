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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            String usuario;
            usuario = textBox1.Text.TrimEnd();
            

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            String contraseña;
            contraseña = textBox2.Text.TrimEnd();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("usuario: " + textBox1.Text+" "+"contraseña"+textBox2.Text);
        }
    }
}
