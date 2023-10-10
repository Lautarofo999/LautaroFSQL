using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LautaroFSQL
{
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }
        Principal principal = new Principal();

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Clientes Nuevoclientes = new Clientes();

            Nuevoclientes.nombre = txtNombre.Text;
            Nuevoclientes.apellido = apellidotxt.Text;
            Nuevoclientes.dni = int.Parse(dnitxt.Text);
            principal.AgregarCliente(Nuevoclientes);

            listBox1.DataSource = null;
            listBox1.DataSource = principal.ListaClientes();
            listBox1.DisplayMember = "MostrarCliente";


        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = principal.ListaClientes();
            listBox1.DisplayMember = "MostrarCliente";
        }
    }
}
