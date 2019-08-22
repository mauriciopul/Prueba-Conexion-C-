using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaConexion
{
    public partial class Form1 : Form
    {
        Conexion c = new Conexion();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Conexion c = new Conexion();
            c.cargarPersonas(dgvPersonas);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (c.personaRegistrada(Convert.ToInt32(txtId.Text)) == 0)
            {                
                MessageBox.Show(c.insertar(Convert.ToInt32(txtId.Text), txtNombre.Text, txtApellido.Text, dtFechaNacim.Text));
                this.limpiar();
                c.cargarPersonas(dgvPersonas);
            }
            else
            {
                MessageBox.Show("El registro ya existe y no se puede registrar de nuevo");
            }
        }
        public void limpiar()
        {
            txtApellido.Clear();
            txtNombre.Clear();
            txtId.Clear();
            dtFechaNacim.Text = "01/01/1990";
        }
    }
}
