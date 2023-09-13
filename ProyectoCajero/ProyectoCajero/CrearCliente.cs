using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaCajero;

namespace ProyectoCajero
{
    public partial class CrearCliente : Form
    {
        public CrearCliente()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cedula =int.Parse(textBox1.Text);
            string direcccion = textBox2.Text;
            string email = textBox3.Text;
            string nombre = textBox4.Text;
            int telefono = int.Parse(textBox5.Text);

            Cliente clientex = new Cliente(cedula,direcccion,email,nombre,telefono);
           
            Close();

            Exito i = new Exito();
            i.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void CrearCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
